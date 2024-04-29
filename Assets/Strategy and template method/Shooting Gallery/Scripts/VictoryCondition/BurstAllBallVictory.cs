using System.Collections.Generic;
using System.Linq;

public class BurstAllBallVictory : Victory
{
    public override void OnCheck(Ball ball, IReadOnlyList<Ball> balls)
    {
        if (balls.FirstOrDefault(ballInList => ballInList.gameObject.activeSelf) == null)
            hasCome?.Invoke();
    }
}
