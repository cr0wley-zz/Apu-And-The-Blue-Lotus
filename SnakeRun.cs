using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeRun : MonoBehaviour
{
    private Transform p;
    public GameObject y;
    public float speed = 5f;
    public float MinDist = 3f;
    private bool flipped = false;

    // Start is called before the first frame update
    void Start()
    {
        p = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if ((transform.position.x - p.transform.position.x) > 0)
        {
            if (flipped == true)
            {
                flip();
                flipped = false;
            }
        }
        if ((transform.position.x - p.transform.position.x) < 0)
        {
            if (flipped == false)
            {
                flip();
                flipped = true;
            }
        }



        if (Vector2.Distance(transform.position, y.transform.position) <= MinDist)
        {
            Debug.Log(-transform.position.x + y.transform.position.x);
            Vector2 target = new Vector2(p.position.x, transform.position.y);
            transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        }
    }

    void flip()
    {

        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;

    }
}
