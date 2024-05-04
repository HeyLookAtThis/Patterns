using UnityEngine;

[CreateAssetMenu(fileName = "CharacterConfig", menuName = "Configs/CharacterConfig")]
public class CharacterConfig : ScriptableObject
{
    [SerializeField] private MovementStateConfig _movementStateConfig;

    public MovementStateConfig MovementStateConfig => _movementStateConfig;
}
