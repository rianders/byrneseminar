using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour {

    public void SceneSwitcher (string sceneName) {
        if (sceneName == "Scanner") {
            GameState.LoadPanel = "pMainMenu";
        }

        if (sceneName == "Walkthrough")
        {
            GameState.LoadPanel = "pMainMenu";
        }

        SceneManager.LoadScene(sceneName);

        Debug.Log("Loading scene:" + sceneName);
    }
}
