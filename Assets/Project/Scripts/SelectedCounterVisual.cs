using UnityEngine;

public class SelectedCounterVisual : MonoBehaviour
{
    [SerializeField] private GameObject visualSelect;
    [SerializeField] private ClearCounter thisClearCounter;
    private void Start()
    {
        Player.Instance.OnSelectedCounterChanged += Player_OnSelectedCounterChanged;
    }

    private void Player_OnSelectedCounterChanged(object sender, Player.OnSelectedCounterChangedEventArgs e)
    {
        if(e.selectedCounter == thisClearCounter)
        {
            Show(visualSelect);
        }
        else
        {
            Hide(visualSelect);
        }
    }

    private void Show(GameObject gameObject)
    {
        gameObject.SetActive(true);
    }
    private void Hide(GameObject gameObject)
    {
        gameObject.SetActive(false);
    }
}
