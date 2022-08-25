using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Bossanime : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D body;
    private Animator anime;
    private Vector2 movement;
    private GameObject player;
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        anime = GetComponent<Animator>();
        player =  GameObject.FindGameObjectsWithTag("Player")[0];
    }
    private void Update()
    {

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
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        anime.SetBool("isWalking", movement != Vector2.zero);
        if (movement != Vector2.zero)
        {
            anime.SetFloat("X", fx*vx);
            anime.SetFloat("Y", fy*vy);
        }
    }
    private void FixedUpdate()
    {
        body.MovePosition(body.position + movement.normalized * speed * Time.fixedDeltaTime);
    }
}