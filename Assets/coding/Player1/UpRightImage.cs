using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpRightImage : MonoBehaviour
{
    public GameObject upright;
    public void TurnOnUpRight()
    {
        upright.SetActive(true);
    }
}
