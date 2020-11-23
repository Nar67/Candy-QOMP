using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rebound : MonoBehaviour
{
    
    public float speedy = 7.0f;
    public float speedx = -3.0f;
    public bool stuck;
    private float dir;

    // Start is called before the first frame update
    void Start()
    {
        stuck = true;
        dir = speedy;
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


    void OnCollisionEnter(Collision collision)
    {
        print("Collision Out: " + gameObject.name);
        speedx *= -1;
    }
}
