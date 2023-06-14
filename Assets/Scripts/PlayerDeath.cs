using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public GameObject YouLoose;
    public UnityEngine.Object SkullHit;
    public GameObject Skull;

    private void Start()
    {
        SkullHit = Resources.Load("SkullHit");
        YouLoose.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DeathTrigger"))
        {
            PlayerKill();          
        }
    }

    private void PlayerKill()
    {
        GameObject skullHitRef = (GameObject)Instantiate(SkullHit);
        skullHitRef.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Skull.SetActive(false);
        YouLoose.SetActive(true);
    }
}
