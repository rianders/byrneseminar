using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class JournalObjectiveDisplay : MonoBehaviour {

    public Objective jobjective;

    public TextMeshProUGUI jobjNameText;

    //public Toggle jtglV;
    public Toggle jtglC;

    void Start () {
        jobjNameText.text = jobjective.objName;
        //jtglV.isOn = jobjective.visited;
        jtglC.isOn = jobjective.collected;
    }

}
