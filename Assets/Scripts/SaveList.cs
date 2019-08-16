using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SaveList : MonoBehaviour
{
    public List<Objective> objectives; // = new List<Objective>();

    public void SaveGame()
    {
        this.objectives = GameObject.Find("GameData").GetComponent<SaveList>().objectives;
        string[] SaveArray = new string[this.objectives.Count];

        for (int i = 0; i < this.objectives.Count; i++)
        {
            SaveArray[i] = JsonUtility.ToJson(this.objectives[i], true);
        }

        SaveSystem.SaveGame(SaveArray);
    }

    public void ResetGame()
    {
        this.objectives = GameObject.Find("GameData").GetComponent<SaveList>().objectives;
        string[] SaveArray = new string[this.objectives.Count];

        for (int i = 0; i < this.objectives.Count; i++)
        {
            //Change collected and visited state to false
            this.objectives[i].visited = false;
            this.objectives[i].collected = false;
            this.objectives[i].points = 10;
            ScoreScript.scoreValue = 0;

            //Save State
            SaveArray[i] = JsonUtility.ToJson(this.objectives[i], true);
        }

        SaveSystem.SaveGame(SaveArray);
    }

    public void LoadGame()
    {
        ScoreScript.scoreValue = 0;
        string[] LoadArray = SaveSystem.LoadGame();
        this.objectives = GameObject.Find("GameData").GetComponent<SaveList>().objectives;
        for (int i = 0; i < this.objectives.Count; i++)
        {
            Debug.Log(LoadArray[i]);
            JsonUtility.FromJsonOverwrite(LoadArray[i], this.objectives[i]);
        }

        for (int i = 0; i < this.objectives.Count; i++)
        {
            if (this.objectives[i].collected == true) 
            {
                ScoreScript.scoreValue += this.objectives[i].points;
            }
        }
    }
}
