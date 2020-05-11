using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gols : MonoBehaviour
{
    public Transform player;
    public float dist = 50f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x - player.position.x < dist)
        {
            GetComponent<AudioSource>().enabled = true;
        }
    }
}
