﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockScript : MonoBehaviour
{
    public GameObject pref;
    public Transform n1;
    public Transform n2;
    public Transform n3;
    private int t = 1;
    // Start is called before the first frame update
    void Start()
    {
        
        
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        t++; 
        if( t % 100 == 0)
        {
            Instantiate(pref, new Vector2(n1.position.x, n1.position.y), Quaternion.identity);
        }
        if(t % 150 == 0)
        {
            Instantiate(pref, new Vector2(n2.position.x, n2.position.y), Quaternion.identity);
        }
        if(t % 200 == 0)
        {
            Instantiate(pref, new Vector2(n3.position.x, n3.position.y), Quaternion.identity);
        }

    }
    
}
