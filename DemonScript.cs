using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonScript : MonoBehaviour
{
    public Animator anim;
    int t = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t++;
        if(t % 73 ==0)
        {
            anim.SetBool("Trigg", true);
        }

        if( t % 150== 0)
        {
            anim.SetBool("Trigg", false);
        }
    }
}
