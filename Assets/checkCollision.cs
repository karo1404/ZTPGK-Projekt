using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkCollision : MonoBehaviour
{
    bool winConditionMet = false;
    public Texture2D endScreen;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            winConditionMet = true;
        }
    }

    void OnGUI()
    {

        if (winConditionMet == true)
        {
            GUI.Label(new Rect(Screen.width/2 - 100, Screen.height/2 - 50, 200, 100), endScreen);
        }
    }
}
