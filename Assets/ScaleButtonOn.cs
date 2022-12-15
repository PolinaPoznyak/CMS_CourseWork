using UnityEngine;
using UnityEngine.EventSystems;

public class ScaleButtonOn : MonoBehaviour, IPointerClickHandler
{
    Animator animator;
    public GameObject scaleBtn;
    public GameObject value_waight;

    public void OnPointerClick(PointerEventData eventData)
    {
        animator.SetTrigger("ScaleOn");
        StatesVariables.ScaleOn = true;
        value_waight.SetActive(true);

        Debug.Log($"ScaleOn: {StatesVariables.ScaleOn}");
    }

    void Start()
    {
        animator = scaleBtn.GetComponent<Animator>();
    }
}
