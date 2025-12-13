using Key = string;

namespace FlyweightPatternHelloWorld
{

    /// <summary>
    /// Factory returns Flyweight objects by combining extrinsic (explicit) state and instrinsic (implicit) state
    /// </summary>
    public class FlyweightFactory
    {

        private readonly Dictionary<Key, IFlyweight> _flyweights = [];

        public IFlyweight GetFlyweight(Key key)
        {
            if (!_flyweights.ContainsKey(key))
            {
                _flyweights[key] = new ConcreteFlyweight(intrinsicState: key);
            }

            return _flyweights[key];
        }

    }

}
