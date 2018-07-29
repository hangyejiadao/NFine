/*******************************************************************************
 * Copyright © 2016 NFine.Framework 版权所有
 * Author: NFine
 * Description: NFine快速开发平台
 * Website：http://www.nfine.cn
*********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Code
{
    public interface ICache
    {
        /// <summary>
        /// 获取缓存
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="cacheKey"></param>
        /// <returns></returns>
        T GetCache<T>(string cacheKey) where T : class;
        /// <summary>
        /// 写入缓存 缓存时间默认为十分钟
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <param name="cacheKey"></param>
        void WriteCache<T>(T value, string cacheKey) where T : class;
        /// <summary>
        /// 写入缓存  
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <param name="cacheKey"></param>
        /// <param name="expireTime"></param>
        void WriteCache<T>(T value, string cacheKey, DateTime expireTime) where T : class;
        /// <summary>
        /// 移除缓存
        /// </summary>
        /// <param name="cacheKey"></param>
        void RemoveCache(string cacheKey);
        void RemoveCache();
    }
}
