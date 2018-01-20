using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurt : GameAdapter<Hp, int>
{
    [SerializeField]
    private int _hurt = 0;
    public int HurtValue
    {
        get { return _hurt; }
        set { _hurt = value; }
    }

    public override void OnApply(Hp model, int value)
    {
        model.Minus(value);
    }

    public override void OnPreCompute(GameObject origin)
    {
        Attack attack = origin.GetComponent<Attack>();
        if (attack != null)
        {
            _hurt = attack.GetValue();
        }
    }

    public override int OnCompute(GameObject target)
    {
        Defence defence = target.GetComponent<Defence>();
        if (defence != null)
        {
            return _hurt - defence.GetValue();
        } else
        {
            return _hurt;
        }
    }
}
