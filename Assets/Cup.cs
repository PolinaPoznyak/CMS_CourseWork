using UnityEngine;
using UnityEngine.EventSystems;

public class Cup : MonoBehaviour, IPointerClickHandler
{
    Animator animator;
    public GameObject cup;

    public void OnPointerClick(PointerEventData eventData)
    {
        animator.SetTrigger("CupFromTableOnScale");
        StatesVariables.isCupOnScale = true;
    }

    void Start()
    {
        animator = cup.GetComponent<Animator>();
    }
}
