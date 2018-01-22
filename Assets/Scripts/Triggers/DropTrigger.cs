using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropTrigger : MonoBehaviour, IDropHandler {
    public void OnDrop (PointerEventData pointerEventData) {
        GameAction action = pointerEventData.pointerDrag.GetComponent<GameAction>();
        if (action != null)
        {
            Debug.Log(pointerEventData.pointerDrag.name + " OnDrop to " + name);
            action.Apply(gameObject);
        }
	}
}
