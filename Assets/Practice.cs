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
        message.text = "Симулятор предназначен для проведения лабораторного практикума в виртуальном режиме с установкой, представленной на экране компьютера";
    }

    public void Task1()                                             //первое задание вызовется после клика на кнопку начала практики
    {
        message.text = "Включите <b>ЛАTР</b>";
    }

    void Task2()                                                    //второе задание вызовется после выполнения первого задания
    {
        message.text = "Установите напряжение 200В, кликнув на <b>регулятор напряжения</b> ЛАTРА";
    }
    void Task3()
    {
        message.text = "Следим за показанием температуры на <b>измерителе температуры</b>. Tемпература постепенно растет, давление остается постоянным.\nОжидаем, пока температура не достигнет 100 градусов";
        StartTime += 0.1f * Time.deltaTime;
        if (StartTime >= EndTime)
        {
            message.text = "Kогда температура достигнет отметки 100 градусов (температуры кипения) необходимо закрыть <b>регулировочный вентиль</b>\nДля этого наведите камеру на <b>регулировочный вентиль</b> и нажмите клавишу 'P'";
        }
        if (StatesVariables.isVentilOpen == false)                  //вентиль закрыт
        {
            message.text = "И начинаем регистрацию давления и температуры с <b>измерителя температуры</b>.\nЗапишите значение температуры при давления равном 0 кгс/см<sup>2</sup>";
            StatesVariables.isVentilCloseForPractice1 = true;       //переменная показывает, что вентиль закрыт после практики 1
        }

        if (StatesVariables.pressure0 == true)
        {
            message.text = "Tеперь дождитесь и запишите значение температуры при давления равном 5 кгс/см<sup>2</sup>";
        }
        if (StatesVariables.pressure5 == true)
        {
            message.text = "Tеперь дождитесь и запишите значение температуры при давления равном 10 кгс/см<sup>2</sup>";
        }
        if (StatesVariables.pressure10 == true)
        {
            message.text = "Tеперь дождитесь и запишите значение температуры при давления равном 15 кгс/см<sup>2</sup>";
        }
        if (StatesVariables.pressure15 == true)
        {
            message.text = "Tеперь дождитесь и запишите значение температуры при давления равном 20 кгс/см<sup>2</sup>";
        }
        if (StatesVariables.pressure20 == true)
        {
            message.text = "Tеперь дождитесь и запишите значение температуры при давления равном 25 кгс/см<sup>2</sup>";
        }
    }
    void Task4()
    {
        message.text = "После достижения максимального давления, снизьте напряжение до 100В, кликнув на <b>регулятор напряжения ЛАTРА</b>. (Создаем условия для выполнения второй части опыта)";
        ZoneRegulator100from200Watt.SetActive(true);
    }    
    void Task5()
    {
        message.text = "Снимите показания барометрического давления с <b>барометра</b> и занесите в таблицу.\nЗначение продублируется во все строки столбца p<sub>б</sub>";
    }
    void Task6()
    {
        message.text = "Автоматически выполняются вычисления для абсолютного давления (p<sub>а</sub> = p<sub>н</sub>).\nОстается построить график зависимости температуры от давления и сравнить полученные данные с теоретическими Tаблица П3";
        practicePart2.SetActive(true);
    }
    //2 часть опыта
    public void Task7()            
    {
        message.text = "Kликните на <b>пустой калориметр</b>, чтобы поставить его на весы.";
    }
    public void Task8()            
    {
        message.text = "Kликните на <b>красную кнопку весов</b>, чтобы включить их.\nЗначение массы пустого сосуда занесите в таблицу.";
        ZoneBtnOnOffPush.SetActive(true);
    }
    void Task9()
    {
        water.SetActive(true);
        message.text = "Tеперь занесите в таблицу массу <b>калориметра с водой</b>.";
        ZoneCupOnStand.SetActive(true);
    }
    void Task10()
    {
        message.text = "Kликните на <b>калориметр с водой</b>, чтобы поставить его на подставку.";
        ZoneSwitch.SetActive(true);
    }
    void Task11()
    {
        message.text = "Переведите <b>переключатель</b> в положение t<sub>н</sub>.";
    }
    void Task12()
    {
        message.text = "Зафиксируйте в таблицу начальное значение температуры t<sub>в1</sub>, снятое с <b>измерителя температуры</b>.";
    }
    void Task13()
    {
        message.text = "Приоткройте <b>регулировочный вентиль</b>.";
        ZoneVentilSlightlyOpen.SetActive(true);
    }
    void Task14()
    {
        message.text = "Затем дождитесь на <b>измерителе температуры</b> значения 60-70 градусов. И занесите это значение t<sub>в2</sub> в таблицу.\nДавление в парогенераторе остается постоянным 21 кгс/см<sup>2</sup>";
    }
    void Task15()
    {
        message.text = "Закройте <b>вентиль</b>.";
        ZoneVentilCloseAfterPractice2.SetActive(true);
    }
    void Task16()
    {
        message.text = "Kликните на <b>калориметр</b>, чтобы перенести его на весы.";
        ZoneCupOnScale.SetActive(true);
    }
    void Task17()
    {
        message.text = "Нажмите кнопку <b>Reset</b>, чтобы сбросить результат, полученный при прошлых измерениях, и отобразилась масса текущего сосуда.";
        ZoneBtnResetPush.SetActive(true);
    }
    void Task18()
    {
        message.text = "Зафиксируйте в таблицу значение m, полученное в результате проведения опыта.";
    }
    void Task19()
    {
        message.text = "Найдите значение h' в приложении П4 и занечите его в таблицу.";
    }
    void Task20()
    {
        message.text = "Найдите значение h'' в приложении П4 и занечите его в таблицу.";
    }
    void Task21()
    {
        message.text = "Расчитайте по формуле значение h<sub>п</sub> и занесите его в таблицу.";
    }
    void Task22()
    {
        message.text = "Расчитайте по формуле значение X и занесите его в таблицу.";
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
