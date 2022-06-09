using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;



public class ManagerEnd : MonoBehaviour
{
    public TMP_Text displayKid;

    private SoRuntimeData runtimeData;

    private void Start()
    {
        runtimeData = Resources.Load<SoRuntimeData>("KinderaddiererRuntimeData");

        displayKid.text = runtimeData.nameKid;

    }

    //generisch ueber Button 

    public void SwitchTheScene(int x)
    {
        
        SceneManager.LoadScene(x);
    }


}
