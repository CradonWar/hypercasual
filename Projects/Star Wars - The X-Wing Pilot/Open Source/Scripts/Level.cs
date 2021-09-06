using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    // configuration parameters
    [SerializeField] float delayInSeconds = 5f;

    public void LoadStartMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("Game");
        FindObjectOfType<GameSession>().ResetGame();
    }

    public void LoadGameOver()
    {
        StartCoroutine(WaitAndLoad());
    }

    IEnumerator WaitAndLoad()
    {
        while (true)
        {
            yield return new WaitForSeconds(delayInSeconds);
            SceneManager.LoadScene("Game Over");
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
