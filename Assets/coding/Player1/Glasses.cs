using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glasses : MonoBehaviour
{
    public GameObject canvas;
    public GameObject glasses;

    private void OnMouseDown()
    {
        canvas.SetActive(true);
        glasses.SetActive(true);
    }
}
