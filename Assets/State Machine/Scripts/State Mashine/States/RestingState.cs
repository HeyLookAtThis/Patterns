using UnityEngine;

public class RestingState : PeacetimeState
{
    private readonly RestingStateConfig _restingStateConfig;

    private float _timeHasPassed;

    public RestingState(IStateSwitcher stateSwitcher, Character character) : base(stateSwitcher)
    => _restingStateConfig = character.Config.RestingStateConfig;

    public override void Update()
    {
        _timeHasPassed += Time.deltaTime;

        if(_timeHasPassed >= _restingStateConfig.Time)
        {
            _timeHasPassed = 0;
            StateSwitcher.SwitchState<MovementState>();
        }
    }
}
