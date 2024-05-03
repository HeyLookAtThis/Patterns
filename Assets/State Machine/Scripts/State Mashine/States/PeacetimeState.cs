public abstract class PeacetimeState : IState
{
    protected readonly IStateSwitcher StateSwitcher;
    protected readonly Character Character;

    protected PeacetimeState(IStateSwitcher stateSwitcher)
    => StateSwitcher = stateSwitcher;

    public abstract void Update();
}
