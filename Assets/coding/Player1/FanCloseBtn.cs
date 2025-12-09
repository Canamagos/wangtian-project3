using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanCloseBtn : MonoBehaviour
{
    public GameObject fan;

    public void TurnOffUi()
    {
        fan.SetActive(false);
    }
}
