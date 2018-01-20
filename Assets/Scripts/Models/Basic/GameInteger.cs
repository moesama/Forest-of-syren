using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameInteger : MonoBehaviour, GameNumber<int>
{
    [SerializeField]
    private int _value = 0;

    private int Value
    {
        get { return _value; }
        set
        {
            if (value > GetMax())
            {
                value = GetMax();
            }
            if (value < GetMin())
            {
                value = GetMin();
            }
            _value = value;
        }
    }

    public virtual int GetValue()
    {
        return Value;
    }

    public virtual void SetValue(int value)
    {
        this.Value = value;
    }

    public virtual void Plus(int value)
    {
        this.Value += value;
    }

    public virtual void Minus(int value)
    {
        this.Value -= value;
    }

    public virtual void Multiply(int value)
    {
        this.Value *= value;
    }

    public virtual void Divide(int value)
    {
        if (value != 0)
        {
            this.Value /= value;
        }
    }

    public virtual int GetMin()
    {
        return int.MinValue;
    }

    public virtual int GetMax()
    {
        return int.MaxValue;
    }
}
