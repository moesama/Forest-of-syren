using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class GameAdapter<T, V> : MonoBehaviour, IGameAdapter where T: IGameModel<V>
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

    protected void Compute<M>(GameObject target, DoCompute doCompute) where M : IGameModel<V>
    {
        M model = target.GetComponent<M>();
        if (model != null)
        {
            doCompute(model.GetValue());
        }
    }

    protected delegate void DoCompute(V value);
}
