using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField]
    float scrollSpeed = 8f;

    [SerializeField]
    private float x;
    private float y;

    [SerializeField]
    Transform targetPos;
    int sensivity = 1;
    public float sensitivity = 1;

    private float Y;

    public float currentPosX;
    public float currentPosY;
    public float currentPosZ;

    //private float StartTime = 0;
    //private float EndTime = 0.1f;

    //  ÔÓÍÊÖÈß ÎÃÐÀÍÈ×ÅÍÈß ÏÐÅÄÅËÎÂ ÄÂÈÆÅÍÈß ÊÀÌÅÐÛ 
    bool ControlDistance(float newPos, int minValue, int maxValue, float centerPos)
    {
        if ((newPos - centerPos > minValue) && (newPos - centerPos < maxValue))
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    // ÂÐÀÙÅÍÈÅ ÂÎÊÐÓÃ ÖÅÍÒÐÀËÜÍÎÉ ÒÎ×ÊÈ ÓÑÒÀÍÎÂÊÈ Ñ ÇÀÆÀÒÎÉ ÏÐÀÂÎÉ ÊËÀÂÈØÅÉ ÌÛØÈ 
    void Update()
    {
        

    }

    #region Ïðèáëèæåíèå êàìåðû ê îáúåêòó

    Vector3 startPosition;
    Vector3 needPosition;
    bool move = false;
    float speed = 0.01f;
    float offset = 0;
    Quaternion startRotation;
    Quaternion needRotaton;

    void Start()
    {
        startPosition = transform.position;
        startRotation = transform.rotation;
        //// ÅÑËÈ, ÍÀÏÐÈÌÅÐ, ÏÎÇÈÖÈß È ÏÎÂÎÐÎÒ ÏÓÑÒÎÃÎ ÎÁÚÅÊÒÀ ÇÀÄÀÍÛ ÇÍÀ×ÅÍÈßÌÈ
        //needPosition = new Vector3(5.45f, 8, -22.6f);
        //needRotaton = new Quaternion(0.7f, 0, 0, 0.7f);
    }

    public void FixedUpdate()
    {
        if (Input.GetMouseButton(1))
        {
            transform.RotateAround(targetPos.position, Vector3.up, Input.GetAxis("Mouse X") * sensivity);
            Y += Input.GetAxis("Mouse Y") * sensitivity * 1.2f;
            Y = Mathf.Clamp(Y, -50, 15); 
            transform.localEulerAngles = new Vector3(-Y, transform.localEulerAngles.y, 0); 
        }

        // ÄÂÈÆÅÍÈß ÊÀÌÅÐÛ Â ÑÒÎÐÎÍÛ ÊËÀÂÈØÀÌÈ 
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        if (x != 0)
        {
            Vector3 newpos = transform.position + (transform.TransformDirection(new Vector3(x, 0, 0)) + Vector3.up * y) * sensivity;
            Vector3 pos = targetPos.position;
            currentPosX = newpos.x;
            currentPosY = newpos.y;
            currentPosZ = newpos.z;
            if ((ControlDistance(newpos.x, -33, 35, pos.x)) && (ControlDistance(newpos.z, -33, 35, pos.z)))
                transform.position = newpos;
        }
        if (y != 0)
        {
            Vector3 newpos = transform.position + (transform.TransformDirection(new Vector3(x, 0, 0)) + Vector3.up * y) * sensivity;
            Vector3 pos = targetPos.position;
            if (ControlDistance(newpos.y, 3, 30, pos.y))
                transform.position = newpos;
        }

        // ÏÐÈÁËÈÆÅÍÈÅ È ÓÄÀËÅÍÈÅ ÊÀÌÅÐÛ ÎÒ ÓÑÒÀÍÎÂÊÈ ÏÐÎÊÐÓÒÊÎÉ ÊÎËÅÑÀ ÌÛØÈ 
        if (Input.GetAxis("Mouse ScrollWheel") != 0)
        {
            Vector3 newpos = transform.position + transform.TransformDirection(Vector3.forward * Input.GetAxis("Mouse ScrollWheel") * scrollSpeed);
            Vector3 pos = targetPos.position;
            if ((ControlDistance(newpos.x, -35, 39, pos.x)) && (ControlDistance(newpos.z, -32, 37, pos.z)))
                transform.position = newpos;
        }

        if (move)
        {
            offset += speed;
            transform.position = Vector3.Lerp(startPosition, needPosition, offset);
            transform.rotation = Quaternion.Slerp(startRotation, needRotaton, offset);
            if (offset >= 1)
            {
                move = false;
                offset = 0;
            }
        }
    }

    public void ZoomTempMetr()
    {
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;
            needPosition = new Vector3(301.9335f, 22.04499f, 177.5377f);
            needRotaton = Quaternion.Euler(14.095f, -0.172f, 0f);
        }
    }

    public void ZoomSteamGen()
    {
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;
            needPosition = new Vector3(314.6125f, 24.66524f, 166.7787f);
            needRotaton = Quaternion.Euler(11.516f, -14.267f, 0f);
        }
    }

    public void ZoomAdjValve()
    {
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;
            needPosition = new Vector3(310.4354f, 30.9948f, 175.3742f);
            needRotaton = Quaternion.Euler(11.688f, 32.487f, 0f);
        }
    }

    public void ZoomMySwitch()
    {
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;
            needPosition = new Vector3(302.7884f, 23.74368f, 178.26f);
            needRotaton = Quaternion.Euler(4.813f, 25.611f, 0f);
        }
    }

    public void ZoomMonometr()
    {
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;
            needPosition = new Vector3(302.7324f, 27.02348f, 180.4728f);
            needRotaton = Quaternion.Euler(6.36f, 0.516f, 0f);
        }
    }

    public void ZoomLATR()
    {
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;
            needPosition = new Vector3(295.4901f, 16.97416f, 172.292f);
            needRotaton = Quaternion.Euler(14.095f, -0.172f, 0f);
        }
    }

    public void ZoomAmperVolt()
    {
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;
            needPosition = new Vector3(295.4417f, 21.11305f, 180.2598f);
            needRotaton = Quaternion.Euler(9.11f, 0.344f, 0f);
        }
    }

    public void ZoomBarometr()
    {
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;
            needPosition = new Vector3(281.6282f, 24.69f, 182.1962f);
            needRotaton = Quaternion.Euler(0f, 0.756f, 0f);
        }
    }

    public void ZoomScale()
    {
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;
            //needPosition = new Vector3(300.43f, 20f, 168f);
            //needRotaton = Quaternion.Euler(40f, 0f, 0f);
            needPosition = new Vector3(300.66f, 17f, 168.4274f);
            needRotaton = Quaternion.Euler(26.742f, 0f, 0f);
            StatesVariables.isPart2Started = true;
        }
    }
    #endregion
}