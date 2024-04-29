using UnityEngine;

public class Trader : MonoBehaviour
{
    private Bag _bag;

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent<Buyer>(out Buyer player))
        {
            Initialize(player.Reputaion);
            _bag.ShowItem();
        }
    }

    private void Initialize(int reputation)
    {
        int noDealValue = 0;
        int upperLimitOfBadReputation = 4;
        int upperLimitOfGoodReputation = 10;

        if (reputation == noDealValue)
            _bag = new EmptyBag();
        else if (IsWithinTheRange(reputation, noDealValue, upperLimitOfBadReputation))
            _bag = new FruitsBag();
        else if(IsWithinTheRange(reputation, upperLimitOfBadReputation, upperLimitOfGoodReputation))
            _bag = new ArmorBag();
    }

    private bool IsWithinTheRange(int value, int lowValue,  int highValue)
    {
        if (value > lowValue && value <= highValue)
            return true;

        return false;
    }
}
