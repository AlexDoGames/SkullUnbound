using UnityEngine;

public class DoorController : MonoBehaviour
{
    public GameObject WoodenDoor;
    public GameObject Notion;

    private void Start()
    {
        Notion.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown("e"))
        {
            WoodenDoor.GetComponent<Animator>().Play("DoorOpenAnimation");
        }         
    }

    private void OnTriggerEnter(Collider other)
    {
        Notion.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        Notion.SetActive(false);
    }
}
