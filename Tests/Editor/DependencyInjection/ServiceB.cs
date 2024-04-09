using UnityEngine;

namespace DesignPattern.Editor.Tests
{
    public class ServiceB
    {
        public void Initialize(string message = null)
        {
            Debug.Log(message: $"ServiceA.Initialize({message})");
        }
    }
}
