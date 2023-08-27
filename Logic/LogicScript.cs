using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // use UI GameObject functions
using UnityEngine.SceneManagement;
public class LogicScript : MonoBehaviour
{

    public int playerScore;
    public Text scoreText; // reference to Text GameObject on UI
                           // here we can configure what variables and references we want to show in Unity editor for this game Object
    public GameObject gameOverScreen;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    // GameObject
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);

    }
}
