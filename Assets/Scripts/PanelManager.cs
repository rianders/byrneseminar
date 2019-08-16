using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
    [SerializeField] GameObject[] panelList;
    void Start()
    {
        GameState.SayHello();
        Debug.Log("!!!Say Panel: " + GameState.LoadPanel);
        if(GameState.LoadPanel == "pMainMenu") {
        OpenPanel(10);
        }
    }

   void ResetPanels(){
        for(int i = 0; i < panelList.Length; i++){
            if(panelList[i].activeSelf) panelList[i].SetActive(false);
        }
    }

    public void OpenPanel(int index){
        ResetPanels();
        panelList[index].SetActive(true);
    }
}
