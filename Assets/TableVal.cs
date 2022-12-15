using UnityEngine;
using TMPro;
using System;

public class TableVal : MonoBehaviour
{
    [SerializeField]
    private TMP_Text message;

    [SerializeField]
    TMP_InputField textInput;

    [SerializeField]
    TMP_Text ve;

    #region Переменные pи в кгс/см2
    [SerializeField]
    TMP_Text p1;
    [SerializeField]
    TMP_Text p2;
    [SerializeField]
    TMP_Text p3;    
    [SerializeField]
    TMP_Text p4;
    [SerializeField]
    TMP_Text p5;
    [SerializeField]
    TMP_Text p6;
    #endregion

    #region Переменные pи в МПа
    [SerializeField]
    TMP_Text _p1;
    [SerializeField]
    TMP_Text _p2;
    [SerializeField]
    TMP_Text _p3;    
    [SerializeField]
    TMP_Text _p4;
    [SerializeField]
    TMP_Text _p5;
    [SerializeField]
    TMP_Text _p6;
    #endregion

    #region Переменные pб в МПа
    [SerializeField]
    TMP_Text pb1;
    [SerializeField]
    TMP_Text pb2;
    [SerializeField]
    TMP_Text pb3;
    [SerializeField]
    TMP_Text pb4;
    [SerializeField]
    TMP_Text pb5;
    [SerializeField]
    TMP_Text pb6;
    #endregion   
    
    #region Переменные pa в МПа
    [SerializeField]
    TMP_Text pn1;
    [SerializeField]
    TMP_Text pn2;
    [SerializeField]
    TMP_Text pn3;
    [SerializeField]
    TMP_Text pn4;
    [SerializeField]
    TMP_Text pn5;
    [SerializeField]
    TMP_Text pn6;
    #endregion

    #region Переменные t в °C 
    [SerializeField]
    TMP_Text t1;
    [SerializeField]
    TMP_Text t2;
    [SerializeField]
    TMP_Text t3;
    [SerializeField]
    TMP_Text t4;
    [SerializeField]
    TMP_Text t5;
    [SerializeField]
    TMP_Text t6;
    #endregion

    #region Переменные t^T в °C 
    [SerializeField]
    TMP_Text t1_T;
    [SerializeField]
    TMP_Text t2_T;
    [SerializeField]
    TMP_Text t3_T;
    [SerializeField]
    TMP_Text t4_T;
    [SerializeField]
    TMP_Text t5_T;
    [SerializeField]
    TMP_Text t6_T;
    #endregion

    #region Table 2

    [SerializeField]
    TMP_Text mk;
    [SerializeField]
    TMP_Text m;
    [SerializeField]
    TMP_Text mv;
    [SerializeField]
    TMP_Text m_after;
    [SerializeField]
    TMP_Text m_vaper;
    [SerializeField]
    TMP_Text t_before;
    [SerializeField]
    TMP_Text t_after;
    [SerializeField]
    TMP_Text h1;
    [SerializeField]
    TMP_Text h2;
    [SerializeField]
    TMP_Text h;
    [SerializeField]
    TMP_Text x;

    #endregion

    private void Start()
    {
        if (p1.text == "-")                                        //0
        {
            p1.text = "0";
            _p1.text = (float.Parse(p1.text) * 0.098).ToString();
        }
        if (p2.text == "-")                                        //5
        {
            p2.text = "0,5";
            _p2.text = (float.Parse(p2.text) * 0.098).ToString();
        }
        if (p3.text == "-")                                        //10
        {
            p3.text = "1";
            _p3.text = (float.Parse(p3.text) * 0.098).ToString();
        }
        if (p4.text == "-")                                        //15
        {
            p4.text = "1,5";
            _p4.text = (float.Parse(p4.text) * 0.098).ToString();
        }
        if (p5.text == "-")                                        //20
        {
            p5.text = "2";
            _p5.text = (float.Parse(p5.text) * 0.098).ToString();
        }
        if (p6.text == "-")                                        //25
        {
            p6.text = "2,5";
            _p6.text = (float.Parse(p6.text) * 0.098).ToString();
        }
    }

