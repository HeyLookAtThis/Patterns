using System;
using UnityEngine;

[Serializable]
public class RestingStateConfig
{
    [field: SerializeField, Range(0,10)] public float Time {  get; private set; }
}
