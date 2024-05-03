public class MoveToRestState : MovementState
{
    public MoveToRestState(IStateSwitcher stateSwitcher, Character character) : base(stateSwitcher, character)
    => TargetPosition = MovementStateConfig.RestingPlace;

    public override void Update()
    {
        base.Update();

        if (Character.transform.position == TargetPosition)
            StateSwitcher.SwitchState<RestingState>();
    }
}
