using UnityEngine;
using DesignPattern.DependencyInjection;

namespace DesignPattern.Editor.Tests
{
    public class Provider : MonoBehaviour, IDependencyProvider
    {
        [Provide]
        public ServiceA ProvideServiceA()
        {
            return new ServiceA();
        }
        [Provide]
        public ServiceB ProvideServiceB()
        {
            return new ServiceB();
        }
        [Provide]
        public FactoryA ProvideFactoryA()
        {
            return new FactoryA();
        }
    }




}
