using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTarget : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Transform link = transform.Find("link1");

        link.GetComponent<Rigidbody>().AddForce((float)Math.Sin((float)Time.frameCount / 75.0f)*5.0f, .0f,.0f);  
    }
}
