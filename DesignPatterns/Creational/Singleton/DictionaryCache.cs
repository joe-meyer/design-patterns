using System;
using System.Collections.Generic;

namespace DesignPatterns.Creational.Singleton
{
    public class DictionaryCache
    {
        private readonly Dictionary<string, object> _cache = new Dictionary<string, object>();

        public T GetOrAdd<T>(string key, Func<T> value)
        {
            T returnValue;
            object outValue;
            if (!_cache.TryGetValue(key, out outValue))
            {
                returnValue = value.Invoke();
                _cache.Add(key, returnValue);
            }
            else
            {
                returnValue = (T)outValue;
            }

            return returnValue;
        }
    }
}