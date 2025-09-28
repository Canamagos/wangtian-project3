using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sharp : MonoBehaviour
{
    public GameObject correctBtn;
    public GameObject photoCanvas;

    private void OnMouseDown()
    {
        photoCanvas.SetActive(true);
        correctBtn.SetActive(true);
    }


}
