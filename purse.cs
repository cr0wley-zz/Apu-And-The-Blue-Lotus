using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class purse : MonoBehaviour
{
    public GameObject pt;
    public GameObject r;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (r == null)
        {
            pt.SetActive(true);
        }
    }
}

