using System.Collections.Generic;
using UnityEngine.Events;

public abstract class Victory
{
    protected UnityAction hasCome;

    public event UnityAction HasCome
    {
        add => hasCome = value;
        remove => hasCome = value;
    }

    public abstract void OnCheck(Ball ball, IReadOnlyList<Ball> balls);
}
