using UnityEngine;

namespace DefaultNamespace
{
    public class FarState : AbstractState
    {
        public FarState(FiniteStateMachine newMachine)
        {
            machine = newMachine;
        }

        public override void Update()
        {
            mousePosition = Input.mousePosition;
            if (withinBounds(mousePosition))
                {
                    machine.switchColor(Color.yellow);
                }
            else
            {
                machine.switchState(new CloseState(machine));
            }
        }
    }
}