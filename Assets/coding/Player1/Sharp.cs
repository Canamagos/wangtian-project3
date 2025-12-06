using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sharp : MonoBehaviour
{
    public GameObject pintu;
    public GameObject photoCanvas;

    private void OnMouseDown()
    {
        photoCanvas.SetActive(true);
        pintu.SetActive(true);
    }


}
