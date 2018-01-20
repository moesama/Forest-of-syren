using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mp : GameInteger
{
    private MaxMp maxMp;

    private void Start()
    {
        maxMp = GetComponent<MaxMp>();
        if (maxMp != null)
        {
            SetValue(maxMp.GetValue());
        }
    }

    public override int GetMin()
    {
        return 0;
    }

    public override int GetMax()
    {
        if (maxMp != null)
        {
            return maxMp.GetValue();
        }
        else
        {
            return base.GetMax();
        }
    }
}
