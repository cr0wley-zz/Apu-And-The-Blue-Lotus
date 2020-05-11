using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endtrigger : MonoBehaviour
{
    public GameObject pref;
    public GameObject gt;
    public float n = 2f;
    public float x = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D()
    {
        gt.SetActive(true);
        Invoke("maa", 3);
    }
    void maa()
    {
        Instantiate(pref, new Vector3(transform.position.x +x, transform.position.y+n, 0), Quaternion.identity);

    }
}
