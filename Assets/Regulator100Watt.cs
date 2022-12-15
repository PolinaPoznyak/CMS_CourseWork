using UnityEngine;
using UnityEngine.EventSystems;

public class Regulator100Watt : MonoBehaviour, IPointerClickHandler
{
    Animator animator;
    public GameObject regulator;

    public void OnPointerClick(PointerEventData eventData)
    {
        animator.SetTrigger("Set100from200Watts");
        StatesVariables.is100from200Watts = true;

        Debug.Log($"is100from200Watts: {StatesVariables.is100from200Watts}");
    }

    void Start()
    {
        animator = regulator.GetComponent<Animator>();
    }
}
