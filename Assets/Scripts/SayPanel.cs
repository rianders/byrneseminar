using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SayPanel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameState.SayHello();
        Debug.Log("!!!Say Panel: " + GameState.LoadPanel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
