using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject container;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            container.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void ResumeButton()
    {
        container?.SetActive(false);
        Time.timeScale = 1;
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene("");
    }
}