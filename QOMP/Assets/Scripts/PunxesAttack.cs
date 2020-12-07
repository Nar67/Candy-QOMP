using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunxesAttack : MonoBehaviour
{
    public GameObject ball;
    public float speed = 20.0f;
    public bool stop;
    private Vector3 initialPos;
    private float initspeed;

    // Start is called before the first frame update
    void Start()
    {
        stop = true;
        initspeed = speed;
        initialPos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (stop) {
            if (this.gameObject.tag == "Punxes_H" && !ball.GetComponent<Rebound>().dead)
            {

                if ((ball.transform.position.y < transform.position.y + 1) &&
                    (ball.transform.position.y > transform.position.y - 1 ))
                {
                    stop = false;
                }
                              
            }
            
        }
        else
        {
            transform.Translate(speed * Time.deltaTime, 0.0f, 0.0f);
        }
    }

    IEnumerator OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject != ball)
        {
            Debug.Log("Punxes");
            speed *= -1;
            stop = true;
            yield return new WaitForSeconds(0.3f);
            stop = false;
        }
        else
        {
            stop = true;
            yield return new WaitForSeconds(1.0f);
            gameObject.transform.position = initialPos;
            speed = initspeed;
        }
    }

}
