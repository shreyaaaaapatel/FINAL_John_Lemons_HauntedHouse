using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public GameObject pauseMenuUI;

    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
                Resume();
            else
                Pause();
        }
    }

    public void Resume()
    {
        Debug.Log("Resume Button Clicked!");
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;     // unfreeze the game
        isPaused = false;
    }

    public void Pause()
    {
        Debug.Log("Pause Button Clicked!");
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;     // freeze the game
        isPaused = true;
    }

    public void QuitGame()
    {
        Debug.Log("Quit Button Clicked!");
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}