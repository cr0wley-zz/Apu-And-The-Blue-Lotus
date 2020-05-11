using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicMech : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public GameObject green;
   


    public float maxdis = 5f;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        
        
            HealthManager hm = col.GetComponent<HealthManager>();

     
        


        if (hm != null)
            {
                hm.imhit();
            }
        



            CageScript cs = col.GetComponent<CageScript>();
            if (cs != null)
            {
                cs.des();
            }
            Destroy(gameObject);
        


    }
}
