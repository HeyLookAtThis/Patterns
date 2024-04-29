using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public abstract class Ball : MonoBehaviour, IPointerClickHandler
{
    public abstract Color Color { get; }

    private UnityAction<Ball> _destroying;

    public event UnityAction<Ball> Destroying
    {
        add => _destroying += value;
        remove => _destroying -= value;
    }

    private void Awake()
    {
        Initialize();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        _destroying?.Invoke(this);
        gameObject.SetActive(false);
    }

    protected void Initialize()
    {
        GetComponentInChildren<MeshRenderer>().material.color = Color;
    }
}
