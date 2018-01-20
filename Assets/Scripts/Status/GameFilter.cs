using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameFilter<V> : MonoBehaviour
{
    public V OnApply(V value)
    {
        return value;
    }

    public V Apply(V value)
    {
        return OnApply(value);
    }
}
