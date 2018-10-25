using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour {

    Vector3[] corners = new Vector3[4];

    private void Start()
    {
        transform.parent.GetComponent<RectTransform>().GetLocalCorners(corners);
        Vector3 spawnCorner = corners[Random.Range(0, 4)];
        transform.localPosition = spawnCorner;
    }

    public void DestroyAd () {
        Destroy(transform.parent.gameObject);
	}
}
