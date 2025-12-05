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

        if (moveX > 0)
        {
            transform.GetChild(0).GetComponent<SpriteRenderer>().flipX = false;
        }

        if (moveX < 0)
        {
            transform.GetChild(0).GetComponent<SpriteRenderer>().flipX = true;
        }
    }
}
