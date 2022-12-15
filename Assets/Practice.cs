using UnityEngine;
using TMPro;

public class Practice : MonoBehaviour
{
    [SerializeField]
    private TMP_Text message;

    public GameObject help1;
    public GameObject practicePart2;
    public GameObject water;
    public GameObject ZoneRegulator100from200Watt;
    public GameObject ZoneBtnOnOffPush;
    public GameObject ZoneCupOnStand;
    public GameObject ZoneSwitch;
    public GameObject ZoneVentilSlightlyOpen;
    public GameObject ZoneVentilCloseAfterPractice2;
    public GameObject ZoneCupOnScale;
    public GameObject ZoneBtnResetPush;

    public float StartTime;
    public float EndTime;

    public void OnExit()
    {
        message.text = "��������� ������������ ��� ���������� ������������� ���������� � ����������� ������ � ����������, �������������� �� ������ ����������";
    }

    public void Task1()                                             //������ ������� ��������� ����� ����� �� ������ ������ ��������
    {
        message.text = "�������� <b>��T�</b>";
    }

    void Task2()                                                    //������ ������� ��������� ����� ���������� ������� �������
    {
        message.text = "���������� ���������� 200�, ������� �� <b>��������� ����������</b> ��T��";
    }
    void Task3()
    {
        message.text = "������ �� ���������� ����������� �� <b>���������� �����������</b>. T���������� ���������� ������, �������� �������� ����������.\n�������, ���� ����������� �� ��������� 100 ��������";
        StartTime += 0.1f * Time.deltaTime;
        if (StartTime >= EndTime)
        {
            message.text = "K���� ����������� ��������� ������� 100 �������� (����������� �������) ���������� ������� <b>�������������� �������</b>\n��� ����� �������� ������ �� <b>�������������� �������</b> � ������� ������� 'P'";
        }
        if (StatesVariables.isVentilOpen == false)                  //������� ������
        {
            message.text = "� �������� ����������� �������� � ����������� � <b>���������� �����������</b>.\n�������� �������� ����������� ��� �������� ������ 0 ���/��<sup>2</sup>";
            StatesVariables.isVentilCloseForPractice1 = true;       //���������� ����������, ��� ������� ������ ����� �������� 1
        }

        if (StatesVariables.pressure0 == true)
        {
            message.text = "T����� ��������� � �������� �������� ����������� ��� �������� ������ 5 ���/��<sup>2</sup>";
        }
        if (StatesVariables.pressure5 == true)
        {
            message.text = "T����� ��������� � �������� �������� ����������� ��� �������� ������ 10 ���/��<sup>2</sup>";
        }
        if (StatesVariables.pressure10 == true)
        {
            message.text = "T����� ��������� � �������� �������� ����������� ��� �������� ������ 15 ���/��<sup>2</sup>";
        }
        if (StatesVariables.pressure15 == true)
        {
            message.text = "T����� ��������� � �������� �������� ����������� ��� �������� ������ 20 ���/��<sup>2</sup>";
        }
        if (StatesVariables.pressure20 == true)
        {
            message.text = "T����� ��������� � �������� �������� ����������� ��� �������� ������ 25 ���/��<sup>2</sup>";
        }
    }
    void Task4()
    {
        message.text = "����� ���������� ������������� ��������, ������� ���������� �� 100�, ������� �� <b>��������� ���������� ��T��</b>. (������� ������� ��� ���������� ������ ����� �����)";
        ZoneRegulator100from200Watt.SetActive(true);
    }    
    void Task5()
    {
        message.text = "������� ��������� ���������������� �������� � <b>���������</b> � �������� � �������.\n�������� �������������� �� ��� ������ ������� p<sub>�</sub>";
    }
    void Task6()
    {
        message.text = "������������� ����������� ���������� ��� ����������� �������� (p<sub>�</sub> = p<sub>�</sub>).\n�������� ��������� ������ ����������� ����������� �� �������� � �������� ���������� ������ � �������������� T������ �3";
        practicePart2.SetActive(true);
    }
    //2 ����� �����
    public void Task7()            
    {
        message.text = "K������� �� <b>������ ����������</b>, ����� ��������� ��� �� ����.";
    }
    public void Task8()            
    {
        message.text = "K������� �� <b>������� ������ �����</b>, ����� �������� ��.\n�������� ����� ������� ������ �������� � �������.";
        ZoneBtnOnOffPush.SetActive(true);
    }
    void Task9()
    {
        water.SetActive(true);
        message.text = "T����� �������� � ������� ����� <b>����������� � �����</b>.";
        ZoneCupOnStand.SetActive(true);
    }
    void Task10()
    {
        message.text = "K������� �� <b>���������� � �����</b>, ����� ��������� ��� �� ���������.";
        ZoneSwitch.SetActive(true);
    }
    void Task11()
    {
        message.text = "���������� <b>�������������</b> � ��������� t<sub>�</sub>.";
    }
    void Task12()
    {
        message.text = "������������ � ������� ��������� �������� ����������� t<sub>�1</sub>, ������ � <b>���������� �����������</b>.";
    }
    void Task13()
    {
        message.text = "����������� <b>�������������� �������</b>.";
        ZoneVentilSlightlyOpen.SetActive(true);
    }
    void Task14()
    {
        message.text = "����� ��������� �� <b>���������� �����������</b> �������� 60-70 ��������. � �������� ��� �������� t<sub>�2</sub> � �������.\n�������� � �������������� �������� ���������� 21 ���/��<sup>2</sup>";
    }
    void Task15()
    {
        message.text = "�������� <b>�������</b>.";
        ZoneVentilCloseAfterPractice2.SetActive(true);
    }
    void Task16()
    {
        message.text = "K������� �� <b>����������</b>, ����� ��������� ��� �� ����.";
        ZoneCupOnScale.SetActive(true);
    }
    void Task17()
    {
        message.text = "������� ������ <b>Reset</b>, ����� �������� ���������, ���������� ��� ������� ����������, � ������������ ����� �������� ������.";
        ZoneBtnResetPush.SetActive(true);
    }
    void Task18()
    {
        message.text = "������������ � ������� �������� m, ���������� � ���������� ���������� �����.";
    }
    void Task19()
    {
        message.text = "������� �������� h' � ���������� �4 � �������� ��� � �������.";
    }
    void Task20()
    {
        message.text = "������� �������� h'' � ���������� �4 � �������� ��� � �������.";
    }
    void Task21()
    {
        message.text = "���������� �� ������� �������� h<sub>�</sub> � �������� ��� � �������.";
    }
    void Task22()
    {
        message.text = "���������� �� ������� �������� X � �������� ��� � �������.";
    }

