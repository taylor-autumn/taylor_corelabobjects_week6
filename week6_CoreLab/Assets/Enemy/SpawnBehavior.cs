using TMPro;
using UnityEngine;
using UnityEngine.Rendering.Universal.Internal;
using System.Collections;

public class SpawnBehavior : MonoBehaviour
{
    public GameObject enemyPrefab;
    private Vector2 spawnerPos;

    private float xOffset;
    private float yOffset;

    public float topAmount;
    public float bottomAmount;
    public float leftAmount;
    public float rightAmount;

    public int spawnAmount = 5;
    public bool beginSpawning = false;
    public int spawnStart = 0;
    public buttonMovement buttonRef;
    public Player playerRef;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnerPos = transform.position;
        //spawnEnemies();

    }

    // Update is called once per frame
    void Update()
    {
        
        spawnEnemies(); //for some reason only works all 3 times if I put this here
        if (beginSpawning)
        {
            spawnEnemies();
            spawnStart = 1;
            
        }
        if (spawnStart == 1)
        {
            beginSpawning = false;
            playerRef.levelCount -= 1;
            playerRef.levelCountText.text = playerRef.levelCount.ToString();
            buttonRef.enemySpawn.SetActive(false);
            

        }

    }

    public void spawnEnemies() 
    {
        
        for ( int i = 0; i < spawnAmount; i++ ) 
        {
            xOffset = Random.Range(leftAmount, rightAmount);
            yOffset = Random.Range(topAmount, bottomAmount);

            Vector2 newSpawnEnemyPos= new Vector2(spawnerPos.x + xOffset, spawnerPos.y + yOffset);

            GameObject spawnedEnemy = Instantiate( enemyPrefab, newSpawnEnemyPos, Quaternion.identity);
        }
    }


}
