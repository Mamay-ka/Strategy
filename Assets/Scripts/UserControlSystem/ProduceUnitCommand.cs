using UnityEngine;
using Zenject;
public class ProduceUnitCommand : IProduceUnitCommand
{
    [Inject(Id = "Chomper Variant 1")] public string UnitName { get; }
    [Inject(Id = "Chomper Variant 1")] public Sprite Icon { get; }
    [Inject(Id = "Chomper Variant 1")] public float ProductionTime { get; }
    public GameObject UnitPrefab => _unitPrefab;
    [InjectAsset("Chomper Variant 1")] private GameObject _unitPrefab;
}

