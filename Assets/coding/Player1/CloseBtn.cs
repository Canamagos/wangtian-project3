using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseBtn : MonoBehaviour
{
    public GameObject photoCanvas;

    public void Close()
    {
        photoCanvas.SetActive(false);
    }
}
