using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rebound : MonoBehaviour
{
    
    public float speedy = 7.0f;
    public float speedx = 3.0f;
    public bool stuck;
    private float dir;
    private Vector3 initialPos;
    private float initSpeedy;
    private float initSpeedx;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        stuck = true;
        dir = speedy;
        initialPos = gameObject.transform.position;
        initSpeedx = speedx;
        initSpeedy = speedy;
    }

    // Update is called once per frame
    void Update()
    {
        if (stuck)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                stuck = false;
                transform.Translate(speedx * Time.deltaTime, dir * Time.deltaTime, 0.0f);
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                dir *= -1;
            }
            transform.Translate(speedx * Time.deltaTime, dir * Time.deltaTime, 0.0f);
        }
            
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        Collider2D collider = collision.contacts[0].otherCollider;
        if (collider.gameObject.name == "Top" || collider.gameObject.name == "Bottom")
        {
            dir *= -1;
        }
        else if (collider.gameObject.name == "Left" || collider.gameObject.name == "Right")
        {
            if(collider.gameObject.name == "Right")
            {
                animator.SetBool("collidedRight", true);
            }
            speedx *= -1;
        }
        
        if (collision.gameObject.tag == "Punxes")
        {
            gameObject.transform.position = initialPos;
            stuck = true;
            speedx = initSpeedx;
            speedy = initSpeedy;
        }
        //else 
        //    speedx *= -1;
    }
}
