using UnityEngine;
using UnityEngine.EventSystems;

public class CupOnScale : MonoBehaviour, IPointerClickHandler
{
    Animator animator;
    public GameObject cup;

    public void OnPointerClick(PointerEventData eventData)
    {
        animator.SetTrigger("CupFromStateToStand");
        StatesVariables.isCupOnScaleAgain = true;
    }

    void Start()
    {
        animator = cup.GetComponent<Animator>();
    }
}
