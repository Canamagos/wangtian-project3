using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RespawnCountdown : MonoBehaviour
{
    TMP_Text text;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TMP_Text>();
        timer = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        text.text = Mathf.FloorToInt(timer).ToString();
        if (timer <= 0)
        {
            timer = 3f;
            transform.parent.gameObject.SetActive(false);
        }
    }
}
