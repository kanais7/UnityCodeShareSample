using UnityEngine;
using Shared;

namespace UnityApp
{
    public class SharedCodeExecutor : MonoBehaviour
    {
        private void Start()
        {
            Debug.Log(SharedClass.GetText());
            SharedClass.DoSomething();
        }
    }
}
