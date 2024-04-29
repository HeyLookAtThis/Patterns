using UnityEngine;

public class MenuPanel : Panel
{
    [SerializeField] private OneColorVictoryButton _oneColorVictoryButton;
    [SerializeField] private AllVictoryButton _allVictoryButton;

    public OneColorVictoryButton OneColorVictoryButton => _oneColorVictoryButton;

    public AllVictoryButton AllVictoryButton => _allVictoryButton;
}
