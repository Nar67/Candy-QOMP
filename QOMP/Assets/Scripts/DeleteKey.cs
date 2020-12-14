using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteKey : MonoBehaviour
{
    public GameObject door;
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
        currentEulerAngles += new Vector3(0, 0, 1) * Time.deltaTime * speed;

        //moving the value of the Vector3 into Quanternion.eulerAngle format
        currentRotation.eulerAngles = currentEulerAngles;

        //apply the Quaternion.eulerAngles change to the gameObject
        transform.rotation = currentRotation;

        if (currentRotation.eulerAngles.z > 45.0f && currentRotation.eulerAngles.z < 315.0f)
            speed *= -1;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        door.GetComponent<OpenDoor>().key = true;
        Destroy(this.gameObject);
    }
}
