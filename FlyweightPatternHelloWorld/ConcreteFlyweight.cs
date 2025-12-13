namespace FlyweightPatternHelloWorld
{
    public class ConcreteFlyweight(string intrinsicState) : IFlyweight
    {

        private readonly string _intrinsicState = intrinsicState;

        public void Operation(string extrinsicState)
        {
            Console.WriteLine($"Concrete Flyweight: Instrincit state {_intrinsicState}, Extrinsic state: {extrinsicState}");
        }

    }
}
