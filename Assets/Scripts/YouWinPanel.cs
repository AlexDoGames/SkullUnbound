using UnityEngine;

public class YouWinPanel : MonoBehaviour
{
    public GameObject YouWinMessage;

    private void OnTriggerEnter(Collider other)
    {
        YouWinMessage.SetActive(true);
        Time.timeScale = 0f;
    }
}
