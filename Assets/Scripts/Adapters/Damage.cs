using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : GameAdapter<Hp, int>
{
    [SerializeField]
    private int _damage = 0;
    public int DamageValue
    {
        get { return _damage; }
        set { _damage = value; }
    }

    [SerializeField]
    private int actualDamage = 0;

    public override void OnApply(Hp model, int value)
    {
        model.Minus(value);
    }

    public override void OnPreCompute(GameObject origin)
    {
        Compute<Attack>(origin, delegate (int v) { actualDamage = _damage + v; });
    }

    /**
     * 先计算易伤，再计算防御值
     **/
    public override int OnCompute(GameObject target)
    {
        // 易伤
        Compute<Vulnerability>(target, delegate(int v) { actualDamage += v; });
        // 防御
        Compute<Defence>(target, delegate (int v) { actualDamage -= v; });
        return actualDamage;
    }
}
