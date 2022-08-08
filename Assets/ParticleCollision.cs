using UnityEngine;

public class ParticleCollision : MonoBehaviour
{
	/// <summary>
	/// パーティクルが他のGameObject(Collider)に当たると呼び出される
	/// </summary>
	/// <param name="other"></param>
	private void OnParticleCollision(GameObject other)
	{
		Destroy(other.gameObject);
	}
}