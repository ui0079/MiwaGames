using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
	EnemyStatus Enest;
	private Rigidbody2D rb;
	private GameObject player;

	// Start is called before the first frame update
	void Start()
	{
		Enest = new EnemyStatus();
		rb = GetComponent<Rigidbody2D>();
		player =  GameObject.FindGameObjectsWithTag("Player")[0];
	}

	// Update is called once per frame
	void Update()
	{
		if (Mathf.Approximately(Time.timeScale, 0f)) {
		return;
	}
		Vector3 pv = player.transform.position;
		Vector3 ev = transform.position;
		Vector2 min = Camera.main.ViewportToWorldPoint(Vector2.zero);
		Vector2 max = Camera.main.ViewportToWorldPoint(Vector2.one);

		float fx = Mathf.Abs(min.x - max.x);
		float fy = Mathf.Abs(min.y - max.y);
 
		float p_vX = pv.x - ev.x;
		float p_vY = pv.y - ev.y;
 
		float vx = 0f;
		float vy = 0f;

		float xy = Mathf.Abs(p_vX) + Mathf.Abs(p_vY);
 
		// 減算した結果がマイナスであればXは減算処理
		if ( p_vX < 0 ) {
			vx = p_vX / xy / 4000;
		} else {
			vx = p_vX / xy / 4000;
		}

		// 減算した結果がマイナスであればYは減算処理
		if ( p_vY < 0 ) {
			vy = p_vY / xy / 4000;
		} else {
			vy = p_vY / xy / 4000;
		}

		transform.Translate(fx*vx, fy*vy, 0);
	}
}
