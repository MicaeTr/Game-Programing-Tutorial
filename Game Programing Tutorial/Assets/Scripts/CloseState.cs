using UnityEngine;

namespace DefaultNamespace
{
    public class CloseState : AbstractState
    {
        public CloseState(FiniteStateMachine newMachine)
            {
                machine = newMachine;
            }

            public override void Update()
            {
                mousePosition = Input.mousePosition;
                if (withinBounds(mousePosition))
                {
                    machine.switchState(new FarState(machine));
                }
                else
                {
                    machine.switchColor(Color.red);
                }
            }
    }
}