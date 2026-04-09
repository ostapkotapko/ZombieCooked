using UnityEngine;

public class SelectedCounterVisual : MonoBehaviour
{
    [SerializeField] private GameObject[] visualGameObjectArray;
    [SerializeField] private BaseCounter thisBaseCounter;
    private void Start()
    {
        Player.Instance.OnSelectedCounterChanged += Player_OnSelectedCounterChanged;
    }

    private void Player_OnSelectedCounterChanged(object sender, Player.OnSelectedCounterChangedEventArgs e)
    {
        if(e.selectedCounter == thisBaseCounter)
        {
            foreach(GameObject visualGameObject in visualGameObjectArray)
            {
                Show(visualGameObject);
            }
        }
        else
        {
            foreach(GameObject visualGameObject in visualGameObjectArray)
            {
                Hide(visualGameObject);
            }
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
