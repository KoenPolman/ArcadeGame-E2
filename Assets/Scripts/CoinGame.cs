using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinGame : MonoBehaviour
{
    void Start()
    {
        int correct;
        int notCorrect1 = GetNum();
        int notCorrect2 = GetNum();
        int wrong1;
        int wrong2;
        int wrong3;

        int num1 = GetNum();
        int num2 = GetNum();
        Input.GetMouseButton(1);

        int opp = Random.Range(1, 3);


        if (opp == 1)
        {
            if (num1 > num2)
            {
                print(num1);
                print("-");
                print(num2);
                correct = num1 - num2;
                print(correct);
                if (notCorrect1 > GetNum())
                {

                    wrong1 = notCorrect1 - GetNum();
                    print(wrong1);
                    wrong2 = notCorrect1 - GetNum();
                    print(wrong2);
                    wrong3 = notCorrect1 - GetNum();
                    print(wrong3);
                }
                else if (notCorrect2 > GetNum())
                {

                    wrong1 = notCorrect2 - GetNum();
                    print(wrong1);
                    wrong2 = notCorrect2 - GetNum();
                    print(wrong2);
                    wrong3 = notCorrect2 - GetNum();
                    print(wrong3);
                }

            }
            else if (num1 < num2)
            {
                print(num1);
                print("-");
                print(num2);
                correct = num2 - num1;
                print(correct);
                if (notCorrect1 > GetNum())
                {
                    print(correct);
                    wrong1 = notCorrect1 - GetNum();
                    print(wrong1);
                    wrong2 = notCorrect1 - GetNum();
                    print(wrong2);
                    wrong3 = notCorrect1 - GetNum();
                    print(wrong3);
                }
                else if (notCorrect2 > GetNum())
                {

                    wrong1 = notCorrect2 - GetNum();
                    print(wrong1);
                    wrong2 = notCorrect2 - GetNum();
                    print(wrong2);
                    wrong3 = notCorrect2 - GetNum();
                    print(wrong3);
                }

            }
        }
        else if (opp == 2)
        {
            print(num1);
            print("+");
            print(num2);
            correct = num1 + num2;
            print(correct);
            wrong1 = notCorrect1 + GetNum();
            print(wrong1);
            wrong2 = notCorrect1 + GetNum();
            print(wrong2);
            wrong3 = notCorrect1 + GetNum();
            print(wrong3);

        }

    }

    int GetNum()
    {
        int num = Random.Range(100, 1000);
        return num;



    }
}
