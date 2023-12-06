﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    public static GameOverScreen instance { get; private set; }
    
    
    
    
    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        
    }

    public void CheckValue(float value)
    {				      
        if (value < 1)
        {

        }
    }
}