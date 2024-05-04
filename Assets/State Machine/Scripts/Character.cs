using UnityEngine;

[RequireComponent(typeof(CharacterController), typeof(Storage))]
public class Character : MonoBehaviour
{
    [SerializeField] private CharacterConfig _config;

    private CharacterController _characterController;
    private CharacterStateMachine _stateMachine;
    private Storage _storage;

    public CharacterController CharacterController => _characterController;
    public CharacterConfig Config => _config;
    public Storage Storage => _storage;

    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
        _storage = GetComponent<Storage>();

        _stateMachine = new CharacterStateMachine(this);
    }

    private void Update()
    {
        _stateMachine.Update();
    }
}
