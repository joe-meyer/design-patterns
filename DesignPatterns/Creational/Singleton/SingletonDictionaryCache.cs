using System;

namespace DesignPatterns.Creational.Singleton
{
    public static class SingletonDictionaryCache
    {
        public static DictionaryCache Instance { get; } = new DictionaryCache();
    }
}