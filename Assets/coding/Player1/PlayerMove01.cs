using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove01 : MonoBehaviour
{
    public float speed = 5.0f;
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        transform.Translate(moveX, 0, 0);
    }
}
