﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCar : MonoBehaviour
{

    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -17);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //offset the camera 
        transform.position = player.transform.position + offset;
    }
}
