﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Vector3 myPos;
    public Transform myPlay;

    void Update()
    {
        transform.position = myPlay.position + myPos;
    }
}
