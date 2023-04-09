using JetBrains.Annotations;
using Newtonsoft.Json.Bson;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class pauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUi;
    public GameObject pauseButton;
    public GameObject inventoryButton;
    public GameObject inventoryPannelUI;
    
    

    public void Pause()
    {
        pauseMenuUi.SetActive(true);
        pauseButton.SetActive(false);
        inventoryButton.SetActive(false);
        inventoryPannelUI.SetActive(false);

        Time.timeScale = 0f;
    }
    public void Resume()
    {
        pauseMenuUi.SetActive(false);
        pauseButton.SetActive(true);
        inventoryButton.SetActive(true);
        inventoryPannelUI.SetActive(false);
        Time.timeScale = 1f;
    }
    public void inventoryActive()
    {
        pauseMenuUi.SetActive(false);
        pauseButton.SetActive(false);
        inventoryButton.SetActive(false);
        inventoryPannelUI.SetActive(true);
        Time.timeScale = 0f;
    }

  
   

}
