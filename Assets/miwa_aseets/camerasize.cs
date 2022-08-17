using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class camerasize : MonoBehaviour {
 
    private void Start()
    {
        Debug.Log("画面の左下の座標は " + Camera.main.ViewportToWorldPoint(Vector2.zero) + " です");
        Debug.Log("画面の右上の座標は " + Camera.main.ViewportToWorldPoint(Vector2.one) + " です");
    }
 
}
