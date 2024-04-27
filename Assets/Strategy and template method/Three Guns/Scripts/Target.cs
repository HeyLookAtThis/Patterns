using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Target : MonoBehaviour, IPointerClickHandler
{
    private UnityAction _clicked;

    public event UnityAction Clicked
    {
        add => _clicked = value;
        remove => _clicked = value;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        _clicked?.Invoke();
    }
}
