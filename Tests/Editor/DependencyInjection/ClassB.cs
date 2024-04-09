using DesignPattern.DependencyInjection;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPattern.Editor.Tests
{
    public class ClassB : MonoBehaviour
    {
        [Inject]
        ServiceA serviceA;
        [Inject]
        ServiceB serviceB;
    
    }
}
