using UnityEngine;
using UnityEngine.EventSystems;

public class VentilSlightlyOpen : MonoBehaviour, IPointerClickHandler
{
    Animator animator;
    public GameObject ventil;

    public void OnPointerClick(PointerEventData eventData)
    {
        animator.SetTrigger("SlightlyOpenVentil");
        StatesVariables.isVentilSlightlyOpen = true;

        Debug.Log($"isVentilSlightlyOpen: {StatesVariables.isVentilSlightlyOpen}");
    }

    void Start()
    {
        animator = ventil.GetComponent<Animator>();
    }
}
