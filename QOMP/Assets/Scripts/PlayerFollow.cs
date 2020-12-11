using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    public GameObject ball;
    public Transform target;
    public float smoothTime = 0.5F;   
    private Vector3 velocity = Vector3.zero;
    private Vector3 startPos;
    private Vector3 initialPos;

    void Start()
    {
        //initialPos = gameObject.transform.position;
       
    }

    void Update()
    {
        Vector3 targetPosition = target.TransformPoint(new Vector3(0, 0, -10));
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
        /*if (ball.GetComponent<Rebound>().dead)
        {
            startPos = gameObject.transform.position;
            transform.position = Vector3.SmoothDamp(gameObject.transform.position, initialPos, ref velocity, smoothTime);
        }*/
    }
}
