﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dactive : MonoBehaviour
{
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.instance.Score >= 6)
        {

            Destroy(gameObject);
        }
    }
}
