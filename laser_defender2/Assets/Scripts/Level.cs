using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    public void LoadStartMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void LoadGameOver()
    {

        StartCoroutine(WaitAndLoad());

        //SceneManager.LoadScene("Game Over");

    }

    IEnumerator WaitAndLoad()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Game Over");

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
