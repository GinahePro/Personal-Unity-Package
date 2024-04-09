using UnityEngine;

namespace DesignPattern.Singleton
{
    public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        protected static T instance;
        public static bool HasInstance => instance != null;

        public static T Instance
        {
            get 
            { 
                if (instance == null)
                {
                    throw new SingletonException("No "+ typeof(T) +" Singleton in scene.");
                }

                return instance; 
            }
        }
        protected virtual void Awake() => InitializeSingleton();
        protected virtual void InitializeSingleton()
        {
            if(HasInstance) throw new SingletonException("Multiple" + typeof(T) +" Singleton in scene.");
            instance = this as T;
        }
    }
}
