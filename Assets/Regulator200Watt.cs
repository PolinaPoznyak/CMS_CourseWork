using UnityEngine;
using UnityEngine.EventSystems;

public class Regulator200Watt : MonoBehaviour, IPointerClickHandler
{
    Animator animator;
    public GameObject regulator;

    public GameObject value_pi;
    public GameObject value_tn;

    public void OnPointerClick(PointerEventData eventData)
    {
        animator.SetTrigger("Set200Watts");
        StatesVariables.is200Watts = true;

        Debug.Log($"is200Watts: {StatesVariables.is200Watts}");
    }

    void Start()
    {
        animator = regulator.GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            animator.SetTrigger("Set200Watts");
        }
    }
}
