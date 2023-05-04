using UnityEngine;

public class DoorController : MonoBehaviour
{
    private GameObject woodenDoor;
    private GameObject notion;

    private void Start()
    {
        woodenDoor = GameObject.Find("WoodenDoor");
        notion = GameObject.Find("Notion");
        notion.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown("e"))
        {
            woodenDoor.GetComponent<Animator>().Play("DoorOpenAnimation");
        }         
    }

    private void OnTriggerEnter(Collider other)
    {
        notion.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        notion.SetActive(false);
    }
}
