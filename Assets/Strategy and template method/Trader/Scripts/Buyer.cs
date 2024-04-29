using UnityEngine;

public class Buyer : MonoBehaviour
{
    [SerializeField, Range(0, 10)] private int _reputaion;

    public int Reputaion => _reputaion;
}
