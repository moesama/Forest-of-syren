using UnityEngine;

public interface IGameAdapter
{
    void Prepare(GameObject origin);
    void Apply(GameObject target);
}
