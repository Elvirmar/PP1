using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class Settings : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI pauseText;
    public TextMeshProUGUI movementText;
    public TextMeshProUGUI gameOverText;
    public Button restartButton;
            

    public bool gameIsActive = true;
    public bool gameIsEnded = false;

    private int score;
    private float spawnRate = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f;
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
        if (Input.GetKeyDown(KeyCode.Escape) && gameIsActive && !gameIsEnded )
        {
            Time.timeScale = 0.0f;
            gameIsActive = false;
            pauseText.gameObject.SetActive(true);


        }
        else if (Input.GetKeyDown(KeyCode.Escape) && !gameIsActive && !gameIsEnded )
        {
            Time.timeScale = 1.0f;
            gameIsActive = true;
            pauseText.gameObject.SetActive(false);
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
        }
    
    public void RestartGame()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);
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


}
