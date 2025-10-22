using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.Assertions.Must;

public class buttonMovement : MonoBehaviour
{
    public Animator buttonAnimator;//This will contain a reference to that specific buttons animator.

    //public Animator leftButtonAnimation;
    //public Animator rightButtonAnimation;
    //public Animator topButtonAnimation;
    //public GameObject rightEnemySpawn;
    //public GameObject topEnemySpawn;
    public GameObject enemySpawn;
    public SpawnBehavior spawnEnemiesRef;
    public bool canBeClicked = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (canBeClicked)
        {
            if (collision.gameObject.tag == "Player")
            {

                buttonAnimator.SetBool("pressButton", true);
                StartCoroutine(resetButtonBool());
                print("I have been button pressed");
                canBeClicked = false;
                print(canBeClicked);

            }
        }
        
        //if (collision.gameObject.tag == "Player")
        //{
        //    buttonAnimator.SetBool("pressButton", true);
        //    StartCoroutine(resetButtonBoolB());


        //}
        //if (collision.gameObject.tag == "Player")
        //{
        //    buttonAnimator.SetBool("pressButton", true);
        //    StartCoroutine(resetButtonBoolC());

        //}
    }

    public void whichEnemySpawn(int enemyLeft, int enemyRight, int enemyUp)
    {
        if(enemyLeft == 1)
        {
            enemySpawn.SetActive(true);
            spawnEnemiesRef.beginSpawning = true;
        }
        //if (enemyRight == 1)
        //{
        //    rightEnemySpawn.SetActive(true);
        //}
        //if (enemyUp == 1)
        //{
        //    topEnemySpawn.SetActive(true);
        //}
    }

  

    public IEnumerator resetButtonBool()
    {
        //yield return null;
        yield return new WaitForSeconds(1);
        buttonAnimator.SetBool("pressButton", false);
        //instEnRef.StartSpawn();
        whichEnemySpawn(1, 0, 0);
    }

    //public IEnumerator resetButtonBoolB()
    //{
    //    //yield return null;
    //    yield return new WaitForSeconds(3);
    //    buttonAnimator.SetBool("pressButton", false);
    //    whichEnemySpawn(0, 1, 0);
    //}

    //public IEnumerator resetButtonBoolC()
    //{
    //    //yield return null;
    //    yield return new WaitForSeconds(3);
    //    buttonAnimator.SetBool("pressButton", false);
    //    whichEnemySpawn(0, 0, 1);
    }

