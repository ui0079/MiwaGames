using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public GameObject enemy01;

	void Start () {
        Vector3 min = Camera.main.ViewportToWorldPoint(Vector2.zero);
        Vector3 max = Camera.main.ViewportToWorldPoint(Vector2.one);
		Vector3 enemyPosition = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, Camera.main.nearClipPlane));
		enemyPosition.z = 0;
		Instantiate (enemy01, enemyPosition, Quaternion.identity);
        Debug.Log("enemyposition " + enemyPosition + " です");
	}
}