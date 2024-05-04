using UnityEngine;

public class MoveToRestState : MovementState
{
    public MoveToRestState(IStateSwitcher stateSwitcher, Character character) : base(stateSwitcher, character) 
        => TargetPosition = MovementStateConfig.RestingPlace;

    public override void Update()
    {
        base.Update();

        if (Vector3.Distance(Character.transform.position, TargetPosition) <= MovementStateConfig.ReachingDistance)
            StateSwitcher.SwitchState<RestingState>();
    }
}
