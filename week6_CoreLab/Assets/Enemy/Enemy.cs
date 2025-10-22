using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float xSpeed;
    private float ySpeed;

    public float xMaxSpeed;
    public float yMaxSpeed;
    public float xMinSpeed;
    public float yMinSpeed;

    public AudioSource oofSound;

    //public Vector2 enemyMove;

    //public float xMove;
    //public float yMove;

    //public float minMove;
    //public float maxMove;

    //HurtSound hurtSound;

    // Start is called before the first frame update
    void Start()
    {
        xSpeed = Random.Range(xMinSpeed, xMaxSpeed);
        ySpeed = Random.Range(yMinSpeed, yMaxSpeed);
       

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(xSpeed, ySpeed,0f) * Time.deltaTime;
        Destroy(gameObject, 18);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            Player playerScript = collision.gameObject.GetComponentInParent<Player>();
            playerScript.playerCurrentHealth -= 1;
            print(playerScript.playerCurrentHealth);
            GameObject oofObj = GameObject.Find("oofSound");
            oofSound = oofObj.GetComponent<AudioSource>();
            oofSound.Play();

            GameObject healthBar = GameObject.Find("health bar");
            healthBarScript healthScript = healthBar.GetComponentInParent<healthBarScript>();
            healthScript.setHealth(playerScript.playerCurrentHealth);

            //healthBarScript healthBar=collision.gameObject.GetComponentInParent<healthBarScript>();


            //healthBar.setHealth(playerScript.playerCurrentHealth);
        }
    }

}
