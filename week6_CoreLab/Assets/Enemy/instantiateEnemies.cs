using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UIElements;

public class instantiateEnemies : MonoBehaviour
{
    public GameObject enemyPrefabLeft;
    public GameObject enemyPrefabRight;
    public GameObject enemyPrefabTop;
    public GameObject enemyPrefabBottom;
    private int spawnNumber = 6;
    public List<GameObject> enemyTopList;
    public List<GameObject> enemyLeftList;
    public List<GameObject> enemyRightList;
    public List<GameObject> enemyBottomList;
    private float Xposition;
    private float Yposition;
    public int countOffScreen = 0;
    public bool spawnNow = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        for (int i = 0; i < spawnNumber; i++)
        {
            enemyTopList.Add(GameObject.Instantiate(enemyPrefabTop));
            enemyLeftList.Add(GameObject.Instantiate(enemyPrefabLeft));
            enemyRightList.Add(GameObject.Instantiate(enemyPrefabRight));
            enemyBottomList.Add(GameObject.Instantiate(enemyPrefabBottom));
        }

        spawnEnemies();
    }

    // Update is called once per frame
    void Update()
    {

            foreach (GameObject enemy in enemyTopList)
            {

                if (enemy.transform.position.y < -10)
                {
                    enemy.SetActive(false);
                }
            }
        foreach (GameObject enemy in enemyBottomList)
        {

            if (enemy.transform.position.y > 10)
            {
                enemy.SetActive(false);
            }
        }
        foreach (GameObject enemy in enemyLeftList)
        {

            if (enemy.transform.position.x > 13)
            {
                enemy.SetActive(false);
            }
        }
        foreach (GameObject enemy in enemyRightList)
        {

            if (enemy.transform.position.x < -13)
            {
                enemy.SetActive(false);
            }
        }

    }

    //public void StartSpawn() 
    //{
    //    spawnNow = true;
    //}

    public void spawnEnemies()
    {
        //for (int i = 0; i < spawnNumber; i++)
        //{
        //    enemyTopList.Add(GameObject.Instantiate(enemyPrefabTop));
        //    enemyLeftList.Add(GameObject.Instantiate(enemyPrefabLeft));
        //    enemyRightList.Add(GameObject.Instantiate(enemyPrefabRight));
        //    enemyBottomList.Add(GameObject.Instantiate(enemyPrefabBottom));
        //    spawnNow = false;
        //}

        foreach (GameObject enemy in enemyTopList)
        {
            Xposition = Random.Range(-8, 9);
            Yposition = Random.Range(7, 20);

            Vector2 randomPosition = new Vector2(Xposition, Yposition);
            enemy.transform.position = randomPosition;

        }

        foreach (GameObject enemy in enemyLeftList)
        {
            Xposition = Random.Range(-11, -30);
            Yposition = Random.Range(-3, 5);

            Vector2 randomPosition = new Vector2(Xposition, Yposition);
            enemy.transform.position = randomPosition;

        }

        foreach (GameObject enemy in enemyRightList)
        {
            Xposition = Random.Range(11, 30);
            Yposition = Random.Range(-3, 5);

            Vector2 randomPosition = new Vector2(Xposition, Yposition);
            enemy.transform.position = randomPosition;

        }

        foreach (GameObject enemy in enemyBottomList)
        {
            Xposition = Random.Range(-8, 9);
            Yposition = Random.Range(-7, -20);
            
            Vector2 randomPosition=new Vector2 (Xposition,Yposition);
            enemy.transform.position = randomPosition;

        }
    }

}
