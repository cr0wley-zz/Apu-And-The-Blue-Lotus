using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkCenti : MonoBehaviour
{
    public GameObject centi;
    public GameObject gt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        if( centi == null)
        {
            GetComponent<BoxCollider2D>().enabled = false;
            gt.SetActive(true);
        }
    }
}
