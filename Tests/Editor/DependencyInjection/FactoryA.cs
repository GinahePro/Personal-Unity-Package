using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPattern.Editor.Tests
{
    public class FactoryA
    {
        ServiceA cachedServiceA;
        public ServiceA CreateServiceA()
        {
            if (cachedServiceA == null)
            {
                cachedServiceA = new ServiceA();
            }
            return cachedServiceA;
        }
    }
}
