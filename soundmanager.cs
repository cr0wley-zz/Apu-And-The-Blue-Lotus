using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundmanager : MonoBehaviour
{
    public static AudioClip apushoot, apujump;
    static AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        
        apujump = Resources.Load<AudioClip>("Y");
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void playsound(string clip)
    {
        switch (clip)
        {
            
            
            case "jump":
                audio.PlayOneShot(apujump);
                break;



        }
    }
}
