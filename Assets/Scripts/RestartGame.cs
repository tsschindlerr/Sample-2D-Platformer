using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public void LoadCurrentScene()
    {
        SceneManager.LoadScene("GameScene");
        Time.timeScale = 1;
    }
}
