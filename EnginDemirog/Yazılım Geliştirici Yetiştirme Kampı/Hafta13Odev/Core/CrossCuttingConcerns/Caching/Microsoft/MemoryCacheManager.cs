using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Core.Utilities.IoC;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;

namespace Core.CrossCuttingConcerns.Caching.Microsoft
{
    public class MemoryCacheManager : ICacheManager
    {
        private readonly IMemoryCache memoryCache;

        public MemoryCacheManager()
        {
            memoryCache = ServiceTool.ServiceProvider.GetService<IMemoryCache>();
        }

        public T Get<T>(string key)
        {
            return memoryCache.Get<T>(key);
        }

        public object Get(string key)
        {
            return memoryCache.Get(key);
        }

        public void Add(string key, object value, int duration)
        {
            memoryCache.Set(key, value, TimeSpan.FromMinutes(duration));
        }

        public bool IsAdd(string key)
        {
            return memoryCache.TryGetValue(key, out _);
        }

        public void Remove(string key)
        {
            memoryCache.Remove(key);
        }

        public void RemoveByPattern(string pattern)
        {
            PropertyInfo cacheEntriesCollectionDefinition =
                typeof(MemoryCache).GetProperty("EntriesCollection", BindingFlags.NonPublic | BindingFlags.Instance);
            var cacheEntriesCollection = cacheEntriesCollectionDefinition.GetValue(memoryCache) as dynamic;
            var cacheCollectionValues = new List<ICacheEntry>();

            foreach (var cacheItem in cacheEntriesCollection)
            {
                ICacheEntry cacheItemValue = cacheItem.GetType().GetProperty("Value").GetValue(cacheItem, null);
                cacheCollectionValues.Add(cacheItemValue);
            }

            var regex = new Regex(pattern, RegexOptions.Singleline | RegexOptions.Compiled | RegexOptions.IgnoreCase);
            List<object> keysToRemove = cacheCollectionValues.Where(d => regex.IsMatch(d.Key.ToString()))
                .Select(d => d.Key).ToList();

            foreach (var key in keysToRemove) memoryCache.Remove(key);
        }
    }
}