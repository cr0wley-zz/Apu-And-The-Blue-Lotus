using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class NewD : MonoBehaviour
{
    public TextMeshProUGUI textdisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    public GameObject continueb;
    public GameObject end;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Type());
    }

    // Update is called once per frame
    void Update()
    {
        if (textdisplay.text == sentences[index])
        {
            continueb.SetActive(true);
            
        }
    }
    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            textdisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
    public void NextSentence()
    {
        continueb.SetActive(false);
        if (index < sentences.Length - 1)
        {
            index++;
            textdisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textdisplay.text = "";
            if (end.name == "End talk")
            {
                Invoke("nex", 2);
            }
        }
    }

    void nex()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