    //1 кгс см2 = 0.098 мегапаскаля

    //функция для кнопки «Записать»
    public void WriteValue()
    {
        if (p1.text == "-")                                             //5
        {
            p1.text = textInput.text.ToString();
            _p1.text = (int.Parse(p1.text) * 0.098).ToString();
            message.text = "Показания, снятые с манометра, автоматически переводятся в МПа. \nЗафиксируйте показания температуры для соответствующих давлений";
        }
        else if (p2.text == "-")                                        //5
        {
            p2.text = textInput.text.ToString();
            _p2.text = (int.Parse(p2.text) * 0.098).ToString();
        }
        else if (p3.text == "-")                                        //10
        {
            p3.text = textInput.text.ToString();
            _p3.text = (int.Parse(p3.text) * 0.098).ToString();
        }
        else if (p4.text == "-")                                        //15
        {
            p4.text = textInput.text.ToString();
            _p4.text = (int.Parse(p4.text) * 0.098).ToString();
        }
        else if (p5.text == "-")                                        //20
        {
            p5.text = textInput.text.ToString();
            _p5.text = (int.Parse(p5.text) * 0.098).ToString();
        }
        else if (p6.text == "-")                                        //25
        {
            p6.text = textInput.text.ToString();
            _p6.text = (int.Parse(p6.text) * 0.098).ToString();
        }
        else if (t1.text == "-")
        {
            t1.text = textInput.text.ToString();
            StatesVariables.pressure0 = true;
            Debug.Log($"pressure0: {StatesVariables.pressure0}");
        }
        else if (t2.text == "-")
        {
            t2.text = textInput.text.ToString();
            StatesVariables.pressure5 = true;
            Debug.Log($"pressure5: {StatesVariables.pressure5}");
        }
        else if (t3.text == "-")
        {
            t3.text = textInput.text.ToString();
            StatesVariables.pressure10 = true;
            Debug.Log($"pressure10: {StatesVariables.pressure10}");
        }
        else if (t4.text == "-")
        {
            t4.text = textInput.text.ToString();
            StatesVariables.pressure15 = true;
            Debug.Log($"pressure15: {StatesVariables.pressure15}");
        }
        else if (t5.text == "-")
        {
            t5.text = textInput.text.ToString();
            StatesVariables.pressure20 = true;
            Debug.Log($"pressure20: {StatesVariables.pressure20}");
        }
        else if (t6.text == "-")
        {
            t6.text = textInput.text.ToString();
            StatesVariables.pressure25 = true;
            Debug.Log($"pressure25: {StatesVariables.pressure25}");
            StatesVariables.isTempValWritten = true;
        }
        else if (pb1.text == "-")
        {
            string b = textInput.text.ToString();
            pb1.text = (Math.Round(float.Parse(b) * 0.001, 4)).ToString();
            pb2.text = (Math.Round(float.Parse(b) * 0.001, 4)).ToString();
            pb3.text = (Math.Round(float.Parse(b) * 0.001, 4)).ToString();
            pb4.text = (Math.Round(float.Parse(b) * 0.001, 4)).ToString();
            pb5.text = (Math.Round(float.Parse(b) * 0.001, 4)).ToString();
            pb6.text = (Math.Round(float.Parse(b) * 0.001, 4)).ToString();
            pn1.text = (float.Parse(_p1.text) + float.Parse(pb1.text)).ToString();
            pn2.text = (float.Parse(_p2.text) + float.Parse(pb2.text)).ToString();
            pn3.text = (float.Parse(_p3.text) + float.Parse(pb3.text)).ToString();
            pn4.text = (float.Parse(_p4.text) + float.Parse(pb4.text)).ToString();
            pn5.text = (float.Parse(_p5.text) + float.Parse(pb5.text)).ToString();
            pn6.text = (float.Parse(_p6.text) + float.Parse(pb6.text)).ToString();
            StatesVariables.isPressureMeasured = true;
            //t1_T.text = "99,64";
            //t2_T.text = "111,38";
            //t3_T.text = "118,62";
            //t4_T.text = "126,09";
            //t5_T.text = "132,29";
            //t6_T.text = "137.86";
        }
        else if (t1_T.text == "-")                                          //заносим значения теоритической температуры из Таблицы П3
        {
            t1_T.text = textInput.text.ToString();
        }
        else if (t2_T.text == "-")
        {
            t2_T.text = textInput.text.ToString();
        }
        else if (t3_T.text == "-")
        {
            t3_T.text = textInput.text.ToString();
        }
        else if (t4_T.text == "-")
        {
            t4_T.text = textInput.text.ToString();
        }
        else if (t5_T.text == "-")
        {
            t5_T.text = textInput.text.ToString();
        }
        else if (t6_T.text == "-")
        {
            t6_T.text = textInput.text.ToString();
        }
        else if (mk.text == "-")                                                                        //2 часть лабораторного опыта
        {
            mk.text = textInput.text.ToString();
            StatesVariables.isEmptyCupMeasured = true;
        }
        else if (m.text == "-") 
        {
            m.text = textInput.text.ToString();
            mv.text = (float.Parse(m.text) - float.Parse(mk.text)).ToString();
            StatesVariables.isWaterCupMeasured = true;
        }
        else if (t_before.text == "-") 
        {
            t_before.text = textInput.text.ToString();
            StatesVariables.isWrittenTv1 = true;
        }
        else if (t_after.text == "-")
        {
            t_after.text = textInput.text.ToString();
            StatesVariables.isWrittenTv2 = true;
            //h.text = (Math.Round((float.Parse(mv.text) / 0.8 * float.Parse(m_vaper.text) * (float.Parse(t_after.text) - float.Parse(t_before.text)) + float.Parse(t_after.text)) * 4.19), 1).ToString();
        }
        else if (m_after.text == "-")
        {
            m_after.text = textInput.text.ToString();
            m_vaper.text = (Math.Round(float.Parse(m_after.text) - float.Parse(m.text), 2)).ToString();
            StatesVariables.isWrittenM = true;
        }
        else if (h1.text == "-")
        {
            h1.text = textInput.text.ToString();
            StatesVariables.isWrittenH1 = true;
        }
        else if (h2.text == "-")
        {
            h2.text = textInput.text.ToString();
            StatesVariables.isWrittenH2 = true;
        }
        else if (h.text == "-")
        {
            h.text = textInput.text.ToString();
            StatesVariables.isWrittenH = true;
        }
        else if (x.text == "-")
        {
            x.text = textInput.text.ToString();
            StatesVariables.isWrittenX = true;
        }
        textInput.text = "";
    }

