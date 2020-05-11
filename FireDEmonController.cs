using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireDEmonController : MonoBehaviour
{
    private int n = 0;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        n++;
       if(n%500 == 0)
        {
            anim.SetBool("hand", true);

        }
       if( n % 700 == 0)
        {
            anim.SetBool("hand", false);
        }
    }
}
