using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deathzone : MonoBehaviour
{
    Vector3 initPos;
    Quaternion initRot;
    Transform player;
    public GameObject respawnUi;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        initPos = player.position;
        initRot = player.rotation;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player.GetComponent<CharacterController>().enabled = false;
            player.position = initPos;
            player.rotation = initRot;
            player.GetComponent<Rigidbody>().velocity = Vector3.zero;
            respawnUi.SetActive(true);
            
            StartCoroutine(Respawn());
        }
    }

    IEnumerator Respawn()
    {
        yield return new WaitForSeconds(2f);
        player.GetComponent<CharacterController>().enabled = true;
    }
}
