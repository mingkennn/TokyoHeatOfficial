using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CutsceneDialog : MonoBehaviour
{
    // All variables that are needed for cutscenes
    // I used textMeshPro therefore needed to import it
    public TextMeshProUGUI textDisplay;
    public GameObject continueButton;
    public GameObject nextButton;
    public string[] sentences;
    public float speed;

    private int index;
    
    
    void Start()
    {
        //Starting it alongside the Cutscenes
        StartCoroutine(Type());
    }

    void Update()
    {
        //Ensures that when all the text has been printed on the screen, it then enables the continue button for the player

        if(textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
        }
    }

    IEnumerator Type()
    {

        //Prints the text to the screen
        foreach(char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(speed);
        }
    }

    public void nextSentence()
    {
        //Checks when the current string has been finished printing and prints next string

        AudioSource aSource = GetComponent<AudioSource>();
        aSource.Play();
        continueButton.SetActive(false);

        if(index <sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        } else
        {
            textDisplay.text = "";
            
            nextButton.SetActive(true);
        }
    }
}
