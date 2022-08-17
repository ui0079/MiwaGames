using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//武器の情報を保存するクラス
public class WeaponState : MonoBehaviour
{
    public GameObject gameObject; //ゲームオブジェクト
    public ParticleSystem partcleSystem; //パーティクルシステム
    public float speed; //発射速度
    public float rate; //発射回数
    public float damage; //攻撃力
};
