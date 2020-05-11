using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int hit = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(hit < 1)
        {
            Destroy(gameObject);
        }
    }

     public void imhit()
    {
        hit--;
        Debug.Log(hit);
    }
    public void imhit1()
    {
        hit--;
        hit--;
    }

}
