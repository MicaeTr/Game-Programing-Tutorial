using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.UI;

public class FiniteStateMachine : MonoBehaviour
{
    private AbstractState currentState;

    [SerializeField]private Image background;
    // Start is called before the first frame update
    void Start()
    {
        currentState = new FarState(this);
        currentState.Update();

    }

    // Update is called once per frame
    void Update()
    {
        currentState.Update();
    }

    public void switchColor(Color color)
    {
        background.color = color;
    }

    public void switchState(AbstractState newState)
    {
        currentState = newState;
    }
}
