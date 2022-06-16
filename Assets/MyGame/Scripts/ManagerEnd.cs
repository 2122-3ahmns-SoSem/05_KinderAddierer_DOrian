using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ManagerEnd : MonoBehaviour
{
    //Variablen aufzählung
    public TMP_Text displayKidsName;
    public TMP_Text displayScore;
    public TMP_Text message;
    public Image userImage;

    private int scorecount;

    private SoRuntimeData runtimeData;
    private RoundThree roundthree;


    //Szenen Switcher
    public void SwitchTheScene(int x)
    {
        SceneManager.LoadScene(x);

    }
    //Spiel Schließen
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Ciao!");
    }

    
    private void Start()
    {
        //hier werden die motivativen sprüche ausgegeben
        runtimeData = Resources.Load<SoRuntimeData>("KinderaddiererRuntimeData");

        displayKidsName.text = runtimeData.nameKid;
        displayScore.text = runtimeData.scoreResult;
        scorecount = runtimeData.scoreMessage;
        SetUserImage(runtimeData.showPic);
        if (runtimeData.showPic == "" || runtimeData.nameKid != "")
        {
            userImage.enabled = false;
        }

        if (scorecount >= 3 )
        {
            message.text = "Perfekt du kleiner streber!";
        }

       if (scorecount <=2 && scorecount >= 1)
        {
            message.text = "Beinahe Perfekt!";
        }

       if (scorecount < 1)
        {
            message.text = "OH das war eher schlecht :C";
        }
    }

    void SetUserImage(string imageName)
    {
        //hier wird das Symbol reingeladen
        userImage.sprite = Resources.Load<Sprite>(imageName) as Sprite;


    }

  

    



}
