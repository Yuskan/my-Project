using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    string randomOperator;
    int answer;

    public GameObject question;
    public GameObject option1;
    public GameObject option2;
    public GameObject option3;

    void Start()
    {
    }

    void Update()
    {
    }

    public void GenerateQuestion()
    {
        int number = Random.Range(0, 101);
        int a = Random.Range(0, 101);
        int b = Random.Range(0, 101);
        int operatorNumber = Random.Range(0, 3);
       
        if (operatorNumber == 0)
        {
            randomOperator = "+";
            answer = a + b;
        }
        else if(operatorNumber==1)
        {
            randomOperator = "-";
            answer = a - b;
        }
        else 
        {
            randomOperator = "*";
            answer = a * b;
        }
        int option = Random.Range(0, 3);

        if (option == 0)
        {
            option1.GetComponent<TextMesh>().text = answer.ToString();
            option2.GetComponent<TextMesh>().text = (answer + (Random.Range(0, 3) * 2 - 1)).ToString();
            option3.GetComponent<TextMesh>().text = (answer + (Random.Range(0, 3) * 3 - 1)).ToString();
            // 分流一：讓第一個選項負責正確的答案、第二、三個選項負責錯誤的答案
        }
        else if(option==1)
        {
            option1.GetComponent<TextMesh>().text = (answer + (Random.Range(0, 3) * 2 - 1)).ToString();
            option2.GetComponent<TextMesh>().text = answer.ToString();
            option3.GetComponent<TextMesh>().text = (answer + (Random.Range(0, 3) * 3 - 1)).ToString();
            // 分流二：第二個選項負責正確的答案、第一、三個選項負責錯誤的答案
        }
        else 
        {
            option3.GetComponent<TextMesh>().text = answer.ToString();
            option1.GetComponent<TextMesh>().text = (answer + (Random.Range(0, 3) * 2 - 1)).ToString();
            option2.GetComponent<TextMesh>().text = (answer + (Random.Range(0, 3) * 3 - 1)).ToString();
            // 分流三：第三個選項負責正確的答案、第一、二個選項負責錯誤的答案
        }
        question.GetComponent<TextMesh>().text = a + " " + randomOperator + " " + b + " = ?";

    }
}