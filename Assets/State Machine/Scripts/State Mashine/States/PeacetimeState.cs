public abstract class PeacetimeState : IState
{
    protected readonly IStateSwitcher StateSwitcher;
    protected readonly Character Character;

    protected PeacetimeState(IStateSwitcher stateSwitcher, Character character)
    {
        StateSwitcher = stateSwitcher;
        Character = character;
    }

    public abstract void Update();

    public virtual void Enter()
    {
        AddStorageActionCallbacks();
    }

    public virtual void Exit()
    {
        RemoveStorageActionCallbacks();
    }

    protected virtual void AddStorageActionCallbacks() { }
    protected virtual void RemoveStorageActionCallbacks() { }
}
