using UnityEngine;

public class InfinityPistol : Gun
{
    protected override void OnTryShot()
    {
        if(magazine.IsEmpty)
            magazine.Reload();

        base.OnTryShot();
    }
}
