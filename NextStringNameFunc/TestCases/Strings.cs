namespace NextStringNameFunc.TestCases;

public static class Strings
{
    public static string NextNameWithString(string candidate, List<string> takenNames)
    {
        var nextCandidate = candidate;
        for (int i = 1; i <= takenNames.Count; ++i)
        {
            if (!takenNames.Contains(nextCandidate))
            {
                return nextCandidate;
            }
            nextCandidate = candidate + i;
        }
        return nextCandidate;
    }

    public static string NextNameWithStringAndHashset(string candidate, List<string> takenNames)
    {
        var hashes = takenNames.ToHashSet();
        var nextCandidate = candidate;
        for (int i = 1; i <= takenNames.Count; ++i)
        {
            if (!hashes.Contains(nextCandidate))
            {
                return nextCandidate;
            }
            nextCandidate = candidate + i;
        }
        return nextCandidate;
    }

    public static string NextNameWithStringAndHashsetWithNewLookup(string candidate, List<string> takenNames)
    {
        var hashes = takenNames.ToHashSet();
        var lookup = hashes.GetAlternateLookup<ReadOnlySpan<char>>();

        var maximumNumberOfDigits = 0;
        var listCount = takenNames.Count;
        while (listCount > 0)
        {
            maximumNumberOfDigits++;
            listCount /= 10;
        }
        Span<char> nextCandidate = stackalloc char[candidate.Length + maximumNumberOfDigits];
        Span<char> digits = nextCandidate.Slice(candidate.Length, maximumNumberOfDigits);
        candidate.CopyTo(nextCandidate);
        digits.Fill('0');
        digits[0] = '0';
        int lastDigit = -1;
        for (int i = 0; i < candidate.Length; ++i)
        {
            Span<char> currentCandidate = nextCandidate[..(candidate.Length + lastDigit + 1)];
            if (lookup.Contains(currentCandidate))
            {
                return currentCandidate.ToString();
            }

            int k = lastDigit;
            while (k >= 0 && digits[k] == '9')
            {
                digits[k] = '0';
                --k;
            }
            if (k < 0)
            {
                digits[0] = '1';
                ++lastDigit;
            }
            else
            {
                ++digits[k];
            }
        }
        return nextCandidate[..(candidate.Length + lastDigit + 1)].ToString();
    }

    public static string NextNameWithSpan(ReadOnlySpan<char> candidate, List<string> takenNames)
    {
        var maximumNumberOfDigits = 0;
        var listCount = takenNames.Count;
        while (listCount > 0)
        {
            maximumNumberOfDigits++;
            listCount /= 10;
        }
        Span<char> nextCandidate = stackalloc char[candidate.Length + maximumNumberOfDigits];
        Span<char> digits = nextCandidate.Slice(candidate.Length, maximumNumberOfDigits);
        digits.Fill('0');
        candidate.CopyTo(nextCandidate);
        var currentCandidateLength = candidate.Length;
        int digitPosition = -1;
        for (int i = 1; i <= takenNames.Count; ++i)
        {
            var contain = false;
            for (int j = 0; j < takenNames.Count; ++j)
            {
                if (takenNames[j].AsSpan().Equals(nextCandidate[..currentCandidateLength], StringComparison.Ordinal))
                {
                    contain = true;
                    break;
                }
            }
            if (!contain)
            {
                return nextCandidate[..currentCandidateLength].ToString();
            }

            int k = digitPosition;
            while (k >= 0 && digits[k] == '9')
            {
                digits[k--] = '0';
            }
            if (k < 0)
            {
                digits[0] = '1';
                digitPosition++;
                currentCandidateLength = candidate.Length + digitPosition + 1;
            }
            else
            {
                digits[k]++;
            }
        }

        return nextCandidate[..currentCandidateLength].ToString();
    }
}