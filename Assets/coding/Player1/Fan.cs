using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fan : MonoBehaviour
{
    public GameObject fan;

    private void OnMouseDown()
    {
        fan.SetActive(true);
    }
}
