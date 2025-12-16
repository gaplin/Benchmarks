namespace Visitor._10Targets;

public interface I10Visitor
{
    void DoSmth1(Target10_1 target);

    void DoSmth2(Target10_2 target);

    void DoSmth3(Target10_3 target);

    void DoSmth4(Target10_4 target);

    void DoSmth5(Target10_5 target);

    void DoSmth6(Target10_6 target);

    void DoSmth7(Target10_7 target);

    void DoSmth8(Target10_8 target);

    void DoSmth9(Target10_9 target);

    void DoSmth10(Target10_10 target);
}

public abstract class Base10Target
{
    public abstract void Accept(I10Visitor visitor);
}

public sealed class Target10_1 : Base10Target
{
    public int Value { get; set; }

    public override void Accept(I10Visitor visitor)
    {
        visitor.DoSmth1(this);
    }
}

public sealed class Target10_2 : Base10Target
{
    public decimal Value { get; set; }

    public override void Accept(I10Visitor visitor)
    {
        visitor.DoSmth2(this);
    }
}

public sealed class Target10_3 : Base10Target
{
    public double Value { get; set; }

    public override void Accept(I10Visitor visitor)
    {
        visitor.DoSmth3(this);
    }
}

public sealed class Target10_4 : Base10Target
{
    public long Value { get; set; }

    public override void Accept(I10Visitor visitor)
    {
        visitor.DoSmth4(this);
    }
}

public sealed class Target10_5 : Base10Target
{
    public short Value { get; set; }

    public override void Accept(I10Visitor visitor)
    {
        visitor.DoSmth5(this);
    }
}

public sealed class Target10_6 : Base10Target
{
    public char Value { get; set; }

    public override void Accept(I10Visitor visitor)
    {
        visitor.DoSmth6(this);
    }
}

public sealed class Target10_7 : Base10Target
{
    public byte Value { get; set; }

    public override void Accept(I10Visitor visitor)
    {
        visitor.DoSmth7(this);
    }
}

public sealed class Target10_8 : Base10Target
{
    public long Value { get; set; }

    public override void Accept(I10Visitor visitor)
    {
        visitor.DoSmth8(this);
    }
}

public sealed class Target10_9 : Base10Target
{
    public long Value { get; set; }

    public override void Accept(I10Visitor visitor)
    {
        visitor.DoSmth9(this);
    }
}

public sealed class Target10_10 : Base10Target
{
    public decimal Value { get; set; }

    public override void Accept(I10Visitor visitor)
    {
        visitor.DoSmth10(this);
    }
}

public sealed class Sum10Visitor : I10Visitor
{
    public decimal RollingSum;

    public void DoSmth1(Target10_1 target)
    {
        RollingSum += target.Value;
    }

    public void DoSmth10(Target10_10 target)
    {
        RollingSum += target.Value;
    }

    public void DoSmth2(Target10_2 target)
    {
        RollingSum += target.Value;
    }

    public void DoSmth3(Target10_3 target)
    {
        RollingSum += (decimal)target.Value;
    }

    public void DoSmth4(Target10_4 target)
    {
        RollingSum += target.Value;
    }

    public void DoSmth5(Target10_5 target)
    {
        RollingSum += target.Value;
    }

    public void DoSmth6(Target10_6 target)
    {
        RollingSum += target.Value;
    }

    public void DoSmth7(Target10_7 target)
    {
        RollingSum += target.Value;
    }

    public void DoSmth8(Target10_8 target)
    {
        RollingSum += target.Value;
    }

    public void DoSmth9(Target10_9 target)
    {
        RollingSum += target.Value;
    }
}

public sealed class Base10Sum
{
    public decimal RollingSum;

    public void Process(Base10Target target)
    {
        RollingSum += target switch
        {
            Target10_1 target1 => target1.Value,
            Target10_2 target2 => target2.Value,
            Target10_3 target3 => (decimal)target3.Value,
            Target10_4 target4 => target4.Value,
            Target10_5 target5 => target5.Value,
            Target10_6 target6 => target6.Value,
            Target10_7 target7 => target7.Value,
            Target10_8 target8 => target8.Value,
            Target10_9 target9 => target9.Value,
            Target10_10 target10 => target10.Value,
            _ => throw new NotImplementedException()
        };
    }
}