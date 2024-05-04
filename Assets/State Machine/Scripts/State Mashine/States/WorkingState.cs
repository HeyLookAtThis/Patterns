public class WorkingState : PeacetimeState
{
    private readonly Storage _storage;

    public WorkingState(IStateSwitcher stateSwitcher, Character character) : base(stateSwitcher, character) => _storage = character.Storage;

    public override void Update()
    {
        _storage.AddItem();
    }

    protected override void AddStorageActionCallbacks()
    {
        base.AddStorageActionCallbacks();

        _storage.Fulled += StateSwitcher.SwitchState<MoveToRestState>;
    }

    protected override void RemoveStorageActionCallbacks()
    {
        base.RemoveStorageActionCallbacks();

        _storage.Fulled -= StateSwitcher.SwitchState<MoveToRestState>;
    }
}
