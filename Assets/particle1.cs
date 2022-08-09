using UnityEngine;

public class particle1 : MonoBehaviour
{
	/// <summary>
	/// パーティクルが他のGameObject(Collider)に当たると呼び出される
	/// </summary>
	/// <param name="other"></param>
    public int damage;

	private void OnParticleCollision(GameObject other)
	{
        //ダメージ設定
		other.gameObject.GetComponent<EnemyHealth>().Damage(damage) ;
    
	}
	
}