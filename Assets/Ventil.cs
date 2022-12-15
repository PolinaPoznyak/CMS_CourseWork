using UnityEngine;
using UnityEngine.EventSystems;

public class Ventil : MonoBehaviour, IPointerClickHandler
{
    Animator animator;

    public void OnPointerClick(PointerEventData eventData)
    {
        switch (eventData.button)
        {
            case PointerEventData.InputButton.Left:
                animator.SetTrigger("OpenVentil");
                StatesVariables.isVentilOpen = true;

                Debug.Log($"isVentilOpen: {StatesVariables.isVentilOpen}");
                Debug.Log("OnPointerClick: LMB");
                break;
            case PointerEventData.InputButton.Right:
                animator.SetTrigger("CloseVentil");
                StatesVariables.isVentilOpen = false;

                Debug.Log($"isVentilOpen: {StatesVariables.isVentilOpen}");
                Debug.Log("OnPointerClick: RMB");
                break;
            default:
                break;
        }        
    }

    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            animator.SetTrigger("CloseVentil");
            StatesVariables.isVentilOpen = false;

            Debug.Log($"isVentilOpen: {StatesVariables.isVentilOpen}");
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            animator.SetTrigger("OpenVentil");
            StatesVariables.isVentilOpen = true;

            Debug.Log($"isVentilOpen: {StatesVariables.isVentilOpen}");
        }
    }
}
