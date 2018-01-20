using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameTrigger<T, V> : MonoBehaviour where T: GameModel<V> {
    public abstract bool OnTest(T t);
    public abstract void OnTrigger();
}
