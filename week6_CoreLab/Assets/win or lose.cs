using UnityEngine;
using UnityEngine.SceneManagement;

public class winorlose : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void goStart()
    {
        print("start");
        SceneManager.LoadScene("startingScreen");
    }
    public void goWin()
    {
        print("win");
        SceneManager.LoadScene("win");
    }
    public void goLose()
    {
        print("lose");
        SceneManager.LoadScene("lose");
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("goInside"))
        {
            SceneManager.LoadScene("Game");
        }
    }

}
