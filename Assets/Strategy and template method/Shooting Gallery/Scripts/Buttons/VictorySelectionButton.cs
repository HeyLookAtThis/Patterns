using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public abstract class VictorySelectionButton : MonoBehaviour
{
    private Button _button;
    private UnityAction<VictorySelectionButton> _clicked;

    public event UnityAction<VictorySelectionButton> Clicked
    {
        add => _clicked += value;
        remove => _clicked -= value;
    }

    private void Awake()
    {
        _button = GetComponent<Button>();
    }

    private void OnEnable()
    {
        _button.onClick.AddListener(OnClick);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(OnClick);
    }

    public void OnClick()
    {
        _clicked?.Invoke(this);
    }
}
