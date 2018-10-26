using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour {

    Vector3[] corners = new Vector3[4];
    Vector3[] worldCorners = new Vector3[4];
    RectTransform rtra;
    RectTransform pRtra;
    RectTransform canvasRtra;

    private void Start()
    {
        canvasRtra = GameObject.FindGameObjectWithTag("Canvas").GetComponent<RectTransform>();
        pRtra = transform.parent.GetComponent<RectTransform>();
        pRtra.GetLocalCorners(corners);

        spawnCorner(corners);
    }

    void spawnCorner(Vector3[] corners)
    {
        Vector3 corner = corners[Random.Range(0, 3)];
        transform.localPosition = corner;

        if (canvasRtra.rect.Contains(canvasRtra.InverseTransformPoint(transform.position)) == false)
        {
            spawnCorner(corners);
        }
    }

    public void DestroyAd () {
        Destroy(transform.parent.gameObject);
	}
}
