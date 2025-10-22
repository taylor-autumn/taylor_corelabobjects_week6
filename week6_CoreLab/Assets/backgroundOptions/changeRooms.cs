using UnityEngine;

public class changeRooms : MonoBehaviour
{

    public GameObject mainRoom;
    public GameObject leftRoom;
    public GameObject rightRoom;
    public GameObject topRoom;
    public GameObject mainGuy;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mainRoom.SetActive(true);
        leftRoom.SetActive(false);
        rightRoom.SetActive(false);
        topRoom.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("goLeftRoom"))
        {
            leftRoom.SetActive(true);
            mainRoom.SetActive(false);
            rightRoom.SetActive(false);
            topRoom.SetActive(false);
            mainGuy.transform.position = new Vector3(8, 1, 0);
        }
        else if (collision.gameObject.CompareTag("goRightRoom"))
        {
            rightRoom.SetActive(true);
            topRoom.SetActive(false);
            leftRoom.SetActive(false);
            mainRoom.SetActive(false);
            mainGuy.transform.position = new Vector3(-7, 1, 0);
        }
        else if (collision.gameObject.CompareTag("goUpRoom"))
        {
            topRoom.SetActive(true);
            leftRoom.SetActive(false);
            mainRoom.SetActive(false);
            rightRoom.SetActive(false);
            mainGuy.transform.position = new Vector3(0.5f, -2.7f, 0);
        }
        else if (collision.gameObject.CompareTag("goDownRoom"))
        {
            mainRoom.SetActive(true);
            rightRoom.SetActive(false);
            topRoom.SetActive(false);
            leftRoom.SetActive(false);
            mainGuy.transform.position = new Vector3(0.5f, 4.7f, 0);
        }
        else if (collision.gameObject.CompareTag("goLeftToMain"))
        {
            mainRoom.SetActive(true);
            rightRoom.SetActive(false);
            topRoom.SetActive(false);
            leftRoom.SetActive(false);
            mainGuy.transform.position = new Vector3(7, 1.5f, 0);
        }
        else if (collision.gameObject.CompareTag("goRightToMain"))
        {
            mainRoom.SetActive(true);
            rightRoom.SetActive(false);
            topRoom.SetActive(false);
            leftRoom.SetActive(false);
            mainGuy.transform.position = new Vector3(-7, 1.5f, 0);
        }

    }

}
