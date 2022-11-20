using UnityEngine;

namespace DefaultNamespace
{
    public class AbstractState
    {
        protected FiniteStateMachine machine;
        protected Vector3 mousePosition = Input.mousePosition;

        public virtual void Update()
        {
        }
        
    }
}