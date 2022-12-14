
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public GameObject effectPrefab;
    public AudioClip destroySound;
    public int enemyHP;
    
    public void Damage(int damage) {
        enemyHP -= damage;
        if (enemyHP <= 0)
        {
            MoveCharactorController.instance.AddExp(3);
            
            Destroy(gameObject);
        }
    }
    
    // private void OnTriggerEnter(Collider other)
    // {
        
    //     もしもぶつかった相手に「Missile」というタグ（Tag）がついていたら、
        
    //     if (other.gameObject.CompareTag("Player"))
    //     {
            
    //         // エフェクトを発生させる
    //         GameObject effect = Instantiate(effectPrefab, transform.position, Quaternion.identity);

    //         // 0.5秒後にエフェクトを消す
    //         Destroy(effect, 0.5f);

    //         // 敵のHPを１ずつ減少させる
    //         enemyHP -= 1;

    //         // ミサイルを削除する
    //         Destroy(other.gameObject);

    //         // 敵のHPが０になったら敵オブジェクトを破壊する。
    //         if (enemyHP == 10)
    //         {
    //             // 親オブジェクトを破壊する（ポイント；この使い方を覚えよう！）
    //             Destroy(transform.root.gameObject);

    //             // 破壊の効果音を出す
    //             AudioSource.PlayClipAtPoint(destroySound, transform.position);
    //         }
    //     }
        
    // }
}