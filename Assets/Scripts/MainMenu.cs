using UnityEngine;

using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // K�ynistett�v�n Scene
    public string startLevel;
    public void NewGame()
    {

        // Aloitetaan uusi peli
        SceneManager.LoadScene(startLevel);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}