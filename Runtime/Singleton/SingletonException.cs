using System;

namespace DesignPattern.Singleton
{
    public class SingletonException : Exception
    {
        public SingletonException() { }
        public SingletonException(string message) : base(message) { }
    }
}
