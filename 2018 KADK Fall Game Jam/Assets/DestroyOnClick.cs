using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyOnClick : MonoBehaviour {

    private void OnMouseDown()
    {
        Destroy(transform.parent.gameObject);
    }

}
