using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Arrow : MonoBehaviour
{
    GameObject gameManager;

    Text score;

    private readonly object other;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        GameObject[] Player = GameObject.FindGameObjectsWithTag("Player");
        GameObject[] block = GameObject.FindGameObjectsWithTag("block");
        Destroy(gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {


    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
        else if(col.gameObject.tag == "block")
        {
            gameManager.gameObject.GetComponent<GameManager>().plussc();
            Destroy(gameObject);
        }
    }



}

