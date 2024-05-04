using UnityEngine;

public class MoveToWorkState : MovementState
{
    public MoveToWorkState(IStateSwitcher stateSwitcher, Character character) : base(stateSwitcher, character)
        => TargetPosition = MovementStateConfig.WorkingPlace;

    public override void Update()
    {
        base.Update();

        if(Vector3.Distance(Character.transform.position, TargetPosition) <= MovementStateConfig.ReachingDistance)
            StateSwitcher.SwitchState<WorkingState>();
    }
}
