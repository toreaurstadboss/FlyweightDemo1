using Key = string;

namespace FlyweightPatternHelloWorld
{
  
    public class Client(FlyweightFactory flyweightFactory)
    {

        private readonly FlyweightFactory _flyweightFactory = flyweightFactory;

        public void Operation(string extrinsicState)
        {
            Key key1 = extrinsicState[0].ToString();
            Key key2 = extrinsicState[0].ToString();

            IFlyweight flyweight1 = _flyweightFactory.GetFlyweight(key1);
            IFlyweight flyweight2 = _flyweightFactory.GetFlyweight(key2);

            flyweight1.Operation(extrinsicState); 
            flyweight2.Operation(extrinsicState);
        }

    }
}
