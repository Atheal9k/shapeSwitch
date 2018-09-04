using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public bool gameHasEnded = false;
    public float restartDelay = 4f;

    public GameObject leftButton;
    public GameObject rightButton;

    public void GameOver()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            LevelHasEnded();
            Debug.Log("game over");
            Invoke("Restart", restartDelay);
        }

    }

    public void LevelHasEnded()
    {
        leftButton.SetActive(false);
        rightButton.SetActive(false);
        

    }

    void Restart()
    {
       
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
