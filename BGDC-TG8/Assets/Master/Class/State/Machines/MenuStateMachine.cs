using System.Collections.Generic;
using UnityEngine;

[RequireComponent(requiredComponent: typeof(DictionaryScript<MenuType, CanvasMenu>))]

public sealed class MenuStateMachine : StateMachineScript<CanvasMenu, MenuType>
{
    private Dictionary<MenuType, CanvasMenu> dictionary;

    private void Awake()
    {
        dictionary = GetComponent<DictionaryScript<MenuType, CanvasMenu>>().Dictionary;
        currentState.gameObject.SetActive(value: true);
    }

    public override void TransitionTo(MenuType nextState)
    {
        if (dictionary.ContainsKey(key: nextState))
        {
            currentState.gameObject.SetActive(value: false);
            currentState = dictionary[nextState];
            currentState.gameObject.SetActive(value: true);
        }
    }
}