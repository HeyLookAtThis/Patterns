using UnityEngine;

public class MovementState : PeacetimeState
{
    protected readonly MovementStateConfig MovementStateConfig;
    protected Vector3 TargetPosition;

    public MovementState(IStateSwitcher stateSwitcher, Character character) : base(stateSwitcher, character)
        => MovementStateConfig = character.Config.MovementStateConfig;

    private Vector3 _direction => GetDirection().normalized;

    public override void Update()
    {
        Character.CharacterController.Move(_direction * MovementStateConfig.Speed * Time.deltaTime);
    }

    private Vector3 GetDirection() => TargetPosition - Character.transform.position;        
}
