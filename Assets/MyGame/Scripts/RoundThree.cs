using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class RoundThree : MonoBehaviour
{
    //Variablen beschreiben.
    private SoRuntimeData runtimeData;
    private string getNumber1;
    private string getNumber2;
    private string getNumber3;
    private string getNumber4;
    private string getNumber5;
    private string getNumber6;
    private string getNumber7;
    private string getNumber8;
    private int result;
    public TMP_Text number1;
    public TMP_Text number2;
    public TMP_Text number3;
    public TMP_Text number4;
    public TMP_Text score;
    public int scorecount;
    public TMP_InputField inputOne, inputThree, inputFive, inputSeven;
    public TMP_InputField inputTwo, inputFour, inputSix, inputEight;
    public GameObject sprite1;
    public GameObject sprite2;
    public GameObject sprite3;
    public GameObject sprite4;
    public GameObject checkResultsButton;



    void Start()
    {
        runtimeData = Resources.Load<SoRuntimeData>("KinderaddiererRuntimeData");
        score.text = scorecount.ToString();
        scorecount = 0;
        number1.text = UnityEngine.Random.Range(1, 9).ToString();
        number2.text = UnityEngine.Random.Range(1, 9).ToString();
        number3.text = UnityEngine.Random.Range(1, 9).ToString();
        number4.text = UnityEngine.Random.Range(1, 9).ToString();

       
    }

    public void GetNumber(string firstNumber, string secondNumber, TMP_InputField firstInput, TMP_InputField secondInput, TMP_Text randomNumber, GameObject sprite)
    {
        
        firstNumber = firstInput.text;
        secondNumber = secondInput.text;

        int.TryParse(firstNumber, out int parseNumber1);
        int.TryParse(secondNumber, out int parseNumber2);


        result = parseNumber2 - parseNumber1;
        


        int parseRandomNumber1 = Int32.Parse(randomNumber.text);
        SpriteRenderer sRenderer = sprite.GetComponent<SpriteRenderer>();

        if (parseRandomNumber1 == result)
        {
            Debug.Log("RICHTIG");
            sRenderer.color = Color.red;

            //Hier wird der Punktestand gecheckt

            scorecount++;
            Debug.Log(scorecount);
            score.text = scorecount.ToString();


        }
        else
        {
            Debug.Log("NO");
            sRenderer.color = Color.red;
        }

        checkResultsButton.SetActive(false);
        runtimeData.scoreResult = score.text;
        runtimeData.scoreMessage = scorecount;

    }
    public void Test()
    {
        //hier werden die nummern getestet
        GetNumber(getNumber1, getNumber2, inputOne, inputTwo, number1, sprite1);
        GetNumber(getNumber3, getNumber4, inputThree, inputFour, number2, sprite2);
        GetNumber(getNumber5, getNumber6, inputFive, inputSix, number3, sprite3);
        GetNumber(getNumber7, getNumber8, inputSeven, inputEight, number4, sprite4);
    }




}
