using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : GameAdapter<Hp, int>
{
    [SerializeField]
    private int _heal = 0;
    private int HealValue
    {
        get { return _heal; }
        set { _heal = value; }
    }

    private int actualHeal = 0;

    /**
     * 法术强度影响治疗值
     **/
    public override void OnPreCompute(GameObject origin) {
        Compute<Magic>(origin, delegate(int v) { actualHeal = _heal + v; });
    }

    public override void OnApply(Hp model, int value)
    {
        model.Plus(value);
    }

    /**
     * 先计算体质，再计算病态
     **/
    public override int OnCompute(GameObject target)
    {
        actualHeal = _heal;
        // 体质
        Compute<Physique>(target, delegate (int v) { actualHeal += v; });
        // 病态
        Compute<Sick>(target, delegate (int v) { actualHeal -= v; });
        return actualHeal;
    }
}
