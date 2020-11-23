using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackBall : MonoBehaviour
{
    [SerializeField] private GameObject ball;
    public float speed = 7.0f;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if (!ball.GetComponent<Rebound>().stuck) {
            if (ball.transform.position.y > transform.position.y)
                transform.Translate(0.0f, speed * Time.deltaTime, 0.0f);
            else
                transform.Translate(0.0f, -speed * Time.deltaTime, 0.0f);
        }
        
    }

   
}
