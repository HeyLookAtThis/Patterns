using UnityEngine;

[CreateAssetMenu(fileName = "CharacterConfig", menuName = "Configs/CharacterConfig")]
public class CharacterConfig : ScriptableObject
{
    [SerializeField] private WorkingStateConfig _workingStateConfig;
    [SerializeField] private MovementStateConfig _movementStateConfig;
    [SerializeField] private RestingStateConfig _restingStateConfig;

    public WorkingStateConfig WorkingStateConfig => _workingStateConfig;
    public MovementStateConfig MovementStateConfig => _movementStateConfig;
    public RestingStateConfig RestingStateConfig => _restingStateConfig;
}
