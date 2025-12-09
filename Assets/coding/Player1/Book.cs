using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour
{
    public GameObject bookCanvas;

    private void OnMouseDown()
    {
        bookCanvas.SetActive(true);
    }
}
