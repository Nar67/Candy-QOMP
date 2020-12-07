using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRoom : MonoBehaviour
{
    public GameObject cam;
    private float offset;
    private bool change;
    // Start is called before the first frame update
    void Start()
    {
        change = false;
        offset = 30.0f;
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
            cam.transform.Translate(offset, 0.0f, 0.0f);
            offset *= -1;
            yield return new WaitForSeconds(2.0f);
            change = false;
        }

    }
}
