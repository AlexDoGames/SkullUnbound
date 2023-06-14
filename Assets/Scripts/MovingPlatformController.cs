using UnityEngine;

public class MovingPlatformController : MonoBehaviour
{
    private GameObject moving;

    private void Start()
    {
        moving = GameObject.Find("Moving");
    }

    private void OnTriggerEnter(Collider other)
    {
        moving.GetComponent<Animator>().Play("MovingPlatformAnimation");
    }
}
