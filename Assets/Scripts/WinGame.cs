using UnityEngine;

public class WinGame : MonoBehaviour
{
    public GameObject WinPanel;
    public int score;

    private void OnEnable()
    {
        PointManager.OnPlayerWin += EnableWinPanel;
    }
    private void OnDisable()
    {
        PointManager.OnPlayerWin -= EnableWinPanel;
    }
    public void EnableWinPanel()
    {

        WinPanel.SetActive(true);

    }

    public void Setup(int score)
    {
        gameObject.SetActive(true);
    }
}
