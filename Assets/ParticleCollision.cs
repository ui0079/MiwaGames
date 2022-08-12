using UnityEngine;

public class ParticleCollision : MonoBehaviour
{
	private void OnParticleCollision(GameObject other)
	{
		Destroy(other.gameObject);
	}
}