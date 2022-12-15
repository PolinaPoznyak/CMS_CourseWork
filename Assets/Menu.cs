using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{

    [SerializeField]
    private TMP_Text message;               //��������� ���������� ���� TEXT   
    public GameObject tempMetr;
    public GameObject steamGen;
    public GameObject adjValve;
    public GameObject mySwitch;
    public GameObject monometr;
    public GameObject latr;
    public GameObject ampermetr;
    public GameObject voltmetr;

    // public Material cpu;

    public void InfoSteamGen()
    {
        message.text = "������������� - �������� ���������� ���������, � ������� ���������� ����������� � �������� ���� � ��������� ���������";
    }
        
    public void InfoTempMetr()
    {
        message.text = "K������� �� �������������� ������������ �������������� � ������� ���������� �����������";
    }   
    public void InfoAdjValve()
    {
        message.text = "�������������� �������";
    }   
    
    public void InfoSwitch()
    {
        message.text = "������������� ��������� ������ ����� � t<sub>�</sub> �� t<sub>�</sub> � ��������";
    }
            
    public void InfoMonometr()
    {
        message.text = "��������";
    }   
    
    public void InfoMyLATR()
    {
        message.text = "������������ ������������������ (��T�) � ��� ������������������ � ������������ �������� � ������� ������������� ��������� ����������.";
    }
                
    public void InfoAmperVolt()
    {
        message.text = "��������� � ����������� ������������ �������� �������� T���, ������������� � ������� ��T��";
    }   
    
    public void InfoBarometr()
    {
        message.text = "������ ��������� ��������� ���������� ��������������� ��������";
    }

    public void OnExit()
    {  //  �����, ���������� ������������� ��� ����� ������� ���� � ������ 
        message.text = "��������� ������������ ��� ���������� ������������� ���������� � ����������� ������ � ����������, �������������� �� ������ ����������";
    }

    #region ��������� ����� ���������� �����������

    public void ChangColTempMetr()          //���������� �����������
    {
        tempMetr.GetComponent<Renderer>().material.color = new Color(1, 0, 0);
    }

    public void ChangCol1TempMetr()
    {
        tempMetr.GetComponent<Renderer>().material.color = new Color(1, 1, 1);
    }

    #endregion

    #region ��������� ����� ��������������

    public void ChangColSteamGen()          //�������������
    {
        steamGen.GetComponentInChildren<Renderer>().material.color = new Color(1, 0, 0);
    }

    public void ChangCol1SteamGen()
    {
        steamGen.GetComponentInChildren<Renderer>().material.color = new Color(1, 1, 1);
    }

    #endregion

    #region ��������� ����� ��������������� �������

    public void ChangColAdjValve()          //�������������� �������
    {
        adjValve.GetComponentInChildren<Renderer>().material.color = new Color(1, 0, 0);
    }

    public void ChangCol1AdjValve()
    {
        adjValve.GetComponentInChildren<Renderer>().material.color = new Color(1, 1, 1);
    }

    #endregion

    #region ��������� ����� �������������

    public void ChangColSwitch()          //�������������
    {
        mySwitch.GetComponentInChildren<Renderer>().material.color = new Color(1, 0, 0);
    }

    public void ChangCol1Switch()
    {
        mySwitch.GetComponentInChildren<Renderer>().material.color = new Color(1, 1, 1);
    }

    #endregion

    #region ��������� ����� ���������

    public void ChangColMonometr()          //��������
    {
        monometr.GetComponentInChildren<Renderer>().material.color = new Color(1, 0, 0);
    }

    public void ChangCol1Monometr()
    {
        monometr.GetComponentInChildren<Renderer>().material.color = new Color(1, 1, 1);
    }

    #endregion

    #region ��������� ����� �����

    public void ChangColLATR()          //����
    {
        latr.GetComponentInChildren<Renderer>().material.color = new Color(1, 0, 0);
    }

    public void ChangCol1LATR()
    {
        latr.GetComponentInChildren<Renderer>().material.color = new Color(1, 1, 1);
    }

    #endregion

    #region ��������� ����� ����������

    public void ChangColAmpermetr()          //���������
    {
        ampermetr.GetComponentInChildren<Renderer>().material.color = new Color(1, 0, 0);
    }

    public void ChangCol1Ampermetr()
    {
        ampermetr.GetComponentInChildren<Renderer>().material.color = new Color(1, 1, 1);
    }

    #endregion

    #region ��������� ����� ����������

    public void ChangColVoltmetr()          //���������
    {
        voltmetr.GetComponentInChildren<Renderer>().material.color = new Color(1, 0, 0);
    }

    public void ChangCol1Voltmetr()
    {
        voltmetr.GetComponentInChildren<Renderer>().material.color = new Color(1, 1, 1);
    }

    #endregion
}
