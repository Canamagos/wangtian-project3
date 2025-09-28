using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoFrame : MonoBehaviour
{
    public GameObject photoCanvas;

    private void OnMouseDown()
    {
        photoCanvas.SetActive(true);
    }
}
