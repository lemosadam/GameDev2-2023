using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public int score;
    public TMP_Text scoreText;
    public TMP_Text gameOver;
    public bool gameIsOver;
    public Character character;
    public Button mainMenu;
    public TMP_Text youWin;
    // Start is called before the first frame update
    void Start()
    {
        
        score = 0;
        gameIsOver = false;
        gameOver.gameObject.SetActive(false);
        mainMenu.gameObject.SetActive(false);
        youWin.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
        if(gameIsOver == true)
        {
            EndGame();
        }

        if(score == 351)
        {
            PlayerWins();
        }
    }

    void BackToMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

   public void EndGame()
    {
        gameOver.gameObject.SetActive(true);
        mainMenu.gameObject.SetActive(true);
        character.speed = 0f;
    }

    public void PlayerWins()
    {
        youWin.gameObject.SetActive(true);
        mainMenu.gameObject.SetActive(true);
        character.speed = 0f;
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
