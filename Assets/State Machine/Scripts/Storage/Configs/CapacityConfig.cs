using System;
using UnityEngine;

[Serializable]
public class CapacityConfig
{
    [field: SerializeField] public float MaxValue { get; private set; }
    public float MinValue { get; } = 0;
}
