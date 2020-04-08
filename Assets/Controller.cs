using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class Controller : MonoBehaviour
{
    public GameObject ball = null;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) 
        {
            transform.Rotate(.0f, -0.15f, .0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(.0f, 0.15f,.0f);
        }
        if (Input.GetKey(KeyCode.W))
        {
            Transform barrel = transform.Find("barrel");
            if(barrel.rotation.x < -0.2f)
            {
                barrel.Rotate(0.15f, .0f, .0f);
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            Transform barrel = transform.Find("barrel");
            if (barrel.rotation.x > -0.7f)
            {
                barrel.Rotate(-0.15f, .0f, .0f);
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Transform pos = transform.Find("barrel").Find("ballPosition");
            Instantiate(ball, pos.position, pos.rotation, null);
        }
    }
}
