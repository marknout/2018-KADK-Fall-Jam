using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawnAdsCanvas : MonoBehaviour {

    public Sprite[] adSprites;
    public float minimumTimeBetweenSpawns = 1f;
    public float maximumTimeBetweenSpawns = 1f;
    float timeBtwSpawn;
    public float elapsedTime = 0f;
    public Vector2 spawnLocationRange = new Vector2(0f, 0f);
    public GameObject spawner;
    public GameObject closeButton;
    public GameObject adImagePrefab;

    void Start()
    {
        spawner = GameObject.FindGameObjectWithTag("Spawner");
        adSprites = Resources.LoadAll<Sprite>("AdSprites"); 
        timeBtwSpawn = Random.Range(minimumTimeBetweenSpawns, maximumTimeBetweenSpawns);
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime >= timeBtwSpawn)
        {
            elapsedTime = 0;
            spawnAd();
            timeBtwSpawn = Random.Range(minimumTimeBetweenSpawns, maximumTimeBetweenSpawns);
        }
    }

    void spawnAd()
    {
        Sprite adSprite = adSprites[Random.Range(0, adSprites.Length)];
        Vector2 adSize = adSprite.bounds.extents * adSprite.pixelsPerUnit;

        float spawnLocX = spawnLocationRange.x * adSprite.pixelsPerUnit;
        float spawnLocY = spawnLocationRange.y * adSprite.pixelsPerUnit;

        Vector3 spawnLocation = new Vector3(Random.Range(-spawnLocX, spawnLocX), Random.Range(-spawnLocY, spawnLocY), 0f);
        var newAd = Instantiate(adImagePrefab, spawner.transform.position + spawnLocation * adSprite.pixelsPerUnit, Quaternion.identity, spawner.transform); // check why this doesn't work, it sucks.
        newAd.GetComponent<Image>().sprite = adSprite;
        newAd.GetComponent<RectTransform>().sizeDelta = adSize;

        //var button = Instantiate(closeButton, newAd.transform.position + randomCorner(newAd), Quaternion.identity, newAd.transform);
    }

    Vector3 randomCorner(GameObject ad)
    {
        Vector3[] corners = new Vector3[4];
        ad.GetComponent<RectTransform>().GetLocalCorners(corners);
        var q = corners[Random.Range(0, corners.Length)]; Debug.Log(q);
        return q;
    }
}
