using UnityEngine;
using System.Collections;

public abstract class GameBoolean : MonoBehaviour, GameModel<bool>
{
    [SerializeField]
    protected bool value = false;

    public bool GetValue()
    {
        return value;
    }

    public void SetValue(bool value)
    {
        this.value = value;
    }

    public void And(bool value)
    {
        this.value &= value;
    }

    public void Or(bool value)
    {
        this.value |= value;
    }

    public void Xor(bool value)
    {
        this.value ^= value;
    }
}
