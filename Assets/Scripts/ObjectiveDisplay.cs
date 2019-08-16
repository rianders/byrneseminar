using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ObjectiveDisplay : MonoBehaviour {

	// Use this for initialization
	public Objective objective;

    public TextMeshProUGUI objNameText;
    public TextMeshProUGUI sciNameText;
    public Image artworkImage;
    public TextMeshProUGUI factText;
    public TextMeshProUGUI answerText;


    public TextMeshProUGUI quizQuestionText;
    public Image questionImage;
    public TextMeshProUGUI choiceOneText;
    public TextMeshProUGUI choiceTwoText;
    public TextMeshProUGUI choiceThreeText;
    public TextMeshProUGUI choiceFourText;

    public Image mudimage;
    public Image sparkleoneimage;
    public Image sparkletwoimage;

    public GameObject ansone;
    public GameObject anstwo;
    public GameObject ansthree;
    public GameObject ansfour;

    public GameObject scroll;

    private Animation anim;


    void Start ()
    {
        objNameText.text = objective.objName;
        artworkImage.sprite = objective.artwork;
        if (sciNameText != null) //Ponds don't have Sciname
        {
            sciNameText.text = objective.sciName;
        }
        factText.text = objective.fact;
        answerText.text = objective.answer;
        questionImage.sprite = objective.blackwhitesketch;
        quizQuestionText.text = objective.quizquestion;
        choiceOneText.text = objective.choices[0];
        choiceTwoText.text = objective.choices[1];
        if (choiceThreeText != null) //In case trivia doesn't have a third choice
        {
            choiceThreeText.text = objective.choices[2];
        }
        if (choiceFourText != null) //In case trivia doesn't have a fourth choice
        {
            choiceFourText.text = objective.choices[3];
        }
    }

    public void CorrectAnswerUpdate()
    {
        setCollected();
        //anim = GameObject.Find("Sparkles").GetComponent<Animation>();
        //anim.Play("RestorePage");
        mudimage.enabled = false;
        quizQuestionText.enabled = false;
        questionImage.enabled = false;
        ansone.SetActive(false);
        anstwo.SetActive(false);
        ansthree.SetActive(false);
        ansfour.SetActive(false);
        scroll.SetActive(true);
    }

    public void setVisited()
    {
        objective.visited = true;
        GameObject.Find("GameData").GetComponent<SaveList>().SaveGame();
    }

    public void setCollected()
    {
        objective.visited = objective.collected = true;
        GameObject.Find("GameData").GetComponent<SaveList>().SaveGame();
    }
}
