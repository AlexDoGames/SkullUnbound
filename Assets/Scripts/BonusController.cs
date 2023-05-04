using UnityEngine;

public class BonusController : MonoBehaviour
{
    private GameObject batwingEyeball;

    private void Start()
    {
        batwingEyeball = GetComponent<GameObject>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
