using UnityEngine;

public class WallController : MonoBehaviour
{
    private GameObject wall;
    private GameObject wallNotion;

    private void Start()
    {
        wall = GetComponent<GameObject>();
        wallNotion = GetComponent<GameObject>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown("e"))
            wall.GetComponent<Animator>().Play("WallAnimation");
    }

    private void OnTriggerEnter(Collider other)
    {
        wallNotion.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        wallNotion.SetActive(false);
    }
}
