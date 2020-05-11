using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lm : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void lm1()
    {
        SceneManager.LoadScene("BefTut");
    }
    public void lm2()
    {
        SceneManager.LoadScene("Level1");
    }
    public void lm3()
    {
        SceneManager.LoadScene("Level2");
    }
    public void lm4()
    {
        SceneManager.LoadScene("Level4");
    }
}
