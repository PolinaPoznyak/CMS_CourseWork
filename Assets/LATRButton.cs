using UnityEngine;
using UnityEngine.EventSystems;

public class LATRButton : MonoBehaviour, IPointerClickHandler
{
    Animator animator;
    public GameObject button;
    public GameObject ZoneRegulator200Watt;

    public GameObject value_pi;
    public GameObject value_tn;

    public void OnPointerClick(PointerEventData eventData)
    {
        animator.SetTrigger("Play");
        StatesVariables.isWorking = true;

        Debug.Log(StatesVariables.isWorking);

        ZoneRegulator200Watt.SetActive(true);
        value_pi.SetActive(true);
        value_tn.SetActive(true);
    }

    void Start()
    {
        animator = button.GetComponent<Animator>();
    }
}
