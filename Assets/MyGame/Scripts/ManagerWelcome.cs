using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public enum MyScenes

{

    WelcomeScene,

    MathScene,

    EndScene

}

public class ManagerWelcome : MonoBehaviour
{
    public TMP_InputField ipfKidsName;

    private SoRuntimeData runtimeData;

    private void Start()
    {
        runtimeData = Resources.Load<SoRuntimeData>("KinderaddiererRuntimeData");

    }

    //generisch ueber Button 

    public void SwitchTheScene(int x)
    {
        
         runtimeData.nameKid = ipfKidsName.text;
        SceneManager.LoadScene(x);
    }


}
