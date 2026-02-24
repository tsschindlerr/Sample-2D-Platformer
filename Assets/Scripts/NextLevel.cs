using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public string nextLevelName;
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(nextLevelName);
        Time.timeScale = 1;
    }
}