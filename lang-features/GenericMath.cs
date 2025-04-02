using System.Numerics;

namespace lang_features;


public class GenericMath
{
    public static T Sum<T>(T[] numbers) where T : INumber<T>
    {
        T result = T.Zero;
        foreach (var n in numbers)
        {
            result += n;
        }
        return result;
    }
}