using UnityEngine;

public class MonometrArrow : MonoBehaviour
{
    public Transform projector = null;

    private Quaternion start;
    private Quaternion end;
    float speed = 0.001f;
    float offset = 0;

    private void Start()
    {
        start = Quaternion.Euler(-35f, -90f, -90f);
        end = Quaternion.Euler(-110f, -90f, -90f);
    }

    public void FixedUpdate()
    {
        if (StatesVariables.is200Watts == true)
        {
            offset += speed;
            projector.rotation = Quaternion.Lerp(start, end, offset);
        }
    }
}
