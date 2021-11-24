using System.ComponentModel.Design;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace DesignPatterns.Creational.Singleton
{
    /// <summary>
    /// A Client showing a couple ways of managing a singleton instance. While there are other ways of doing caching in c#,
    /// a simple cache client would be one of many appropriate uses for a singleton.
    /// 
    /// https://en.wikipedia.org/wiki/Singleton_pattern
    /// </summary>
    public class Client
    {
        private const string testKey = "test";
        private const string originalTestValue = "TestValue";
        
        /// <summary>
        /// This would be the typical way of creating a singleton when leveraging a dependency injection framework.
        /// (Usually in startup.cs or program.cs)
        /// </summary>
        [Fact]
        public void TestSingletonUsingServiceProvider()
        {
            var collection = new ServiceCollection();
            collection.AddSingleton<DictionaryCache>();
            using (var serviceProvider = collection.BuildServiceProvider())
            {
                var firstInstance = serviceProvider.GetRequiredService<DictionaryCache>();
                firstInstance.GetOrAdd(testKey, () => originalTestValue);
                Assert.Equal(originalTestValue, firstInstance.GetOrAdd(testKey, () => "newValueIfNotInCache"));
                
                
                var secondInstance = serviceProvider.GetRequiredService<DictionaryCache>();
                Assert.Equal(originalTestValue, secondInstance.GetOrAdd(testKey, () => "newValueIfNotInCache"));
            }
        }
        
        /// <summary>
        /// If you're not using a DI framework to manage instances of objects, a static wrapping class to hold the instance
        /// works well
        /// </summary>
        [Fact]
        public void TestSingletonUsingStatic()
        {
            var firstInstance = SingletonDictionaryCache.Instance;
            firstInstance.GetOrAdd(testKey, () => originalTestValue);
            Assert.Equal(originalTestValue, firstInstance.GetOrAdd(testKey, () => "newValueIfNotInCache"));
            
            
            var secondInstance = SingletonDictionaryCache.Instance;
            Assert.Equal(originalTestValue, secondInstance.GetOrAdd(testKey, () => "newValueIfNotInCache"));
        }
    }
}