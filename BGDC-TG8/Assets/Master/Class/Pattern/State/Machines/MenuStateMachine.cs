using System.Collections.Generic;
using UnityEngine;

[RequireComponent(requiredComponent: typeof(AbstractDictionary<MenuType, CanvasMenu>))]

public sealed class MenuStateMachine : AbstractStateMachine<CanvasMenu, MenuType>
{
    private Dictionary<MenuType, CanvasMenu> dictionary;

    private void Awake()
    {
        dictionary = GetComponent<AbstractDictionary<MenuType, CanvasMenu>>().Dictionary;
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