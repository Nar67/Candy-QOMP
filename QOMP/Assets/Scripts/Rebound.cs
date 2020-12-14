using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Rebound : MonoBehaviour
{
    public AudioSource bounce;

    public float speedy = 7.0f;
    public float speedx = 3.0f;
    public bool stuck;
    private float dir;
    private Vector3 initialPos;
    private float initSpeedy;
    private float initSpeedx;
    public bool dead;

    public Text text;
    public bool godmode;
    private float timeToAppear = 2f;
    private float timeToDisappear;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        stuck = true;
        dir = speedy;
        initialPos = gameObject.transform.position;
        initSpeedx = speedx;
        initSpeedy = speedy;
        dead = false;
        bounce = GetComponent<AudioSource>();
        godmode = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!dead)
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
        if (Input.GetKeyDown(KeyCode.G))
        {
            if(godmode)
            {
                text.text = "Godmode: off";
                godmode = false;
            }
            else
            {
                text.text = "Godmode: on";
                godmode = true;
            }
            enableText();
        }
        if(Time.time >= timeToDisappear)
        {
            text.enabled = false;
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
        }
       
    }

    public void enableText()
    {
        text.enabled = true;
        timeToDisappear = Time.time + timeToAppear;
    }

    IEnumerator OnCollisionEnter2D(Collision2D collision)
    {

        if ((collision.gameObject.tag == "Punxes" || collision.gameObject.tag == "Spikes") && !godmode)
        {
            GameObject punxes = collision.gameObject;
            stuck = true;
            dead = true;
            animator.SetTrigger("die");
            yield return new WaitForSeconds(0.567f);
            gameObject.transform.position = initialPos;
            yield return new WaitForSeconds(0.5f);
            animator.SetTrigger("restart");
            yield return new WaitForSeconds(0.5f);
            stuck = true;
            speedx = initSpeedx;
            speedy = initSpeedy;
            dead = false;
        }
        else
        {
            bounce.Play();
            Collider2D collider = collision.contacts[0].otherCollider;
            if (collider.gameObject.name == "Top" || collider.gameObject.name == "Bottom")
            {
                if (collider.gameObject.name == "Top")
                {
                    animator.SetTrigger("collidedUp");
                    //Debug.Log("Up");
                }
                else
                {
                    animator.SetTrigger("collidedDown");
                    //Debug.Log("D");
                }
                dir *= -1;
            }
            else if (collider.gameObject.name == "Left" || collider.gameObject.name == "Right")
            {
                if (collider.gameObject.name == "Right")
                {
                    animator.SetTrigger("collidedRight");
                    //Debug.Log("R");
                }
                else
                {
                    animator.SetTrigger("collidedLeft");
                    //Debug.Log("L");
                }
                speedx *= -1;
            }

        }
    }

}
