using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAction : MonoBehaviour {
    public GameObject origin;

    private void Start()
    {
        GameAction action = GetComponent<GameAction>();
        if (action != null)
        {
            action.Prepare(origin);
        }
    }
}
