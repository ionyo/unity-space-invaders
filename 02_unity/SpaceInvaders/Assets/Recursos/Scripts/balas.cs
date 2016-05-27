﻿using UnityEngine;
using System.Collections;

public class balas : MonoBehaviour {
    public GameObject explosion;
    public GameObject playerExplosion;
    public int scoreValue;
    private Done_GameController gameController;

    void Start()
    {


        GameObject gameControllerObject = GameObject.FindGameObjectWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<Done_GameController>();
        }
        if (gameController == null)
        {
            Debug.Log("Cannot find 'GameController' script");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary" || other.tag == "Enemy")
        {
            return;
        }

        if (other.tag == "Enemy")
        {
            gameController.AddScore(scoreValue);
           
        }


        if (explosion != null)
        {
            Instantiate(explosion, transform.position, transform.rotation);
        }

        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}