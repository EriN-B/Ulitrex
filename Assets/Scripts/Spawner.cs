using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    public GameObject[] obstacles;
    public List<GameObject> obstacletospawn = new List<GameObject>();
    private int index;
    private void Awake()
    {
        initobstacles();
    }

    private void Start()
    {
        StartCoroutine(SpawnRandomobstacle());
    }

    void initobstacles()
    {
        index = 0;
        for (int i = 0; i < obstacles.Length; i++)
        {
            GameObject obj = Instantiate(obstacles[index], transform.position, Quaternion.identity);
            obstacletospawn.Add(obj);
            obstacletospawn[i].SetActive(false);
            index++;

            if (index == obstacles.Length)
            {
                index = 0;
            }
        }
    }

    IEnumerator SpawnRandomobstacle()
    {
        yield return new WaitForSeconds(Random.Range(10f, 20f));

        index = Random.Range(0, obstacletospawn.Count);

        while (true)
        {
            if (!obstacletospawn[index].activeInHierarchy)
            {
                obstacletospawn[index].SetActive(true);
            }
            else
            {
                index = Random.Range(0, obstacletospawn.Count);
            }
        }
    }
}