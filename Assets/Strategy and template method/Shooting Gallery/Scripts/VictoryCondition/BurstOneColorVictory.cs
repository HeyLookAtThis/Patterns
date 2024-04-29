using System.Collections.Generic;
using System.Linq;

public class BurstOneColorVictory : Victory
{
    public override void OnCheck(Ball ball, IReadOnlyList<Ball> balls)
    {
        if (balls.FirstOrDefault(ballInList => ballInList.Color == ball.Color && ballInList.gameObject.activeSelf) == null)
            hasCome?.Invoke();
    }
}
