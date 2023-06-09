using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using Unity.VisualScripting;

public class Settings : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI pauseText;
    public TextMeshProUGUI movementText;
    public TextMeshProUGUI gameOverText;
    public Button restartButton;
    public Button goBackToMenuButton;
    private int menuSceneNumber = 0;
    private int menuSettingsSceneNumber = 2;
    private int menuCreditsSceneNumber = 1;
    private int gameSceneNumber = 3;



    public bool gameIsActive = false;
    public bool gameIsEnded = true;

    private int score;
    private float spawnRate = 1.0f;

    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    

    // Update is called once per frame
    void Update()

    {
        
        PauseGame();
        TurnOffText();
          
    }

    // Pause the Game by ESC
    
    public void PauseGame()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && gameIsActive && !gameIsEnded && SceneManager.GetActiveScene().buildIndex == gameSceneNumber)
        {
            Time.timeScale = 0.0f;
            gameIsActive = false;
            pauseText.gameObject.SetActive(true);
            goBackToMenuButton.gameObject.SetActive(true);


        }
        else if (Input.GetKeyDown(KeyCode.Tab) && !gameIsActive && !gameIsEnded && SceneManager.GetActiveScene().buildIndex == gameSceneNumber)
        {
            Time.timeScale = 1.0f;
            gameIsActive = true;
            pauseText.gameObject.SetActive(false);
            goBackToMenuButton.gameObject.SetActive(false);
        }
            
    }

    // Game is over when collide with enemy

    public void EndGame()
               
        {

            Time.timeScale = 0.0f;
            gameIsActive = false;
            gameIsEnded = true; 
            
            restartButton.gameObject.SetActive(true);
            gameOverText.gameObject.SetActive(true);
            goBackToMenuButton.gameObject.SetActive(true);

    }
    
    public void RestartGame()
    {
        Time.timeScale = 1.0f;
        gameIsActive = true;
        gameIsEnded = false;
        SceneManager.LoadScene(gameSceneNumber);
    }

    public void TurnOffText()
    {
        if(Time.timeScale == 0.0f)
        {
            movementText.gameObject.SetActive(false);
        }
        else if (Time.timeScale == 1.0f)
        {
            movementText.gameObject.SetActive(true);
        }
    }
    //load start menu 

    public void StartGame()
    
    {
        if (SceneManager.GetActiveScene().buildIndex != 0)
        {
            SceneManager.LoadScene(0);
        }
    }

    //load game scene

    public void StartPlay()
    {

        Time.timeScale = 1.0f;
        gameIsActive = true;
        gameIsEnded = false;
        SceneManager.LoadScene(gameSceneNumber);
        
    }

    //load settings scene
    public void MoveToSettings()
    {
        SceneManager.LoadScene(menuSettingsSceneNumber);
    }

    //load credits scene
    public void MoveTocredits()
    {
        SceneManager.LoadScene(menuCreditsSceneNumber);
    }
}
