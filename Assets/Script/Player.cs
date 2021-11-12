using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float Speed;
    public float maxspeed;
    Rigidbody2D rigid;
    SpriteRenderer renderer;
    public bool right = false;
    public bool left = false;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        renderer = GetComponent<SpriteRenderer>();
    }


    void Update()
    {
       if (Input.GetButtonDown("Horizontal"))
        {
            renderer.flipX = Input.GetAxisRaw("Horizontal") == 1;
        }
        if (right)
        {
            transform.Translate(+0.1f*Speed*Time.deltaTime, 0, 0);
            renderer.flipX = true;
        }

        if (left)
        {
            transform.Translate(-0.1f*Speed*Time.deltaTime, 0, 0);
            renderer.flipX = false;
        }
        
        
    }

    void FixedUpdate()
    {
      //  Speed = Input.GetAxisRaw("Horizontal");
      //  rigid.AddForce(Vector2.right * Speed, ForceMode2D.Impulse);

      //  if(rigid.velocity.x > maxspeed)
      //  {
          //  rigid.velocity = new Vector2(maxspeed, rigid.velocity.y);
             
       // }
      //  else if (rigid.velocity.x < maxspeed * (-1))
        //{
//rigid.velocity = new Vector2(maxspeed * (-1), rigid.velocity.y);

       // }
    }

    
        
}
