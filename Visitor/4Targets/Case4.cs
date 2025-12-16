namespace Visitor._4Targets;

public interface I4Visitor
{
    void DoSmth4_1(Target4_1 target);

    void DoSmth4_2(Target4_2 target);

    void DoSmth4_3(Target4_3 target);

    void DoSmth4_4(Target4_4 target);
}

public abstract class Base4Target
{
    public abstract void Accept(I4Visitor visitor);
}

public sealed class Target4_1 : Base4Target
{
    public int Value { get; set; }

    public override void Accept(I4Visitor visitor)
    {
        visitor.DoSmth4_1(this);
    }
}

public sealed class Target4_2 : Base4Target
{
    public decimal Value { get; set; }

    public override void Accept(I4Visitor visitor)
    {
        visitor.DoSmth4_2(this);
    }
}

public sealed class Target4_3 : Base4Target
{
    public double Value { get; set; }

    public override void Accept(I4Visitor visitor)
    {
        visitor.DoSmth4_3(this);
    }
}

public sealed class Target4_4 : Base4Target
{
    public long Value { get; set; }

    public override void Accept(I4Visitor visitor)
    {
        visitor.DoSmth4_4(this);
    }
}

public sealed class Sum4Visitor : I4Visitor
{
    public decimal RollingSum;

    public void DoSmth4_1(Target4_1 target)
    {
        RollingSum += target.Value;
    }

    public void DoSmth4_2(Target4_2 target)
    {
        RollingSum += target.Value;
    }

    public void DoSmth4_3(Target4_3 target)
    {
        RollingSum += (decimal)target.Value;
    }

    public void DoSmth4_4(Target4_4 target)
    {
        RollingSum += target.Value;
    }
}

public sealed class Base4Sum
{
    public decimal RollingSum;

    public void Process(Base4Target target)
    {
        RollingSum += target switch
        {
            Target4_1 target1 => target1.Value,
            Target4_2 target2 => target2.Value,
            Target4_3 target3 => (decimal)target3.Value,
            Target4_4 target4 => target4.Value,
            _ => throw new NotImplementedException()
        };
    }
}