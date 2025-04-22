using UnityEngine;
using UnityEngine.SceneManagement; // ������ ��������
using UnityEngine.UI; // ������ �������

public class GameManager : MonoBehaviour
{
    public GameObject winPanel;
    public GameObject losePanel;

    private bool gameEnded = false;

    public void WinGame()
    {
        if (gameEnded) return;
        gameEnded = true;

        winPanel.SetActive(true);
        Time.timeScale = 0f; // ����� ����� (�������)
    }

    public void LoseGame()
    {
        if (gameEnded) return;
        gameEnded = true;

        losePanel.SetActive(true);
        Time.timeScale = 0f; // ����� ����� (�������)
    }

    public void Retry()
    {
        Time.timeScale = 1f; // ����� ����� ����� �������
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
