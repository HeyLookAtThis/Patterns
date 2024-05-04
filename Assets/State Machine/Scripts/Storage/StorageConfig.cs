using UnityEngine;

[CreateAssetMenu(fileName = "StorageConfig", menuName = "Configs/StorageConfig")]
public class StorageConfig : ScriptableObject
{
    [SerializeField] private CapacityConfig _capacityConfig;

    public CapacityConfig CapacityConfig => _capacityConfig;
}
