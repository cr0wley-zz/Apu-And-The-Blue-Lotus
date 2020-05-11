using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firedmo : MonoBehaviour
{
    public GameObject sp1;
    public GameObject sp2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D( Collider2D col)
    {
        if(col.gameObject.name == "red(Clone)")
        {
            
            StartCoroutine(Example());
        }
    }

    IEnumerator Example()
    {
        sp1.SetActive(false);
        sp2.SetActive(false);
        yield return new WaitForSeconds(3);
        sp1.SetActive(true);
        sp2.SetActive(true);

        print(Time.time);
    }
}
