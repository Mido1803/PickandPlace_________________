using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class MenuController : MonoBehaviour
{

    [Header("Levels To Load")]
    public string _newGameLevel; 
    public string _newGameLevel1; 
    public string _newGameLevel2;

    public void ARdialogYES()
    {
        
        SceneManager.LoadScene(_newGameLevel);
    }

    public void VRdialogYES()
    {
        
        SceneManager.LoadScene(_newGameLevel1);
    }

    public void EXITdialogYES()
    {
        Application.Quit();
    }

    public void BackToMenuYes()
    {
        SceneManager.LoadScene(_newGameLevel2);
    }

}

