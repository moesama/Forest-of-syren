using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hp : GameInteger
{
    private MaxHp maxHp;

    private void Start()
    {
        maxHp = GetComponent<MaxHp>();
        if (maxHp != null)
        {
            SetValue(maxHp.GetValue());
        }
    }

    public override int GetMin()
    {
        return 0;
    }

    public override int GetMax()
    {
        if (maxHp != null)
        {
            return maxHp.GetValue();
        } else
        {
            return base.GetMax();
        }
    }
}
