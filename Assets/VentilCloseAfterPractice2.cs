using UnityEngine;
using UnityEngine.EventSystems;

public class VentilCloseAfterPractice2 : MonoBehaviour, IPointerClickHandler
{
    Animator animator;
    public GameObject ventil;

    public void OnPointerClick(PointerEventData eventData)
    {
        animator.SetTrigger("Close2Ventil");
        StatesVariables.isVentilCloseAfterPractice2 = true;

        Debug.Log($"isVentilCloseAfterPractice2: {StatesVariables.isVentilCloseAfterPractice2}");
    }

    void Start()
    {
        animator = ventil.GetComponent<Animator>();
    }
}
