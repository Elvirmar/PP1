using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using Unity.VisualScripting;

public class MainMenu : MonoBehaviour
{ 

public Canvas settingCanvas;
public Canvas creditsCanvas;
public Canvas menuCanvas;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SettingMenu()
    {
        menuCanvas.gameObject.SetActive(false);
        settingCanvas.gameObject.SetActive(true);
    }

    public void CreditsMenu()
    {
        menuCanvas.gameObject.SetActive(false);
        menuCanvas.gameObject.SetActive(true);
    }
}
