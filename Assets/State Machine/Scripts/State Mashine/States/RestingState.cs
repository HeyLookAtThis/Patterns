using UnityEngine;

public class RestingState : PeacetimeState
{
    private readonly Storage _storage;

    public RestingState(IStateSwitcher stateSwitcher, Character character) : base(stateSwitcher, character) => _storage = character.Storage;

    public override void Update()
    {
        _storage.RemoveItem();
    }

    public override void Enter()
    {
        base.Enter();

        Debug.Log("Отдыхаю, жи есть");
    }

    protected override void AddStorageActionCallbacks()
    {
        base.AddStorageActionCallbacks();

        _storage.Emptied += StateSwitcher.SwitchState<MoveToWorkState>;
    }

    protected override void RemoveStorageActionCallbacks()
    {
        base.RemoveStorageActionCallbacks();

        _storage.Emptied -= StateSwitcher.SwitchState<MoveToWorkState>;
    }
}
