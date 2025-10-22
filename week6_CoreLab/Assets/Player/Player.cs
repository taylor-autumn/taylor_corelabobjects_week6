using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Player : MonoBehaviour
{
    public float speed;
    public Animator runningAnimator;
    public int playerMaxHealth = 15;
    public int playerCurrentHealth;
    public healthBarScript healthBar;
    public SpawnBehavior spawnRef;
    public int levelCount = 3;
    public TMP_Text levelCountText;
    public winorlose winLoseRef;

    // Start is called before the first frame update
    void Start()
    {
        runningAnimator.SetBool("idleOn", true);
        playerCurrentHealth=playerMaxHealth;
        healthBar.setStartHealth(playerMaxHealth);
    }

    // Update is called once per frame
    void Update()
    {

        if (levelCount == 0)
        {
            StartCoroutine(waitToWin());
        }

        //changing to running animations
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {
            transform.position += new Vector3(0, speed, 0) * Time.deltaTime;
            runningAnimator.SetBool("idleOn", false);
            runningAnimator.SetBool("runUp",true);

}
        
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) {
            transform.position += new Vector3(0, -speed, 0) * Time.deltaTime;
            runningAnimator.SetBool("idleOn", false);
            runningAnimator.SetBool("runDown", true);
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
            transform.position += new Vector3(-speed, 0, 0) * Time.deltaTime;
            runningAnimator.SetBool("idleOn", false);
            runningAnimator.SetBool("runLeft", true);
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
            transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
            runningAnimator.SetBool("idleOn", false);
            runningAnimator.SetBool("runRight", true);
        }
        //keys up back to idle
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.UpArrow)){
            runningAnimator.SetBool("idleOn", true);
            runningAnimator.SetBool("runUp", false);
        }
        if (Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.DownArrow))
        {
            runningAnimator.SetBool("idleOn", true);
            runningAnimator.SetBool("runDown", false);
        }
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            runningAnimator.SetBool("idleOn", true);
            runningAnimator.SetBool("runLeft", false);
        }
        if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            runningAnimator.SetBool("idleOn", true);
            runningAnimator.SetBool("runRight", false);
        }

        if (playerCurrentHealth == 0)
        {
            winLoseRef.goLose();
        }

        //print("Idle Status: " + runningAnimator.GetBool("idleOn"));
        //print("Up Status: " + runningAnimator.GetBool("runUp"));
        //print("Down Status: " + runningAnimator.GetBool("runDown"));
        //print("Left Status: " + runningAnimator.GetBool("runLeft"));
        //print("Right Status: " + runningAnimator.GetBool("runRight"));

    }

    public IEnumerator waitToWin()
    {
        //yield return null;
        print("started counting");
        yield return new WaitForSeconds(15);
        winLoseRef.goWin();

    }
}
