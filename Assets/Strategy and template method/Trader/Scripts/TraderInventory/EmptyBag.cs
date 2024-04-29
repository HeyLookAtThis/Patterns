using UnityEngine;

public class EmptyBag : Bag
{
    public override void ShowItem()
    {
        Debug.Log($"Мне нечего тебе предложить");
    }
}
