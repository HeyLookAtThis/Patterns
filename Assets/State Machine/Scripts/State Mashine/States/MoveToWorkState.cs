public class MoveToWorkState : MovementState
{
    public MoveToWorkState(IStateSwitcher stateSwitcher, Character character) : base(stateSwitcher, character)
    => TargetPosition = MovementStateConfig.WorkingPlace;

    public override void Update()
    {
        base.Update();

        if (Character.transform.position == TargetPosition)
            StateSwitcher.SwitchState<WorkingState>();
    }
}
