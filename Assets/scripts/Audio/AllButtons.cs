using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Allows for buttons to transport the player to the next required scene

public class AllButtons : MonoBehaviour
{
    public static AllButtons control;



    public void StartMap1()
    {
        AudioSource aSource = GetComponent<AudioSource>();
        aSource.Play();
        SceneManager.LoadScene("Map1"); 

    }

    public void StartMap1Part2()
    {
        AudioSource aSource = GetComponent<AudioSource>();
        aSource.Play();
        SceneManager.LoadScene("Map1.2");
    }

    public void StartMap1Part3()
    {
        AudioSource aSource = GetComponent<AudioSource>();
        aSource.Play();
        SceneManager.LoadScene("Map1.3");
    }

    public void StartMap2()
    {
        AudioSource aSource = GetComponent<AudioSource>();
        aSource.Play();
        SceneManager.LoadScene("Map2");
    }

    public void StartMap2Part2()
    {
        AudioSource aSource = GetComponent<AudioSource>();
        aSource.Play();
        SceneManager.LoadScene("Map2.2");
    }

    public void StartMap2Part3()
    {
        AudioSource aSource = GetComponent<AudioSource>();
        aSource.Play();
        SceneManager.LoadScene("Map2.3");
    }

    public void StartMap3()
    {
        AudioSource aSource = GetComponent<AudioSource>();
        aSource.Play();
        SceneManager.LoadScene("Map3");
    }

    public void StartMap3Part2()
    {
        AudioSource aSource = GetComponent<AudioSource>();
        aSource.Play();
        SceneManager.LoadScene("Map3.2");
    }

    public void StartMap3Part3()
    {
        AudioSource aSource = GetComponent<AudioSource>();
        aSource.Play();
        SceneManager.LoadScene("Map3.3");
    }

    public void ExitGame()
    {
        AudioSource aSource = GetComponent<AudioSource>();
        aSource.Play();
        Application.Quit();

    }

    public void GoMainMenu()
    {
        AudioSource aSource = GetComponent<AudioSource>();
        aSource.Play();
        SceneManager.LoadScene("MainMenu");

    }


    public void goSettingsMenu()
    {
        AudioSource aSource = GetComponent<AudioSource>();
        aSource.Play();
        SceneManager.LoadScene("SettingsMenu");

    }

    public void goLevelMenu()
    {
        AudioSource aSource = GetComponent<AudioSource>();
        aSource.Play();
        SceneManager.LoadScene("LevelMenu");

    }

    public void goCutscene()
    {
        AudioSource aSource = GetComponent<AudioSource>();
        aSource.Play();
        SceneManager.LoadScene("Cutscene");

    }

    public void goCutscene1()
    {
        AudioSource aSource = GetComponent<AudioSource>();
        aSource.Play();
        SceneManager.LoadScene("CutScene1");

    }

    public void goCutscene2()
    {
        AudioSource aSource = GetComponent<AudioSource>();
        aSource.Play();
        SceneManager.LoadScene("CutScene2");

    }

    public void goCutscene3()
    {
        AudioSource aSource = GetComponent<AudioSource>();
        aSource.Play();
        SceneManager.LoadScene("CutScene3");

    }

    public void goCutscene4()
    {
        AudioSource aSource = GetComponent<AudioSource>();
        aSource.Play();
        SceneManager.LoadScene("CutScene4");

    }

    public void goCutscene5()
    {
        AudioSource aSource = GetComponent<AudioSource>();
        aSource.Play();
        SceneManager.LoadScene("CutScene5");

    }

    public void goCutscene6()
    {
        AudioSource aSource = GetComponent<AudioSource>();
        aSource.Play();
        SceneManager.LoadScene("CutScene6");

    }

    public void goCutscene7()
    {
        AudioSource aSource = GetComponent<AudioSource>();
        aSource.Play();
        SceneManager.LoadScene("CutScene7");

    }

    public void goCutscene8()
    {
        AudioSource aSource = GetComponent<AudioSource>();
        aSource.Play();
        SceneManager.LoadScene("CutScene8");

    }

    public void goCutscene9()
    {
        AudioSource aSource = GetComponent<AudioSource>();
        aSource.Play();
        SceneManager.LoadScene("CutScene9");

    }

    public void goCutscene10()
    {
        AudioSource aSource = GetComponent<AudioSource>();
        aSource.Play();
        SceneManager.LoadScene("CutScene10");

    }

    public void goCutscene11()
    {
        AudioSource aSource = GetComponent<AudioSource>();
        aSource.Play();
        SceneManager.LoadScene("CutScene11");

    }

    public void goCutscene12()
    {
        AudioSource aSource = GetComponent<AudioSource>();
        aSource.Play();
        SceneManager.LoadScene("CutScene12");

    }

    public void goCutscene13()
    {
        AudioSource aSource = GetComponent<AudioSource>();
        aSource.Play();
        SceneManager.LoadScene("CutScene13");

    }


    public void goCutsceneLose1()
    {
        AudioSource aSource = GetComponent<AudioSource>();
        aSource.Play();
        SceneManager.LoadScene("CutsceneLose1");

    }

    public void goCutsceneLose2()
    {
        AudioSource aSource = GetComponent<AudioSource>();
        aSource.Play();
        SceneManager.LoadScene("Cutscenelose2");
    }

    public void goCutsceneLose3()
    {
        AudioSource aSource = GetComponent<AudioSource>();
        aSource.Play();
        SceneManager.LoadScene("CutsceneLose3");
    }



}
