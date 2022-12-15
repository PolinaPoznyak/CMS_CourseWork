using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{

    [SerializeField]
    private TMP_Text message;               //ОБЪЕКТНАЯ ПЕРЕМЕННАЯ ТИПА TEXT   
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
        message.text = "Парогенератор - основное устройство установки, в котором измеряются температура и давление пара в состояния насыщения";
    }
        
    public void InfoTempMetr()
    {
        message.text = "Kонтроль за температурными показателями осуществляется с помощью измерителя температуры";
    }   
    public void InfoAdjValve()
    {
        message.text = "Регулировочный вентиль";
    }   
    
    public void InfoSwitch()
    {
        message.text = "Переключатель позволяет менять режим с t<sub>н</sub> на t<sub>в</sub> и наоборот";
    }
            
    public void InfoMonometr()
    {
        message.text = "Манометр";
    }   
    
    public void InfoMyLATR()
    {
        message.text = "Лабораторные автотрансформаторы (ЛАTР) — это автотрансформаторы с возможностью плавного и точного регулирования выходного напряжения.";
    }
                
    public void InfoAmperVolt()
    {
        message.text = "Амперметр с вольтметром обеспечивают контроль мощности TэНа, регулируемого с помощью ЛАTРа";
    }   
    
    public void InfoBarometr()
    {
        message.text = "Данный компонент позволяет определить барометрическое давление";
    }

    public void OnExit()
    {  //  МЕТОД, ВЫЗЫВАЕМЫЙ ПОЛЬЗОВАТЕЛЕМ ПРИ УХОДЕ КУРСОРА МЫШИ С КНОПКИ 
        message.text = "Симулятор предназначен для проведения лабораторного практикума в виртуальном режиме с установкой, представленной на экране компьютера";
    }

    #region Изменение цвета измерителя температуры

    public void ChangColTempMetr()          //измеритель температуры
    {
        tempMetr.GetComponent<Renderer>().material.color = new Color(1, 0, 0);
    }

    public void ChangCol1TempMetr()
    {
        tempMetr.GetComponent<Renderer>().material.color = new Color(1, 1, 1);
    }

    #endregion

    #region Изменение цвета парогенератора

    public void ChangColSteamGen()          //парогенератор
    {
        steamGen.GetComponentInChildren<Renderer>().material.color = new Color(1, 0, 0);
    }

    public void ChangCol1SteamGen()
    {
        steamGen.GetComponentInChildren<Renderer>().material.color = new Color(1, 1, 1);
    }

    #endregion

    #region Изменение цвета регулировочного вентиля

    public void ChangColAdjValve()          //регулировочный вентиль
    {
        adjValve.GetComponentInChildren<Renderer>().material.color = new Color(1, 0, 0);
    }

    public void ChangCol1AdjValve()
    {
        adjValve.GetComponentInChildren<Renderer>().material.color = new Color(1, 1, 1);
    }

    #endregion

    #region Изменение цвета переключателя

    public void ChangColSwitch()          //переключатель
    {
        mySwitch.GetComponentInChildren<Renderer>().material.color = new Color(1, 0, 0);
    }

    public void ChangCol1Switch()
    {
        mySwitch.GetComponentInChildren<Renderer>().material.color = new Color(1, 1, 1);
    }

    #endregion

    #region Изменение цвета монометра

    public void ChangColMonometr()          //монометр
    {
        monometr.GetComponentInChildren<Renderer>().material.color = new Color(1, 0, 0);
    }

    public void ChangCol1Monometr()
    {
        monometr.GetComponentInChildren<Renderer>().material.color = new Color(1, 1, 1);
    }

    #endregion

    #region Изменение цвета ЛАТРа

    public void ChangColLATR()          //ЛАТР
    {
        latr.GetComponentInChildren<Renderer>().material.color = new Color(1, 0, 0);
    }

    public void ChangCol1LATR()
    {
        latr.GetComponentInChildren<Renderer>().material.color = new Color(1, 1, 1);
    }

    #endregion

    #region Изменение цвета амперметра

    public void ChangColAmpermetr()          //амперметр
    {
        ampermetr.GetComponentInChildren<Renderer>().material.color = new Color(1, 0, 0);
    }

    public void ChangCol1Ampermetr()
    {
        ampermetr.GetComponentInChildren<Renderer>().material.color = new Color(1, 1, 1);
    }

    #endregion

    #region Изменение цвета вольтметра

    public void ChangColVoltmetr()          //вольтметр
    {
        voltmetr.GetComponentInChildren<Renderer>().material.color = new Color(1, 0, 0);
    }

    public void ChangCol1Voltmetr()
    {
        voltmetr.GetComponentInChildren<Renderer>().material.color = new Color(1, 1, 1);
    }

    #endregion
}
