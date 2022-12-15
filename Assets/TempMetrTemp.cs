using TMPro;
using UnityEngine;

public class TempMetrTemp : MonoBehaviour
{
    public TMP_Text pressure;
    public TMP_Text temperature;

    public float scoreAmountPress;
    public float scoreAmountTemp;

    public float pointIncreasedPerSecondTemp;
    public float pointIncreasedPerSecondPress;

    bool pressure0increase = false;
    bool pressure5increase = false;
    bool pressure10increase = false;
    bool pressure15increase = false;
    bool pressure20increase = false;

    float tempAtPressEqual0;
    float tempAtPressEqual5;
    float tempAtPressEqual10;
    float tempAtPressEqual15;
    float tempAtPressEqual20;
    float tempAtPressEqual25;
    
    //float tempBeforePart2;
    //float tempAfterPart2;

    public void Start()
    {
        scoreAmountTemp = 26f;
        pointIncreasedPerSecondTemp = 1f; 
        
        scoreAmountPress = 0f;
        pointIncreasedPerSecondPress = 1f;

        tempAtPressEqual0 = Random.Range(100, 106);
        tempAtPressEqual5 = Random.Range(107, 114);
        tempAtPressEqual10 = Random.Range(115, 122);
        tempAtPressEqual15 = Random.Range(123, 129);
        tempAtPressEqual20 = Random.Range(130, 135);
        tempAtPressEqual25 = Random.Range(136, 140);
        
        //tempAtPressEqual20 = Random.Range(8, 12);
        //tempAtPressEqual25 = Random.Range(57.5f, 140.5f);
    }

    public void Update()
    {
        
    }

    public void FixedUpdate()
    {
        if (StatesVariables.is200Watts == true && scoreAmountTemp < 101)             //должна расти ~ до 100 градусов
        {
            temperature.text = (int)scoreAmountTemp + "";
            scoreAmountTemp += pointIncreasedPerSecondTemp * Time.deltaTime;
        }
        if (StatesVariables.isVentilCloseForPractice1 == true && scoreAmountTemp < tempAtPressEqual0)
        {
            temperature.text = (int)scoreAmountTemp + "";
            scoreAmountTemp += pointIncreasedPerSecondTemp * Time.deltaTime;
        }
        if (StatesVariables.pressure0 == true && scoreAmountPress < 6)              // температура при 0 записана, давление растет до 5
        {
            pressure.text = (int)scoreAmountPress + "";
            scoreAmountPress += pointIncreasedPerSecondPress * Time.deltaTime;
            pressure0increase = true;
        }
        if (pressure0increase == true && scoreAmountTemp < tempAtPressEqual5)
        {
            temperature.text = (int)scoreAmountTemp + "";
            scoreAmountTemp += pointIncreasedPerSecondTemp * Time.deltaTime;
        }
        if (StatesVariables.pressure5 == true && scoreAmountPress < 11)              // температура при 5 записана, давление растет до 10
        {
            pressure.text = (int)scoreAmountPress + "";
            scoreAmountPress += pointIncreasedPerSecondPress * Time.deltaTime;
            pressure5increase = true;
        }
        if (pressure5increase == true && scoreAmountTemp < tempAtPressEqual10)
        {
            temperature.text = (int)scoreAmountTemp + "";
            scoreAmountTemp += pointIncreasedPerSecondTemp * Time.deltaTime;
        }

        if (StatesVariables.pressure10 == true && scoreAmountPress < 16)              // температура при 10 записана, давление растет до 15
        {
            pressure.text = (int)scoreAmountPress + "";
            scoreAmountPress += pointIncreasedPerSecondPress * Time.deltaTime;
            pressure10increase = true;
        }
        if (pressure10increase == true && scoreAmountTemp < tempAtPressEqual15)
        {
            temperature.text = (int)scoreAmountTemp + "";
            scoreAmountTemp += pointIncreasedPerSecondTemp * Time.deltaTime;
        }
        if (StatesVariables.pressure15 == true && scoreAmountPress < 21)              // температура при 15 записана, давление растет до 20
        {
            pressure.text = (int)scoreAmountPress + "";
            scoreAmountPress += pointIncreasedPerSecondPress * Time.deltaTime;
            pressure15increase = true;
        }
        if (pressure15increase == true && scoreAmountTemp < tempAtPressEqual20)
        {
            temperature.text = (int)scoreAmountTemp + "";
            scoreAmountTemp += pointIncreasedPerSecondTemp * Time.deltaTime;
        }
        if (StatesVariables.pressure20 == true && scoreAmountPress < 26)              // температура при 20 записана, давление растет до 25
        {
            pressure.text = (int)scoreAmountPress + "";
            scoreAmountPress += pointIncreasedPerSecondPress * Time.deltaTime;
            pressure20increase = true;
        }
        if (pressure20increase == true && scoreAmountTemp < tempAtPressEqual25)
        {
            temperature.text = (int)scoreAmountTemp + "";
            scoreAmountTemp += pointIncreasedPerSecondTemp * Time.deltaTime;
        }

        //if (StatesVariables.isSwichedOn == true && scoreAmountTemp < tempBeforePart2)
        //{
        //    temperature.text = (int)scoreAmountTemp + "";
        //    scoreAmountTemp -= pointIncreasedPerSecondTemp * Time.deltaTime;
        //}
    }
}
