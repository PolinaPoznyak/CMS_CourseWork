using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatesVariables
{
    public static bool isWorking = false;
    public static bool is200Watts = false;
    public static bool isVentilOpen = true;                          //в начале опыта вентиль открыт
    public static bool isVentilCloseForPractice1 = false;            //закрыли вентиль
    public static bool is100from200Watts = false;
    public static bool isTempValWritten = false;
    public static bool isPressureMeasured = false;
    

    public static bool pressure0 = false;
    public static bool pressure5 = false;
    public static bool pressure10 = false;
    public static bool pressure15 = false;
    public static bool pressure20 = false;
    public static bool pressure25 = false;
    
    
    public static bool isPart2Started = false;
    public static bool isCupOnScale = false;
    public static bool ScaleOn = false;
    public static bool isEmptyCupMeasured = false;
    public static bool isWaterCupMeasured = false;
    public static bool isCupOnStand = false;
    public static bool isSwichedOn = false;
    public static bool isWrittenTv1 = false;
    public static bool isVentilSlightlyOpen = false;                    //немного приоткрыли
    public static bool isWrittenTv2 = false;
    public static bool isVentilCloseAfterPractice2 = false;             //закрыли вентиль
    public static bool isCupOnScaleAgain = false;
    public static bool isResetPushed = false;
    public static bool isWrittenM = false;
    public static bool isWrittenH1 = false;
    public static bool isWrittenH2 = false;
    public static bool isWrittenH = false;
    public static bool isWrittenX = false;
}
