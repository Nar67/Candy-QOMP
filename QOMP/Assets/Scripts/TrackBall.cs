using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackBall : MonoBehaviour
{
    public GameObject ball;
    public float speed = 2.0f;

    private bool collidedTop;
    private bool collidedBot;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
        if (!ball.GetComponent<Rebound>().stuck) {
            if (ball.transform.position.y > transform.position.y && !collidedTop)
            {
                transform.Translate(0.0f, speed * Time.deltaTime, 0.0f);
                collidedBot = false;
            }
            else if(ball.transform.position.y <= transform.position.y && !collidedBot)
            {
                transform.Translate(0.0f, -speed * Time.deltaTime, 0.0f);
                collidedTop = false;
            }
        }
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Tiles")
        {
            Vector2 contactPoint = collision.contacts[0].point;
            if(contactPoint.y > transform.position.y)
            {
                collidedTop = true;
            }
            else
            {
                collidedBot = true;
            }
        }
    }
   
}
