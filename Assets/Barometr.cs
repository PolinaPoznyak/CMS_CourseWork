using UnityEngine;

public class Barometr : MonoBehaviour
{
    public Transform projector = null;

    private Quaternion start;
    private Quaternion end;
    float speed = 0.1f;
    float offset = 0;
    
    private void Start()
    {
        start = Quaternion.Euler(-130f, -90f, -90f);
        //должен меняться в пределах от -140 до -185 == от 98 до 102
        end = Quaternion.Euler(Random.Range(-140, -185), -90f, -90f);
    }

    private void Update()
    {
        offset += speed;
        projector.rotation = Quaternion.Lerp(start, end, offset);
    }
}
