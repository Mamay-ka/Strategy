using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProduceUnitCommand : IProduceUnitCommand
{
    public GameObject UnitPrefab => _unitPrefab;
    [InjectAsset("Chomper Variant 1")] private GameObject _unitPrefab;

    
}
