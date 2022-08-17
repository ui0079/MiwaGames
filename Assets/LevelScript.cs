using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 
public class LevelScript : MonoBehaviour {

    
 
    //　スキル獲得ボタン
    [SerializeField]
    public GameObject skill1Button;
    
    [SerializeField]
    public GameObject skill2Button;
    
    [SerializeField]
    public GameObject skill3Button;

    //　スキルメニューパネル
    [SerializeField]
    public GameObject skillPanel;

    public static LevelScript instance;

    public void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
 
    public void StopGame() {
        Time.timeScale = 0f;
        skillPanel.SetActive(true);
        skill1Button.SetActive(true);
        skill2Button.SetActive(true);
        skill3Button.SetActive(true);
    }
 
    public void ReStartGame() {
        skill1Button.SetActive(false);
        skill2Button.SetActive(false);
        skill3Button.SetActive(false);
        skillPanel.SetActive(false);
        Time.timeScale = 1f;
    }
}