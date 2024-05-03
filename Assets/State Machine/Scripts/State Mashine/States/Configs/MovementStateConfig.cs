using System;
using UnityEngine;

[Serializable]
public class MovementStateConfig
{
    [field: SerializeField, Range(0, 10)] public float Speed { get; private set; }
    [field: SerializeField] public Vector3 WorkingPlace { get; private set; }
    [field: SerializeField] public Vector3 RestingPlace { get; private set; }
}
