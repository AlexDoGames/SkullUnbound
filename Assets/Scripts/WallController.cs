using UnityEngine;

public class WallController : MonoBehaviour
{
    private GameObject wall;
    private GameObject notion;

    private void Start()
    {
        wall = GameObject.Find("MovingWall");
        notion = GameObject.Find("Notion");
        notion.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown("e"))
            wall.GetComponent<Animator>().Play("WallAnimation");
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
