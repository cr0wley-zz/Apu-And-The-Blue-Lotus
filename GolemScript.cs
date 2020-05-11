using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolemScript : MonoBehaviour
{
    public int n = 2;
    public float k = 0f ;
    public Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        StartCoroutine(Example());



    }



    IEnumerator Example()
    {
        
        yield return new WaitForSeconds(n);
        k = Random.Range(-1f, 3f);
        if (k >= 0 && k < 1)
        {
            anim.SetBool("hand1", false);
            anim.SetBool("hand2", false);
            
        }
        if (k >= 1 && k < 2)
        {
            anim.SetBool("hand1", true);
            anim.SetBool("hand2", false);
            
        }
        if (k >= 2 && k < 3)
        {
            anim.SetBool("hand1", false);
            anim.SetBool("hand2", true);
            
        }
        Debug.Log(k);

        
    }
}
