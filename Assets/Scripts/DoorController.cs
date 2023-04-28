using UnityEngine;

public class DoorController : MonoBehaviour
{
    public GameObject Door;
    public GameObject DoorNotion;

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown("e"))
            Door.GetComponent<Animator>().Play("DoorOpenAnimation");
    }

    private void OnTriggerEnter(Collider other)
    {
        DoorNotion.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        DoorNotion.SetActive(false);
    }
}
