using UnityEngine;
using DesignPattern.DependencyInjection;

namespace DesignPattern.Editor.Tests
{
    public class ClassA : MonoBehaviour
    {
        ServiceA serviceA;

        [Inject]
        public void Init(ServiceA serviceA) 
        {
            this.serviceA = serviceA;
        }
        
    }
}
