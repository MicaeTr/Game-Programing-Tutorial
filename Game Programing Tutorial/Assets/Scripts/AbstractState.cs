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

        public bool withinBounds(Vector3 position)
        {
            return position.x < 295f || position.x > 585f ||
                position.y < 125f || position.y > 250f;
        }
    }
}