using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class launch : MonoBehaviour
{
    float lifespan = 0;
    // Start is called before the first frame update
    void Start()
    {
        lifespan = Time.time;
        GetComponent<Rigidbody>().AddForce(transform.TransformDirection(new Vector3(0, 10000, 0)));
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time - lifespan > 8.0f)
        {
            Destroy(this.gameObject);
        }
    }
}
