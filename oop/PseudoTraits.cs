namespace oop;

public abstract class Trait {}

public interface ITrait<T> where T : Trait {}

public class CanRoll : Trait {}

public class CanBounce : Trait {}

public static class ShapeTraits
{
    public static void Bounce(this ITrait<CanBounce> bouncer)
    {
        Console.WriteLine("CanBounce");
    }
    
    public static void Roll(this ITrait<CanRoll> roller)
    {
        Console.WriteLine("CanRoll");
    }
}

public class Cylinder : ITrait<CanRoll> {}

public class Cube : ITrait<CanBounce> {}

public class Ball : ITrait<CanBounce>, ITrait<CanRoll> {}