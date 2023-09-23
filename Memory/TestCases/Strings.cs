namespace Memory.TestCases;

public static class Strings
{
    public static string NextNameWithString(string candidate, List<string> takenNames)
    {
        var nextCandidate = candidate;
        for (int i = 1; i <= takenNames.Count; ++i)
        {
            if(!takenNames.Contains(nextCandidate))
            {
                return nextCandidate;
            }
            nextCandidate = candidate + i;
        }
        return nextCandidate;
    }

    public static string NextNameWithStringAndSort(string candidate, List<string> takenNames)
    {
        takenNames.Sort();
        var pos = takenNames.IndexOf(candidate);
        if(pos == -1)
        {
            return candidate;
        }
        int suffix = 1;
        pos++;
        while(pos < takenNames.Count)
        {
            var currentCandidate = candidate + suffix;
            if (!takenNames[pos].Equals(currentCandidate, StringComparison.Ordinal))
            {
                return currentCandidate;
            }
            ++suffix;
            ++pos;
        }
        return candidate + suffix;
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

    public static string NextNameWithSpan(ReadOnlySpan<char> candidate, List<string> takenNames)
    {
        var maximumNumberOfDigits = 0;
        var listCount = takenNames.Count;
        while(listCount > 0)
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
        for(int i = 1; i <= takenNames.Count; ++i)
        {
            var contain = false;
            for(int j = 0; j < takenNames.Count; ++j)
            {
                if (takenNames[j].AsSpan().Equals(nextCandidate[..currentCandidateLength], StringComparison.Ordinal))
                {
                    contain = true;
                    break;
                }
            } 
            if(!contain)
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