using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameAdapter<T, V> : MonoBehaviour where T: GameModel<V>
{
    public abstract void OnPreCompute(GameObject origin);
    public abstract V OnCompute(GameObject target);
    public abstract void OnApply(T model, V value);

    public void Prepare(GameObject origin)
    {
        OnPreCompute(origin);
    }

    public void Apply(GameObject target)
    {
        T model = target.GetComponent<T>();
        if (model != null)
        {
            OnApply(model, OnCompute(target));
        }
    }
}