    //функция для кнопки «Очистить»
    public void Clean()
    {
        //p1.text = "-";
        //p2.text = "-";
        //p3.text = "-";
        //p4.text = "-";
        //p5.text = "-";
        //p6.text = "-";

        _p1.text = "-";
        _p2.text = "-";
        _p3.text = "-";
        _p4.text = "-";
        _p5.text = "-";
        _p6.text = "-";       
        
        pb1.text = "-";
        pb2.text = "-";
        pb3.text = "-";
        pb4.text = "-";
        pb5.text = "-";
        pb6.text = "-";

        pn1.text = "-";
        pn2.text = "-";
        pn3.text = "-";
        pn4.text = "-";
        pn5.text = "-";
        pn6.text = "-";

        t1.text = "-";
        t2.text = "-";
        t3.text = "-";
        t4.text = "-";
        t5.text = "-";
        t6.text = "-";

        t1_T.text = "-";
        t2_T.text = "-";
        t3_T.text = "-";
        t4_T.text = "-";
        t5_T.text = "-";
        t6_T.text = "-";
        
        mk.text = "-";
        m.text = "-";
        mv.text = "-";
        m_after.text = "-";
        m_vaper.text = "-";
        t_before.text = "-";
        t_after.text = "-";
        h1.text = "-";
        h2.text = "-";
        h.text = "-";
        x.text = "-";
    }
}
