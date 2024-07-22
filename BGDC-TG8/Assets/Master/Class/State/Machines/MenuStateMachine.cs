using System.Collections.Generic;
using UnityEngine;

[RequireComponent(requiredComponent: typeof(DictionaryScript<MenuType, CanvasMenu>))]

public sealed class MenuStateMachine : StateMachineScript<CanvasMenu, MenuType>
{
    private Dictionary<MenuType, CanvasMenu> dictionary;

    private void Awake()
    {
        dictionary = GetComponent<DictionaryScript<MenuType, CanvasMenu>>().Dictionary;
        TransitionTo(nextState: currentState.Type);
    }

    public override void TransitionTo(MenuType nextState)
    {
        currentState.gameObject.SetActive(value: false);
        currentState = dictionary[nextState];
        currentState.gameObject.SetActive(value: true);
    }
}