using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


  


public class CoinGame : MonoBehaviour
{
    public Text text;
    public Text answers;
    [SerializeField] Text[] answersArr;

    int wrong1;
    int wrong2;
    int wrong3;
    int correct;
    public int coins;

    void UpdateAnswers() // deze method zorgt ervoor dat de som en antwoorden op de buttons komen te staan
    {
        answersArr[0].text = wrong1.ToString();
        answersArr[1].text = wrong2.ToString();
        answersArr[2].text = wrong3.ToString();
        answersArr[3].text = correct.ToString();
        answersArr[4].text = coins.ToString();
    }
    void Start()
    {
        Sums();
    }
    void Sums() // genereert een plus of min som plus het goede en drie foute antwoorden
    {

        string right;
        int notCorrect1 = GetNum();
        int notCorrect2 = GetNum();
        string wrong;
        string sum = "";

        int num1 = GetNum();
        int num2 = GetNum();

        int opp = Random.Range(1, 3);

        if (opp == 1)
        {
            if (num1 > num2)
            {
                sum = num1.ToString() + "-" + num2.ToString();

                correct = num1 - num2;

                if (notCorrect1 > GetNum())
                {
                    right = correct.ToString();


                    wrong1 = notCorrect1 - GetNum();
                    wrong = wrong1.ToString();

                    wrong2 = notCorrect1 - GetNum();
                    wrong = wrong2.ToString();


                    wrong3 = notCorrect1 - GetNum();
                    wrong = wrong3.ToString();

                }
                else if (notCorrect2 > GetNum())
                {
                    right = correct.ToString();

                    wrong1 = notCorrect2 - GetNum();
                    wrong = wrong1.ToString();

                    wrong2 = notCorrect2 - GetNum();
                    wrong = wrong2.ToString();

                    wrong3 = notCorrect2 - GetNum();
                    wrong = wrong3.ToString();
                }

            }
            else if (num1 < num2)
            {
                sum = num2.ToString() + "-" + num1.ToString();

                correct = num2 - num1;

                if (notCorrect1 > GetNum())
                {
                    right = correct.ToString();

                    wrong1 = notCorrect1 - GetNum();
                    wrong = wrong1.ToString();

                    wrong2 = notCorrect1 - GetNum();
                    wrong = wrong2.ToString();

                    wrong3 = notCorrect1 - GetNum();
                    wrong = wrong3.ToString();

                }
                else if (notCorrect2 > GetNum())
                {
                    right = correct.ToString();

                    wrong1 = notCorrect2 - GetNum();
                    wrong = wrong1.ToString();

                    wrong2 = notCorrect2 - GetNum();
                    wrong = wrong2.ToString();

                    wrong3 = notCorrect2 - GetNum();
                    wrong = wrong3.ToString();
                }
            }
        }
        else if (opp == 2)
        {
            sum = num1.ToString() + "+" + num2.ToString();
            correct = num1 + num2;
            right = correct.ToString();

            wrong1 = notCorrect1 + GetNum();
            wrong = wrong1.ToString();

            wrong2 = notCorrect1 + GetNum();
            wrong = wrong2.ToString();

            wrong3 = notCorrect1 + GetNum();
            wrong = wrong3.ToString();
        }
        text.text = sum;
        UpdateAnswers();
    }
    int GetNum()// genereert de nummers voor de sommen
    {
        int num = Random.Range(100, 1000);
        return num;
    }
       public void ButtonClicked() // deze method zorgt ervoor dat als je op de knop met het juiste antwoord klikt je een nieuwe som krijgt en een munt erbij
        {
      
        coins++;
        PlayerPrefs.SetInt("Coins", coins);
        PlayerPrefs.Save();
        Sums();
        }
}