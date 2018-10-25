using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnAds : MonoBehaviour {

    public GameObject[] ads;
    public float timeBtwSpawn = 1f;
    public float elapsedTime = 0f;
    public Vector2 spawnLocationRange = new Vector2()

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
        Instantiate(ad, Vector3.zero, Quaternion.identity);
        }
    }
