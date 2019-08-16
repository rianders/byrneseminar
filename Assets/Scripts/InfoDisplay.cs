using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InfoDisplay : MonoBehaviour {

    public Objective pobjective;

    public Image mudimage;
    public TextMeshProUGUI lockedtext;
    public TextMeshProUGUI scantext;
    public TextMeshProUGUI objectivetext;
    public Image scanimage;

    public TextMeshProUGUI pobjNameText;
    public TextMeshProUGUI psciNameText;
    public Image partworkImage;

    public TextMeshProUGUI pfactText;
    public TextMeshProUGUI panswerText;

    // Use this for initialization
    void Start () {
        objectivetext.text = pobjective.objName;
        pobjNameText.text = pobjective.objName;
        psciNameText.text = pobjective.sciName;
        partworkImage.sprite = pobjective.artwork;
        pfactText.text = pobjective.fact;
        panswerText.text = pobjective.answer;
    }

    void Update()
    {
        if (pobjective.collected == true)
        {
            mudimage.enabled = false;
            lockedtext.enabled = false;
            scantext.enabled = false;
            objectivetext.enabled = false;
            scanimage.enabled = false;
        }
    }
}
