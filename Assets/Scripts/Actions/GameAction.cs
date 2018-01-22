using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameAction : MonoBehaviour {

    private List<IGameAdapter> adapters = new List<IGameAdapter>();

    private void Start()
    {
        adapters.AddRange(GetComponents<MonoBehaviour>()
            .Where(item => item is IGameAdapter)
            .Select(item => item as IGameAdapter)
            .ToList());
    }

    public void Prepare(GameObject origin)
    {
        adapters.ForEach(adapter => adapter.Prepare(origin));
    }

    public void Apply(GameObject target)
    {
        adapters.ForEach(adapter => adapter.Apply(target));
    }
}
