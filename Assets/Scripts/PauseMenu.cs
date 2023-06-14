using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    private static bool GameIsPaused = false;
    public GameObject PMenu;

    private void Start()
    {
        Resume();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }

            else
            {
                Pause();
            }
        }
    }

    void Resume()
    {
        PMenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        PMenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}
