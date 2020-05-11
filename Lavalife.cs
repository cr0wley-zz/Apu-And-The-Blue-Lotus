using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lavalife : MonoBehaviour
{
    public float n = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Vector2 target = new Vector2(transform.position.x, transform.position.y+n);
        transform.position = Vector2.MoveTowards(transform.position, target, 2 * Time.deltaTime);
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 target = new Vector2(transform.position.x, transform.position.y + n);
        transform.position = Vector2.MoveTowards(transform.position, target, 2 * Time.deltaTime);
        Invoke("des", 1);
    }
    
    void des()
    {
        Destroy(gameObject);
    }
}