    void Update()
    {
        if (StatesVariables.isWorking == true)
        {
            Task2();
        }
        if (StatesVariables.is200Watts == true)
        {
            Task3();
        }
        if (StatesVariables.isTempValWritten == true)
        {
            Task4();
        }
        if (StatesVariables.is100from200Watts == true)
        {
            Task5();
        }
        if (StatesVariables.isPressureMeasured == true)
        {
            Task6();
        }
        if (StatesVariables.isPart2Started == true)
        {
            Task7();
        }
        if (StatesVariables.isCupOnScale == true)
        {
            Task8();
        }
        if (StatesVariables.isEmptyCupMeasured == true)
        {
            Task9();
        }
        if (StatesVariables.isWaterCupMeasured == true)
        {
            Task10();
        }
        if (StatesVariables.isCupOnStand == true)
        {
            Task11();
        }
        if (StatesVariables.isSwichedOn == true)
        {
            Task12();
        }
        if (StatesVariables.isWrittenTv1 == true)
        {
            Task13();
        }
        if (StatesVariables.isVentilSlightlyOpen == true)
        {
            Task14();
        }
        if (StatesVariables.isWrittenTv2 == true)
        {
            Task15();
        }
        if (StatesVariables.isVentilCloseAfterPractice2 == true)
        {
            Task16();
        }
        if (StatesVariables.isCupOnScaleAgain == true)
        {
            Task17();
        }
        if (StatesVariables.isResetPushed == true)
        {
            Task18();
        }
        if (StatesVariables.isWrittenM == true)
        {
            Task19();
        }
        if (StatesVariables.isWrittenH1 == true)
        {
            Task20();
        }
        if (StatesVariables.isWrittenH2 == true)
        {
            Task21();
        }
        if (StatesVariables.isWrittenH == true)
        {
            Task22();
        }
    }
}
