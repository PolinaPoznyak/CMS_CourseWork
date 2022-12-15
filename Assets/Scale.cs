using TMPro;
using UnityEngine;

public class Scale : MonoBehaviour
{
    public TMP_Text valueWaight;
    public float scoreAmountGramm;
    public float pointIncreasedPerSecondGramm;

    float mk;
    float m;
    //float m_after;

    public void Start()
    {
        scoreAmountGramm = 0f;
        pointIncreasedPerSecondGramm = 3000f;

        mk = 353;
        m = Random.Range(439, 480);
        //m_after = Random.Range(107, 480);
    }

    public void FixedUpdate()
    {
        if (StatesVariables.isCupOnScale)
        {
            scoreAmountGramm = mk;
            valueWaight.text = (int)scoreAmountGramm + "";
        }
        if (StatesVariables.isCupOnScale && StatesVariables.isEmptyCupMeasured)
        {
            scoreAmountGramm = m;
            valueWaight.text = (int)scoreAmountGramm + "";
        }
        if (StatesVariables.isCupOnStand)
        {
            scoreAmountGramm = 0;
            valueWaight.text = (int)scoreAmountGramm + "";
        }
        if (StatesVariables.isResetPushed)
        {
            scoreAmountGramm = 460;
            valueWaight.text = (int)scoreAmountGramm + "";
        }
    }
}
