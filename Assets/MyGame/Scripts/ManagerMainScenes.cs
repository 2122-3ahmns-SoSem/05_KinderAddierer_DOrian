using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ManagerMainScenes : MonoBehaviour
{

//Aufzählung der Variablen

    
    public TMP_Text displayKidsName;
    public Image userImage;
    private SoRuntimeData runtimeData;

    private void Start()
    {
        runtimeData = Resources.Load<SoRuntimeData>("KinderaddiererRuntimeData");

        displayKidsName.text = runtimeData.nameKid;
        SetUserImage(runtimeData.showPic);

        if (runtimeData.showPic == "" || runtimeData.nameKid != "")
        {
            userImage.enabled = false;
        }
    }

    public void SwitchTheScene(int x)
    {
        SceneManager.LoadScene(x);
    }
    void SetUserImage(string imageName)
    {
        userImage.sprite = Resources.Load<Sprite>(imageName)as Sprite;
    }
}
