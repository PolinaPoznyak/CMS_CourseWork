using UnityEngine;
using UnityEngine.EventSystems;

public class CupOnStand : MonoBehaviour, IPointerClickHandler
{
    Animator animator;
    public GameObject cup;

    public void OnPointerClick(PointerEventData eventData)
    {
        animator.SetTrigger("CupFromScaleOnStand");
        StatesVariables.isCupOnStand = true;
    }

    void Start()
    {
        animator = cup.GetComponent<Animator>();
    }
}
