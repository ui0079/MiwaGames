using UnityEngine;
using UnityEngine.UI;


public class ScoreGauge : MonoBehaviour
{
    

    int countMin;       //体力ゲージ最小値
    int countMax;       //体力ゲージ最大値
    int count;          //体力ゲージ現状値

    
    
    public Slider gauge;                //ゲージ表示用

    public static ScoreGauge instance;
    

    public void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        
        countMin = 0;
        countMax = MoveCharactorController.instance.playerHP;
        count = MoveCharactorController.instance.playerHP;

        gauge.minValue = countMin;
        gauge.maxValue = countMax;
        gauge.value = count;

        
    }

    public void Damage1(int x)
    {
        if (x > 0)
        {
            if (count <= countMax)
            {
                count = count - x;

                if (count <0)
                {
                    count = 0;
                }

                gauge.value = count;
            }
        }
        else
        {
            if (count > countMin)
            {
                count = count + x;

                if (count > countMax)
                {
                    count = countMax;
                }

                gauge.value = count;
            }
        }
        
    }
}