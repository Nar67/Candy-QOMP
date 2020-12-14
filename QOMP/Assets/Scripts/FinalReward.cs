using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalReward : MonoBehaviour
{
    public float speed = 70;
    Vector3 currentEulerAngles;
    Quaternion currentRotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //modifying the Vector3, based on input multiplied by speed and time
        currentEulerAngles += new Vector3(0, 1, 0) * Time.deltaTime * speed;

        //moving the value of the Vector3 into Quanternion.eulerAngle format
        currentRotation.eulerAngles = currentEulerAngles;

        //apply the Quaternion.eulerAngles change to the gameObject
        transform.rotation = currentRotation;
    }
}
