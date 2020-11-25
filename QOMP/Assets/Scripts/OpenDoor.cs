using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public bool key;
    public Material mat;
    // Start is called before the first frame update
    void Start()
    {
        key = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (key)
        {
            this.GetComponent<MeshRenderer>().material = mat;
            Destroy(this.GetComponent<BoxCollider2D>());
        }
        
    }
}
