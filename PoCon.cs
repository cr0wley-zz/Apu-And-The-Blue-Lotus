using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoCon : MonoBehaviour
{ public float mindist = 100f;
    private float x; 
    // Start is called before the first frame update
    void Start()
    {
        x = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x - x > mindist)
        {  
            Destroy(gameObject);
        }
    }
}
