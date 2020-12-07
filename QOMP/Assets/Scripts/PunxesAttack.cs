using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunxesAttack : MonoBehaviour
{
    public GameObject ball;
    public float speed = 20.0f;
    public bool stop;

    // Start is called before the first frame update
    void Start()
    {
        stop = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!stop) {
            if (this.gameObject.tag == "Punxes_H")
            {
                if (ball.transform.position.y < transform.position.y + 1)
                {
                    transform.Translate(speed * Time.deltaTime, 0.0f, 0.0f);
                }
            }
            
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject != ball)
        {
            Debug.Log("Punxes");
            speed *= -1;
        }
       
    }

}
