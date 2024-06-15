using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace FreeSql.Interface
{
    public interface IGlobalCacheFactory
    {
        T CreateCacheItem<T>(string cacheKey, T defaultValue = null) where T : class, new();
        T CreateCacheItem<T>(string cacheKey) where T : new();
    }
}
