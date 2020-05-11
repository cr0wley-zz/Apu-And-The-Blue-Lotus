using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redFlame : MonoBehaviour
{


    public float speed = 20f;
    public Rigidbody2D rb;
    public GameObject sp1;
    public GameObject sp2;


    public float maxdis = 5f;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
        sp1 = GameObject.Find("rocktr");
        sp2 = GameObject.Find("lavacol");
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    void OnTriggerEnter2D()
    {


        Destroy(gameObject);


    }
  
}
