using UnityEngine;

namespace DesignPattern.Editor.Tests
{
    public class ServiceA
    {
        public void Initialize(string message = null)
        {
            Debug.Log(message: $"ServiceA.Initialize({message})");
        }
    }
}
