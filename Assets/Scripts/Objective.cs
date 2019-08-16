using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu (fileName="New Objective" )]
[CreateAssetMenu(fileName = "New Objective", menuName = "Objectives/Objective", order = 1)]
[System.Serializable]
public class Objective : ScriptableObject {
    public string objName;
    public string sciName;
    public string assetNumber;
    public Sprite blackwhitesketch;
    public Sprite artwork;
    public bool collected = false;
    public bool visited = false;
    public string fact;
    public string quizquestion;
    public List<string> choices;
    public string answer;
    public int points;
}

