using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

//Alle Szenen
public enum MyScenes
{
    WelcomeScene,
    FirstScene,
    SecondScene,
    ThirdScene,
    EndScene
}

public class Manager : MonoBehaviour
{
    //meine GameObjects
    public TMP_InputField ipfKidsName;
    public GameObject SageBG;
    public GameObject CypherBG;
    public GameObject SkyeBG;
    public TMP_Text warning;
    private SoRuntimeData runtimeData;


    private void Start()
    {
        runtimeData = Resources.Load<SoRuntimeData>("KinderaddiererRuntimeData");



    }
    //Hinweis, welches Symbol ausgew�hlt ist


    public void SwitchTheScene(int x)
    {
        //Hier wird das Symbol gew�hlt

        runtimeData.nameKid = ipfKidsName.text;

        if (SageBG.activeSelf)
        {
            runtimeData.showPic = "Sage";
        }
        else if (SkyeBG.activeSelf)
        {
            runtimeData.showPic = "Skye";
        }
        else if (CypherBG.activeSelf)
        {
            runtimeData.showPic = "Cypher";
        }
        else
        {
            runtimeData.showPic = "";
        }
        if (runtimeData.showPic == "" && runtimeData.nameKid == "")
        {
            warning.text = "*BITTE W�HLEN DEINEN CHARACKTER ODER TIPPE DEINEN NAMEN EIN!";
            warning.fontSize = 30;
            warning.color = Color.red;
        }
        else
        {
            SceneManager.LoadScene(x);
        }


    }

    public void UseSage()
    {
        //methode f�r SAGE (Links)
        CypherBG.SetActive(false);
        SkyeBG.SetActive(false);
        if (SageBG.activeSelf)
        {
            SageBG.SetActive(false);
        }
        else
        {
            SageBG.SetActive(true);
        }



    }

    public void UseCypher()
    {
        //methode f�r Cypher (Mitte)
        SageBG.SetActive(false);
        SkyeBG.SetActive(false);
        if(CypherBG.activeSelf)
        {
            CypherBG.SetActive(false);
        }
        else
        {
            CypherBG.SetActive(true);
        }
    }

    public void UseSkye()
    {
        //methode f�r Skye (Rechts)
        SageBG.SetActive(false);
        CypherBG.SetActive(false);
        if (SkyeBG.activeSelf)
        {
            SkyeBG.SetActive(false);
        }
        else
        {
            SkyeBG.SetActive(true);
        }
    }





}
