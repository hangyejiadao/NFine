/*******************************************************************************
 * Copyright © 2016 NFine.Framework 版权所有
 * Author: NFine
 * Description: NFine快速开发平台
 * Website：http://www.nfine.cn
*********************************************************************************/
using System;
using System.Collections;
using System.Web;
using Microsoft.Extensions.Caching.Memory;


namespace NFine.Code
{
    public class Cache : ICache
    {
        protected IMemoryCache cache;

        public Cache(IMemoryCache _cache)
        {
            cache = _cache;
        }


        public T GetCache<T>(string cacheKey) where T : class
        {
            if (cache.Get(cacheKey) != null)
            {
                return (T)cache.Get(cacheKey);
            }
            return default(T);
        }
        public void WriteCache<T>(T value, string cacheKey) where T : class
        {
            cache.Set(cacheKey, value, TimeSpan.FromMinutes(10));
        }
        public void WriteCache<T>(T value, string cacheKey, DateTime expireTime) where T : class
        {
            cache.Set(cacheKey, value, expireTime - DateTime.Now);
        }
        public void RemoveCache(string cacheKey)
        {
            cache.Remove(cacheKey);
        }
        public void RemoveCache()
        {
            cache.Dispose();
        }
    }
}
