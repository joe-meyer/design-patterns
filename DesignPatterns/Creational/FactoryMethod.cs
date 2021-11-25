using System;
using System.IO;
using Xunit;

namespace DesignPatterns.Creational
{
    /// <summary>
    /// While there are a million great logging libraries out there, a factory to implement different types of logging
    /// is a great example.
    /// 
    /// https://en.wikipedia.org/wiki/Factory_method_pattern
    /// </summary>
    public class FactoryMethodClient
    {
        [Fact]
        public void TestFactory()
        {
            var factory = new LoggerFactory();
            var debugLog = factory.MakeLogger(LoggingType.Debug);
            const string debugLogText = "Test log to file";
            debugLog.Log(debugLogText);
            Assert.Equal(debugLogText, File.ReadAllText("debug.log"));

            var errorLog = factory.MakeLogger(LoggingType.Error);
            const string errorLogText = "Test error to file";
            errorLog.Log(errorLogText);
            Assert.Equal(errorLogText, File.ReadAllText("error.log"));
        }
    }

    public interface ILogger
    {
        public void Log(string text);
    }
    
    public class TextFileLogger : ILogger
    {
        private readonly string _logFile;

        public TextFileLogger(string logFile)
        {
            _logFile = logFile;
        }
        public void Log(string text)
        {
            File.WriteAllText(_logFile, text);
        }
    }

    public enum LoggingType
    {
        Debug,
        Error
    }

    public class LoggerFactory
    {
        public ILogger MakeLogger(LoggingType type)
        {
            switch (type)
            {
                case LoggingType.Debug:
                    return new TextFileLogger("debug.log");
                case LoggingType.Error:
                    return new TextFileLogger("error.log");
                default:
                    throw new NotImplementedException("Logging type was not implemented");
            }
        }
    }
}