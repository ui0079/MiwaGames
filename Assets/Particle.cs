using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//パーティクルを動作するプログラム ここでChangeParticleScriptを実行する
public class Particle : MonoBehaviour
{
    public string currentPrefabName; //現在動作中のパーティクルのプレハブ名
    public GameObject player;

    ChangeParticleScript _changeParticleScript;
    public Dictionary<string, WeaponState> weaponList;
    
    int count = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        _changeParticleScript = GetComponent<ChangeParticleScript>();
        weaponList = _changeParticleScript.weaponList;
        _changeParticleScript.AddWeapon(currentPrefabName);
        //_changeParticleScript.ChangeSpeed(currentPrefabName, weaponState.speed);
        //_changeParticleScript.ChangeAmount(currentPrefabName, weaponState.rate);
    }

    // Update is called once per frame
    void Update()
    {
         _changeParticleScript.SetPosition(currentPrefabName, player);

        //デバッグ用 
        if(Time.time > 5 && Time.time <= 10){
            _changeParticleScript.ChangeSpeed(currentPrefabName, 5);
            _changeParticleScript.ChangeAmount(currentPrefabName, 2);
            if(count == 0){
                currentPrefabName = _changeParticleScript.ChangeWeapon(currentPrefabName, "bullet1");
                count++;
            }
        }
        else if (Time.time > 10){
            if(count == 1){
                currentPrefabName = _changeParticleScript.ChangeWeapon(currentPrefabName, "arrow1");
                count++;
            }
        }
        
    }

    private void OnParticleCollision(GameObject other)
	{
		Destroy(other.gameObject);
	}

}
