using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SayHello : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameState.SayHello();
        GameState.LoadCanvasName = "!!! OMG !!!";
        Debug.Log("!!!Say GameCanvas: " + GameState.LoadCanvasName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
