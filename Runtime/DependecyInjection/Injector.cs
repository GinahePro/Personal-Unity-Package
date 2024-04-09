using System;
using UnityEngine;
using DesignPattern.Singleton;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;

namespace DesignPattern.DependencyInjection
{

    [AttributeUsage(validOn: AttributeTargets.Field | AttributeTargets.Method)]
    public sealed class InjectAttribute : Attribute
    {
        public InjectAttribute() { }
    }

    [AttributeUsage(validOn: AttributeTargets.Method)]
    public sealed class ProvideAttribute : Attribute
    {
        public ProvideAttribute() { }
    }

    public class Injector : Singleton<Injector>
    {
        const BindingFlags k_BindingFlag = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic ;
        protected override void Awake()
        {
            base.Awake();

            IEnumerable<IDependencyProvider> providers  = FindMonoBehaviours().OfType<IDependencyProvider>();
            foreach(var provider in providers)
            {
                RegisterProvider(provider);
            }
        }

        static MonoBehaviour[] FindMonoBehaviours()
        {
            return FindObjectsByType<MonoBehaviour>(FindObjectsSortMode.InstanceID);
        }

        void RegisterProvider(IDependencyProvider provider)
        {
            MethodInfo[] methods = provider.GetType().GetMethods(bindingAttr:k_BindingFlag);

            foreach(var method in methods)
            {
                if (!Attribute.IsDefined(element: method, attributeType: typeof(InjectAttribute))) continue;
            }
        }
    }
}
