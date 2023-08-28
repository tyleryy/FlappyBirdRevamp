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
    public GameObject pipes; // Pipe GameObject (GameObjects are templates/classes to create objects from)

    [ContextMenu("Increase Score")] // creates function that can be manually called in Unity editor
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    // Restart Scene and start Pipe Spawner again
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        pipes.GetComponent<PipeSpawnScript>().startPipes();
    }

    // display Game Over UI and stop pipes from moving and spawning
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        pipes.GetComponent<PipeSpawnScript>().stopPipes();
    }
}
