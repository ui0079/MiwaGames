using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    private float x_speed;
    private float y_speed;
    public  float add_speed;

    Vector2 startpos, endpos;
   
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            this.startpos = Input.mousePosition;

        }
        else if (Input.GetMouseButton(0)) {
            endpos = Input.mousePosition;
            float x_vec = endpos.x - startpos.x;
            float y_vec = endpos.y - startpos.y;

            this.x_speed = x_vec / 40000f;
            this.y_speed = y_vec / 40000f;

         
            /*
             * 
             * 最大移動速度設定
            if (this.x_speed >= 0.003) {
                x_speed = 0.003f;
            }
            if (this.x_speed <= -0.003) 
            {
                x_speed = -0.003f;
            }
            if (this.y_speed >= 0.003)
            {
                y_speed = 0.003f;
            }
            if (this.y_speed <= -0.003)
            {
                y_speed = -0.003f;
            }
            */
        }
        if (Input.GetMouseButtonUp(0))
        {
            this.x_speed = 0.0f;
            this.y_speed = 0.0f;
        }



        transform.Translate(this.x_speed + this.add_speed, this.y_speed+this.add_speed, 0);

        

       





    }
}
