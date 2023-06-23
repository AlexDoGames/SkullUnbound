using UnityEngine.SceneManagement;
using UnityEngine;

public class OpenNextLevel : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            UnlockLevel();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void UnlockLevel()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;

        if (currentLevel > PlayerPrefs.GetInt("Levels"))
        {
            PlayerPrefs.SetInt("Levels", currentLevel);
        }
    }
}
