using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BallsStorage : MonoBehaviour
{
    private List<Ball> _content;
    private UnityAction<Ball, IReadOnlyList<Ball>> _removed;

    public event UnityAction<Ball, IReadOnlyList<Ball>> Removed
    {
        add => _removed += value;
        remove => _removed -= value;
    }

    public IReadOnlyList<Ball> Content => _content;

    private void Awake()
    {
        _content = new List<Ball>();
    }

    public void Add(Ball ball)
    {
        _content.Add(ball);
        ball.Destroying += OnRemove;
    }

    private void OnRemove(Ball ball)
    {
        _content.Remove(ball);
        _removed?.Invoke(ball, _content);
        ball.Destroying -= OnRemove;
    }
}
