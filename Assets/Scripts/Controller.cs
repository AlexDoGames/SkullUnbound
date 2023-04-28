using UnityEngine.SceneManagement;
using UnityEngine;

public class Controller : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DeathTrigger"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (other.CompareTag("Finish"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("DeathTrigger"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
