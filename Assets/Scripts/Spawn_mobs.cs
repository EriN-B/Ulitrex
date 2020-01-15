using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawn_mobs : MonoBehaviour
{
    public GameObject[] obstacles;
    public List<GameObject> obstaclestospawn = new List<GameObject>();

    private int index;
    // Start is called before the first frame update
    void Awake()
    {
        initobstacles();
    }

    void Start()
    {
        StartCoroutine(SpawnRandomObstacle());
    }

    // Update is called once per frame
    void initobstacles()
    {
        index = 0;
        for (var i = 0; i < obstacles.Length; i++)
        {
            GameObject obj = Instantiate(obstacles[index], transform.position, Quaternion.identity);
            obstaclestospawn.Add(obj);
            obstaclestospawn[i].SetActive(false);
            index++;

            if (index == obstacles.Length)
            {
                index = 0;
            }
        }
    }

    IEnumerator SpawnRandomObstacle()
    {
        
        yield return new WaitForSeconds(Random.Range(1f,2f));
        var index1 = Random.Range(0, obstaclestospawn.Count);

        while (true)
        {
            if (!obstaclestospawn[index1].activeInHierarchy)
            {
                obstacles[index1].SetActive(true);
                break;
            }
            else
            {
                index1 = Random.Range(0, obstaclestospawn.Count);
            }
        }
    }
}
