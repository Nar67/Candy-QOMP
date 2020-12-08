using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRoom : MonoBehaviour
{
    public GameObject cam;
    private float offsetx;
    private float offsety;
    private bool change;

    public float smoothTime = 0.5F;
    private Vector3 velocity = Vector3.zero;
    private Vector3 camStartPos;
    private Vector3 camEndPos;

    // Start is called before the first frame update
    void Start()
    {
        change = false;
        offsetx = 30.0f;
        offsety = -15.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(change)
        {
            cam.transform.position = Vector3.SmoothDamp(cam.transform.position, camEndPos, ref velocity, smoothTime);
        }
    }

    IEnumerator OnTriggerExit2D(Collider2D col)
    {
        Debug.Log("Trigger");
        if (!change)
        {
            camStartPos = cam.transform.position;
            change = true;
            if(gameObject.tag == "Change_H")
            {
                camEndPos = camStartPos + new Vector3(offsetx, 0.0f, 0.0f);
                offsetx *= -1;
            }
            else if(gameObject.tag == "Change_V")
            {
                camEndPos = camStartPos + new Vector3(0.0f, offsety, 0.0f);
                offsety *= -1;
            }
                
            yield return new WaitForSeconds(2.0f);
            change = false;
        }

    }
}
