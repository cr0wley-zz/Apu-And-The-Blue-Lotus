using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dured : MonoBehaviour
{

    public Transform player;
    public GameObject sp1;
    public GameObject sp2;
    public GameObject sp3;
    public float n = 24f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x - player.position.x < n)
        {
            GetComponent<AudioSource>().enabled = true;
           
        }
    }
}
