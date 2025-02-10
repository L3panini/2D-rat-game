using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public GameObject spawnObject;
    public GameObject[] spawnPoints;
    public float timer;
    public float timeBetweenSpawns;

    public float speedMultiplier;
    // start is called before the first frame update
    void Start()
    {

    }

    // update is called once per frame
    void Update()
    {
        speedMultiplier += Time.deltaTime * 0.1f;

        timer += Time.deltaTime;

        if (timer > timeBetweenSpawns)
        {
            timer = -1;
            int randNum = Random.Range(0, spawnPoints.Length);
            Instantiate(spawnObject, spawnPoints[randNum].transform.position, Quaternion.identity);
        }
    }
}
