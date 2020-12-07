using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRoom : MonoBehaviour
{
    public GameObject cam;
    private float offsetx;
    private float offsety;
    private bool change;
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
 
    }

    IEnumerator OnTriggerExit2D(Collider2D col)
    {
        Debug.Log("Trigger");
        if (!change)
        {
            change = true;
            if(gameObject.tag == "Change_H")
            {
                cam.transform.Translate(offsetx, 0.0f, 0.0f);
                offsetx *= -1;
            }
            else
            {
                cam.transform.Translate(0.0f, offsety, 0.0f);
                offsety *= -1;
            }
                
            yield return new WaitForSeconds(2.0f);
            change = false;
        }

    }
}
