using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameOverScreen : MonoBehaviour
{
    public GameObject gameOverMenu;

    private void OnEnable()
    {
        PlayerHP.OnPlayerDeath += EnableGameOverMenu;
    }
    private void OnDisable()
    {
        PlayerHP.OnPlayerDeath -= EnableGameOverMenu;
    }
    public void EnableGameOverMenu()
    {
        gameOverMenu.SetActive(true);
    }

    public void Setup(int score)
    {
        gameObject.SetActive(true);
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("Ufogame");
    }

    public void ExitButton()
    {
        SceneManager.LoadScene("MainMenu");


    }
}