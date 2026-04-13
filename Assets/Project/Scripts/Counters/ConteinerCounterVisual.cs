using UnityEngine;

public class ConteinerCounterVisual : MonoBehaviour
{
    private const string OPEN_CLOSE = "OpenClose";

    [SerializeField] private ConteinerCounter conteinerCounter;

    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        conteinerCounter.OnPlayerGrabObject += ConteinerCounter_OnPlayerGrabObject;
    }

    private void ConteinerCounter_OnPlayerGrabObject(object sender, System.EventArgs e)
    {
        animator.SetTrigger(OPEN_CLOSE);
    }
}
