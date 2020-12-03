using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunxesAttack : MonoBehaviour
{
    public GameObject ball;
    public float speed = 6.0f;
    private float dir;
    public bool stop;

    // Start is called before the first frame update
    void Start()
    {
        dir = 1;
        stop = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!stop) { 
            if (ball.transform.position.y < transform.position.y + 1)
            {
                transform.Translate(30 * Time.deltaTime, 0.0f, 0.0f);
                dir *= -1;

            }
        }
    }

}
