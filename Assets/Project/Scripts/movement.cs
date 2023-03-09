using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private Rigidbody2D rb;
    private float speed = 30f;
    private Vector2 moveVector;
    public Animator anim;
    private float movex;
    private float movey;
    private string act = "active";

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movex = Input.GetAxis("Horizontal");
        movey = Input.GetAxis("Vertical");
        moveVector.x = Input.GetAxis("Horizontal") * Time.deltaTime;
        moveVector.y = Input.GetAxis("Vertical") * Time.deltaTime;
        rb.MovePosition(rb.position + moveVector * speed);
        if (movex == 0 && movey == 0)
        {
            anim.SetBool("IsRunning", false);
        }
        else
        {
            anim.SetBool("IsRunning", true);
        }

    }
    private void OnCollisionStay2D(Collision2D other)
    {
        if (Input.GetKey(KeyCode.F))
        {
            string names;
            Vector2 move;
            if (other.gameObject.tag == "box")
            {
                names = other.gameObject.name;
                if (names == "box1" || names == "box2" || names == "box3" || names == "box4")
                {
                    GameObject boxx = GameObject.Find(names);
                    float poz1 = other.transform.position.x + 1f;
                    move.x = poz1;
                    names = names + act;
                    if (names == "box1active")
                    {
                        GameManager1.instance.keyroom2.SetActive(true);

                    }
                    boxx.name = names;
                    boxx.transform.position = new Vector2(move.x, boxx.transform.position.y);
                }
                else
                {
                    names = other.gameObject.name;
                    GameObject box = GameObject.Find(names);
                    float poz = other.transform.position.x - 1f;
                    move.x = poz;
                    names = names.Replace(act, "");
                    if (names == "box1")
                    {
                        GameManager1.instance.keyroom2.SetActive(false);

                    }
                    box.name = names;
                    box.transform.position = new Vector2(move.x, box.transform.position.y);
                }

            }
        }
    }
}

        
    
