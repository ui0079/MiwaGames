using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    public float x_speed;
    public float y_speed;
    Vector2 startpos;
   
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            this.startpos = Input.mousePosition;

        }
        else if (Input.GetMouseButtonUp(0)) {
            Vector2 endpos = Input.mousePosition;
            float x_vec = endpos.x - startpos.x;
            float y_vec = endpos.y - startpos.y;

            this.x_speed = x_vec / 100000f;
            this.y_speed = y_vec / 100000f;
        }
        


        transform.Translate(this.x_speed, this.y_speed, 0);

       





    }
}
