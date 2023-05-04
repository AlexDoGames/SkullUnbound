using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class ChooseLevel : MonoBehaviour
{
    private int levelUnlock;
    private Button[] buttons;

    private void Start()
    {
        levelUnlock = PlayerPrefs.GetInt("Levels", 1);
        for(int i = 0; i  <buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }
        for (int i = 0; i < levelUnlock; i++)
        {
            buttons[i].interactable = true;
        }
    }

    public void LoadLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }
}
