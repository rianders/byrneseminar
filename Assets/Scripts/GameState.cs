using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState :  Singleton<GameState>
{
    [SerializeField]
    public static string LoadCanvasName {get; set;}
    [SerializeField]
    public static string LoadPanel {get; set;}

    protected virtual void Start()
    {
        Debug.Log("!!!GameStateStart!!!");
        GameObject.Find("GameData").GetComponent<SaveList>().LoadGame();
    }

    public static void  SayHello() {
        Debug.Log("Say: Hello!!! Hello");
    }
}
