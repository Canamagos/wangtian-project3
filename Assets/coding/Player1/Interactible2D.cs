using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactible2D : MonoBehaviour
{
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
