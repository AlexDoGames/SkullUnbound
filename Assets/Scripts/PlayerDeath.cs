using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public GameObject YouLoose;
    private UnityEngine.Object skullHit;
    public GameObject Skull;

    private void Start()
    {
        skullHit = Resources.Load("SkullHit");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DeathTrigger"))
        {
            PlayerKill();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("DeathTrigger"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void PlayerKill()
    {
        GameObject skullHitRef = (GameObject)Instantiate(skullHit);
        skullHitRef.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Skull.SetActive(false);
        Time.timeScale = 0f;
        Instantiate(YouLoose, new Vector3(400, 180, 0), Quaternion.identity);
    }
}
