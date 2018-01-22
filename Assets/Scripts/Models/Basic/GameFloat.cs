using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameFloat : MonoBehaviour, IGameNumber<float>
{
    [SerializeField]
    private float _value = 0f;

    private float Value
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

    public float GetValue()
    {
        return _value;
    }

    public void SetValue(float value)
    {
        this.Value = value;
    }

    public void Plus(float value)
    {
        this.Value += value;
    }

    public void Minus(float value)
    {
        this.Value -= value;
    }

    public void Multiply(float value)
    {
        this.Value *= value;
    }

    public void Divide(float value)
    {
        if (value != 0)
        {
            this.Value /= value;
        }
    }

    public float GetMin()
    {
        return float.MinValue;
    }

    public float GetMax()
    {
        return float.MaxValue;
    }

}
