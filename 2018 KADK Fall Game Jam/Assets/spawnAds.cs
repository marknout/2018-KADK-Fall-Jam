using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnAds : MonoBehaviour {

    public GameObject[] ads;
    public float timeBtwSpawn = 1f;
    public float elapsedTime = 0f;
    public Vector2 spawnLocationRange = new Vector2(0f, 0f);
    public GameObject spawner;

    void Start()
    {
        spawner = GameObject.FindGameObjectWithTag("Spawner");
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime > timeBtwSpawn)
        {
            elapsedTime = 0;
            spawnAd(ads[Random.Range(0, ads.Length)]);
        }
    }

    void spawnAd (GameObject ad) {
        Vector3 spawnLocation = new Vector3(Random.Range(-spawnLocationRange.x, spawnLocationRange.x), Random.Range(-spawnLocationRange.y, spawnLocationRange.y), 0f);
        Instantiate(ad, spawnLocation, Quaternion.identity, spawner.transform);
        }
    }
