﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{

    [SerializeField] float yVal = 0.7f;
    void Update()
    {
        transform.Rotate(0, yVal, 0);
    }
}
