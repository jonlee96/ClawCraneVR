﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rot = transform.localRotation.eulerAngles;
        rot += new Vector3(0, 2000, 0) * Time.deltaTime;
        transform.localRotation = Quaternion.Euler(rot);
    }
}
