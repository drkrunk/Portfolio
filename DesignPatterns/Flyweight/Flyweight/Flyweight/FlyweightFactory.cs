using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    class FlyweightFactory : IFlyweightFactory
    {

        private readonly IDictionary<string, Flyweight> cache = new Dictionary<string, Flyweight>();


        public Flyweight GetFlyweight(string flyWeightKey)
        {
            if (cache.TryGetValue(flyWeightKey, out Flyweight cachedFlyweight)) return cachedFlyweight;

            Flyweight newFlyweihgt = new Flyweight(flyWeightKey);
            cache.Add(flyWeightKey, newFlyweihgt);
            return newFlyweihgt;
        }
    }
}
