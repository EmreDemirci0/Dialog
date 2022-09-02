using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialog : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    [SerializeField] float typingSpeed = .02f;
    [SerializeField] GameObject ipucuPanel;
    public Rigidbody2D s;
    public bool birkeregir;
    private void Start()
    {
        birkeregir = false ;  
    }
    void Update()
    {   
        
        if (ipucuPanel.gameObject.activeSelf==true && birkeregir==false)
        {
            StartCoroutine(LetterSeconds());
            birkeregir = true;
        }
       
    }
    public void nextSentences()
    {
        textDisplay.text = "";
        index += 1;
        StartCoroutine(LetterSeconds());
    }
    IEnumerator LetterSeconds()
    {
       
        if (index >= sentences.Length)
        {
            index = -1;
            yield break;
        }

        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }


}
