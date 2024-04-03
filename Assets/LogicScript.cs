using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public Text TextScore;
    public int playerscore;
    public GameObject GameOverScreen;

    public void addscore() 
    {
        playerscore= playerscore+1;
        TextScore.text=playerscore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void GameOver() { 
    
        GameOverScreen.SetActive(true);
    }
}
