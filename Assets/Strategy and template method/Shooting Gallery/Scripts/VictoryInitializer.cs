using UnityEngine;
using UnityEngine.Events;

public class VictoryInitializer : MonoBehaviour
{
    [SerializeField] private BallsCreator _ballsCreator;
    [SerializeField] private BallsStorage _ballsStorage;
    [SerializeField] private MenuPanel _menuPanel;

    private Victory _victory;

    private UnityAction _done;

    public event UnityAction Done
    {
        add => _done += value;
        remove => _done -= value;
    }

    public Victory Victory => _victory;

    private void OnEnable()
    {
        _menuPanel.OneColorVictoryButton.Clicked += Run;
        _menuPanel.AllVictoryButton.Clicked += Run;
    }

    private void OnDisable()
    {
        _menuPanel.OneColorVictoryButton.Clicked -= Run;
        _menuPanel.AllVictoryButton.Clicked -= Run;
        _ballsStorage.Removed -= _victory.OnCheck;
    }

    private void Run(VictorySelectionButton selectionButton)
    {
        switch(selectionButton)
        {
            case OneColorVictoryButton:
                _victory = new BurstOneColorVictory();
                break;

            case AllVictoryButton:
                _victory = new BurstAllBallVictory();
                break;
        }

        _ballsStorage.Removed += _victory.OnCheck;
        _done?.Invoke();
    }
}
