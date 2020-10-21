﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour
{
    public GameObject gameManager;
    public GameObject soundManager;


    void Awake()
    {
        if (GameManager.instance == null)
        {
            Instantiate(gameManager);

        }
       // if (soundManager.instance == null)
        //{
          //  Instantiate(soundManager);
        //}
    }

}

   