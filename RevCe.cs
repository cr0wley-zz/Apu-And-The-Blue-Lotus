using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevCe : MonoBehaviour
{
    public GameObject p;
    public float mindist = 0f;
    private Transform Player;
    public float speed = 5f;

    void start()
    {
        Player = p.GetComponent<Transform>();
        Debug.Log("dadsasdas");
    }

    void update()
    {
        
        


        transform.LookAt(Player.transform.position);
       

        Vector2 targetPos = new Vector2(Player.position.x, transform.position.y);
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed);




       
    }
}
