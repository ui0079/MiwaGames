using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//武器の操作をするクラス
public class ChangeParticleScript : MonoBehaviour
{
    public Dictionary<string, WeaponState> weaponList = new Dictionary<string, WeaponState>();

    //パーティクルの発射速度を変更
    public void ChangeSpeed(string prefabName, float speed)
    {
        weaponList[prefabName].speed = speed;
        var main = weaponList[prefabName].partcleSystem.main;
        main.simulationSpeed = speed;
    }

    //パーティクルの発射量を変更
    public void ChangeAmount(string prefabName, float rate)
    {
        weaponList[prefabName].rate = rate;
        var emission = weaponList[prefabName].partcleSystem.emission;
        emission.rateOverTime = rate;
    }

    //新規パーティクルを追加・発射
    public void AddWeapon(string prefabName){
        if(weaponList.ContainsKey(prefabName)){
            Debug.Log(weaponList[prefabName].partcleSystem);
            weaponList[prefabName].gameObject.SetActive(true);
            weaponList[prefabName].partcleSystem.Play();
        }
        else{
            GameObject newParticleObject = (GameObject)Resources.Load(prefabName);
            newParticleObject = Instantiate(newParticleObject);
            ParticleSystem newParticle = newParticleObject.GetComponent<ParticleSystem>();

            WeaponState newWeaponState = newParticleObject.GetComponent<WeaponState>();
            Debug.Log("NULL: " + newWeaponState.speed);
            newWeaponState.partcleSystem = newParticle;
            weaponList.Add(prefabName, newWeaponState);

            ChangeSpeed(prefabName, newWeaponState.speed);
            ChangeAmount(prefabName, newWeaponState.rate);

            weaponList[prefabName].partcleSystem.Play();
        }
        
    }

    //指定したオブジェクトからパーティクルを発射
    public void SetPosition(string currentPrefabName, GameObject target){
        weaponList[currentPrefabName].partcleSystem.transform.position = target.transform.position;
    }

     //武器の変更
    public string ChangeWeapon(string currentPrefabName, string nextPrefabName)
    {
        weaponList[currentPrefabName].partcleSystem.Stop();
        AddWeapon(nextPrefabName);
        return nextPrefabName;
    }
}
