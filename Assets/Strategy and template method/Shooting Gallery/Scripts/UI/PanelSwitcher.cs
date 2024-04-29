using UnityEngine;

public class PanelSwitcher : MonoBehaviour
{
    [SerializeField] private MenuPanel _menu;
    [SerializeField] private WinPanel _winPanel;
    [SerializeField] private VictoryInitializer _victorySetter;

    private Panel[] _panels;

    private void Awake()
    {
        _panels = new Panel[] { _menu, _winPanel };
    }

    private void OnEnable()
    {
        _victorySetter.Done += OnSubscribe;
    }

    private void OnDisable()
    {
        _victorySetter.Done -= OnSubscribe;
        _victorySetter.Victory.HasCome -= OnSetWinPanel;
    }

    private void Start()
    {
        SetPanel(_menu);
    }

    private void OnSubscribe()
    {
        OnTurnOffPanels();
        _victorySetter.Victory.HasCome += OnSetWinPanel;
    }

    private void OnSetWinPanel()
    {
        SetPanel(_winPanel);
    }

    private void OnTurnOffPanels()
    {
        foreach (var panel in _panels)
            panel.gameObject.SetActive(false);
    }

    private void SetPanel(Panel panel)
    {
        foreach (var window in _panels)
        {
            if (window == panel)
                window.gameObject.SetActive(true);
            else
                window.gameObject.SetActive(false);
        }
    }
}
