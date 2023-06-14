using UnityEngine;

public class YouWinPanel : MonoBehaviour
{
    public GameObject YouWinText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            YouWinText.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
