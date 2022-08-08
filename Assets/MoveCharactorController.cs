using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharactorController : MonoBehaviour
{
    private float speed = 0.01f;
    //---ここから追加----
    private SpriteRenderer renderer;
    //---ここまで追加----

    void Start()
    {
        //---ここから追加----
        renderer = GetComponent<SpriteRenderer>();
        //---ここまで追加----
    }

    void Update()
    {
        Vector2 position = transform.position;

        if (Input.GetKey("left"))
        {
            position.x -= speed;
        　//---ここから追加----
            renderer.flipX = false;
        　//---ここまで追加----
        }
        else if (Input.GetKey("right"))
        {
            position.x += speed;
        　//---ここから追加----
            renderer.flipX = true;
        　//---ここまで追加----
        }
        else if (Input.GetKey("up"))
        {
            position.y += speed;
        }
        else if (Input.GetKey("down"))
        {
            position.y -= speed;
        }

        transform.position = position;
    }
}