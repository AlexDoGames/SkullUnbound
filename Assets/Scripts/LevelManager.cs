using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private int levelUnlock;
    public Button[] Buttons;

    private void Start()
    {
        levelUnlock = PlayerPrefs.GetInt("Levels", 1);

        for (int i = 0; i < Buttons.Length; i++)
        {
            Buttons[i].interactable = false;
        }

        for (int i = 0; i < levelUnlock; i++)
        {
            Buttons[i].interactable = true;
        }
    }

    public void LoadLevel(int levelIndex)
        {
            SceneManager.LoadScene(levelIndex);
        }
}
