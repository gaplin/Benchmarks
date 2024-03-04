using System.Runtime.CompilerServices;

namespace PropertiesVsFields;

internal class TestClass
{
    public int NoInliningProp
    {
        [MethodImpl(MethodImplOptions.NoInlining)]
        get;

        [MethodImpl(MethodImplOptions.NoInlining)]
        set;
    }

    public int AutoProp { get; set; }
    public int FieldValue;
}
