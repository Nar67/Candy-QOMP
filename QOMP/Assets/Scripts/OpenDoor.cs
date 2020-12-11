using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public AudioSource door;
    public bool key;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        key = false;
        door = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (key)
        {
            door.Play();
            animator.SetTrigger("key");
            Destroy(this.GetComponent<BoxCollider2D>());
            key = false;
        }
        
    }
}
