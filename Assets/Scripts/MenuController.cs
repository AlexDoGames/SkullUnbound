using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public void LoadLevel()
    {
        SceneManager.LoadScene("LevelsMenu");
    }
}
