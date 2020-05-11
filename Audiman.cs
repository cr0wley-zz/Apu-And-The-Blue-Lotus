using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audiman : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    int t = 0;
    // Update is called once per frame
    void Update()
    {
        t++;

        if(t%300 == 0)
        {
            GetComponent<AudioSource>().enabled = true;
        }
        if (t%500 == 0)
        {
            GetComponent<AudioSource>().enabled =false;
        }
    }
    
}
