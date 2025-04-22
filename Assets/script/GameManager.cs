using UnityEngine;
using UnityEngine.SceneManagement; // ·· Õﬂ„ »«·„‘«Âœ
using UnityEngine.UI; // ··Ê’Ê· ··√“—«—

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
        Time.timeScale = 0f; // ≈Ìﬁ«› «·“„‰ («Œ Ì«—Ì)
    }

    public void LoseGame()
    {
        if (gameEnded) return;
        gameEnded = true;

        losePanel.SetActive(true);
        Time.timeScale = 0f; // ≈Ìﬁ«› «·“„‰ («Œ Ì«—Ì)
    }

    public void Retry()
    {
        Time.timeScale = 1f; // ≈⁄«œ… «·“„‰ ··Ê÷⁄ «·ÿ»Ì⁄Ì
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
