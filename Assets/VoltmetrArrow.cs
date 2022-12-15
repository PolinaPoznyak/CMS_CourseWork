using UnityEngine;

public class VoltmetrArrow : MonoBehaviour
{
    public Transform projector = null;

    private Quaternion start;
    private Quaternion end;
    private Quaternion end2;
    float speed = 0.01f;
    float offset = 0;

    private void Start()
    {
        start = Quaternion.Euler(-35f, -90f, -90f);
        end = Quaternion.Euler(-124f, -90f, -90f);
        end2 = Quaternion.Euler(-78f, -90f, -90f);
    }

    public void FixedUpdate()
    {
        if (StatesVariables.is200Watts == true)
        {
            offset += speed;
            projector.rotation = Quaternion.Lerp(start, end, offset);
        }
        if (StatesVariables.is100from200Watts == true)
        {
            offset += speed;
            projector.rotation = Quaternion.Lerp(end, end2, offset);
        }
    }
 }