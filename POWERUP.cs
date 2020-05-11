using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POWERUP : MonoBehaviour
{
    public Transform firepoint;
    public GameObject magic;
    public GameObject r;
    public GameObject magic2;
    public GameObject r2;
    public int allowance = 10;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
           if(r == null)  
            shoot();
        }
        if (Input.GetButtonDown("Fire2"))
        {
            if (r2 == null )
            {
                if (allowance != 0)
                {
                    allowance--;
                    shoot1();
                }
            }
        }
    }

    void shoot()
    {
        Instantiate(magic, firepoint.position, firepoint.rotation);
    }
    void shoot1()
    {
        Instantiate(magic2, firepoint.position, firepoint.rotation);
    }


}
