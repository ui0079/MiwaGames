using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpgradeWeaponUI : MonoBehaviour
{
    public TextMeshProUGUI label;
    public int num;

    public UpgradeWeaponUI(int input_num){
        num = input_num;
    }

    public void OnClickPlus(){
        num++;
        Debug.Log(label);
        Debug.Log(num);
        UpdateLabel();
    }

    public void OnClickMinus(){
        if(num > 0){
            num--;
        }
        Debug.Log(label);
        Debug.Log(num);
        UpdateLabel();
    }

    void UpdateLabel(){
        Debug.Log(label.text);
        label.text=num.ToString();
    }
}
