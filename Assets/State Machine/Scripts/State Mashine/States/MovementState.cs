using UnityEngine;

public class MovementState : PeacetimeState
{
    protected readonly MovementStateConfig MovementStateConfig;
    protected Vector3 TargetPosition;

    public MovementState(IStateSwitcher stateSwitcher, Character character) : base(stateSwitcher)
    => MovementStateConfig = character.Config.MovementStateConfig;

    public override void Update()
    {
        Character.transform.position = Vector3.MoveTowards(Character.transform.position, TargetPosition, MovementStateConfig.Speed * Time.deltaTime);
        //Character.CharacterController.Move()
    }
}
