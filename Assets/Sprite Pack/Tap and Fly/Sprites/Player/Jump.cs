using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jump : MonoBehaviour
{
    Rigidbody2D body;
    public AudioSource mtsfx;
    public AudioClip JumpS;
    public AudioClip Pointget;
    public AudioClip Hit;
    public AudioClip TaDa;
    float point1 = 0;
    public Text score;
    GameObject Startbutton;
    bool Gameover = false;
    Animator Ani;

    //구조
    // Start is called before the first frame update
    void Start()
    {
        Ani = GetComponent<Animator>();
        Startbutton = GameObject.Find("Button1");
        Time.timeScale = 0;
        body = GetComponent<Rigidbody2D>();        
    }

    public void Start1()
    {
        Gameover = false;
        Ani.SetBool("gameover1", false);
        Startbutton.SetActive(false);
        transform.position = new Vector3(0, -0.7f, -1);
        point1 = 0;
    }

    public void Tap()
    {
        body.velocity = Vector2.up * 15;
        mtsfx.PlayOneShot(JumpS);

    }

    // Update is called once per frame
    void Update()
    {
        if (Gameover == true)
        {
            Time.timeScale = 0;
        }
        else if (Gameover == false)
        {
            Time.timeScale = 1;
        }
        score.text = point1.ToString();
        
        if(point1 == 10)
        {
            mtsfx.PlayOneShot(TaDa);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if(collision.gameObject.tag == "Box")
        {
            Debug.Log(collision.gameObject.name);
            Ani.SetBool("gameover1", true);
            
            mtsfx.PlayOneShot(Hit);
            Startbutton.SetActive(true);
            Gameover = true;

        }

   
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "point")
        {
            point1 = point1 + 1;
            mtsfx.PlayOneShot(Pointget);
            Debug.Log(" 스코어는 " + point1);
        }
    }
}    

