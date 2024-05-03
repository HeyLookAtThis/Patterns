using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkingState : PeacetimeState
{
    private readonly WorkingStateConfig _workingStateConfig;

    public WorkingState(IStateSwitcher stateSwitcher, Character character) : base(stateSwitcher)
    => _workingStateConfig = character.Config.WorkingStateConfig;

    private Vector3 _targetPosition => new Vector3(Character.transform.position.x, _workingStateConfig.MaxHeight, Character.transform.position.z);

    public override void Update()
    {
        Character.transform.position = Vector3.MoveTowards(Character.transform.position, _targetPosition, _workingStateConfig.TimeToReachMaxHeight * Time.deltaTime);
    }
}
