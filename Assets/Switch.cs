using UnityEngine;
using UnityEngine.EventSystems;

public class Switch : MonoBehaviour, IPointerClickHandler
{
    Animator animator;
    public GameObject mySwitch;

    public void OnPointerClick(PointerEventData eventData)
    {
        animator.SetTrigger("SwitchTotv");
        StatesVariables.isSwichedOn = true;
    }

    void Start()
    {
        animator = mySwitch.GetComponent<Animator>();
    }
}
