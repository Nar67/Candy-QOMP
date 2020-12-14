using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackBall : MonoBehaviour
{
    public GameObject ball;
    public float speed = 2.0f;

    private bool collidedTop;
    private bool collidedBot;
    private bool far;

    // Start is called before the first frame update
    void Start()
    {
        far = true;
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

        checkDistance();
        
    }

    void checkDistance()
    {
        if (far)
        {
            if (ball.transform.position.x > transform.position.x - 3 &&
                ball.transform.position.x < transform.position.x + 3)
            {
                far = false;
                speed++;
            }
        } else
        {
            if (ball.transform.position.x < transform.position.x - 3 ||
                ball.transform.position.x > transform.position.x + 3)
            {
                far = true;
                speed--;
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
