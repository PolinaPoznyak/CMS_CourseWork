using UnityEngine;
using UnityEngine.EventSystems;

public class ScaleButtonReset : MonoBehaviour, IPointerClickHandler
{
    Animator animator;
    public GameObject scaleBtn;

    public void OnPointerClick(PointerEventData eventData)
    {
        animator.SetTrigger("ScaleReset");
        StatesVariables.isResetPushed = true;

        Debug.Log($"isResetPushed: {StatesVariables.isResetPushed}");
    }

    void Start()
    {
        animator = scaleBtn.GetComponent<Animator>();
    }
}
