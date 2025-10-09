using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    private Transform book;

    private Transform point01;
    private Transform point02;
    private bool isMovingToB = true;
    public float speed; 
    
    // Start is called before the first frame update
    void Start()
    {
        book = transform.GetChild(0);   
        point01 = transform.GetChild(1);
        point02 = transform.GetChild(2);
    }

    // Update is called once per frame
    void Update()
    {
        if (isMovingToB)
        {
            book.Translate((point02.position - book.position).normalized * (speed * Time.deltaTime));
            if (Vector3.Distance(book.position, point02.position) <= 0.1f)
            {
                isMovingToB = false;
            }
        }
        else
        {
            book.Translate((point01.position - book.position).normalized * (speed * Time.deltaTime));
            if (Vector3.Distance(book.position, point01.position) <= 0.1f)
            {
                isMovingToB = true;
            }
        }
    }
}
