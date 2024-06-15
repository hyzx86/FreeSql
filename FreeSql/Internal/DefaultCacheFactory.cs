using FreeSql.Interface;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace FreeSql.Internal
{
    public class DefaultCacheFactory : IGlobalCacheFactory
    {
        public T CreateCacheItem<T>(string cacheKey, T defaultValue = null) where T : class, new()
        {
            return defaultValue ?? new T();
        }

        public T CreateCacheItem<T>(string cacheKey) where T : new()
        {
            return new T();
        }
    }
}
