using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAction : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

    void OnMouseDown()
    {
        Attack attack = GetComponent<Attack>();
        if (attack != null)
        {
            GameObject hurtObj = new GameObject();
            Hurt hurt = hurtObj.AddComponent<Hurt>();
            hurt.Prepare(gameObject);
            hurt.Apply(gameObject);
            Destroy(hurtObj);
        }
    }
}
