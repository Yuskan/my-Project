using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamecontroller : MonoBehaviour {

    public string randomOperator;
    public int answer;

    public GameObject question;
    public GameObject option1;
    public GameObject option2;
    public GameObject option3;

    // Use this for initialization
    void Start () {
        GenerateQuestion();
    }
	
	// Update is called once per frame
	void Update () 
    {
	}
    public void GenerateQuestion()
    {
        int a = Random.Range(0, 101);
        int b = Random.Range(0, 101);
        int operatorNumber = Random.Range(0, 3);

        if (operatorNumber == 0)
        {
            randomOperator = "+";
            answer = a + b;
        }
        else if(operatorNumber== 1)
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

            option1.GetComponent<Option>().isCorrect = true;
            option2.GetComponent<Option>().isCorrect = false;
            option3.GetComponent<Option>().isCorrect = false;
            // 分流一：讓第一個選項負責正確的答案、第二個選項負責錯誤的答案
        }
        else if(option ==1)
        {
            option2.GetComponent<TextMesh>().text = answer.ToString();
            option1.GetComponent<TextMesh>().text = (answer + (Random.Range(0, 3) * 2 - 1)).ToString();
            option3.GetComponent<TextMesh>().text = (answer + (Random.Range(0, 3) * 3 - 1)).ToString();

            option1.GetComponent<Option>().isCorrect = false;
            option2.GetComponent<Option>().isCorrect = true;
            option3.GetComponent<Option>().isCorrect = false;
            // 分流二：第二個選項負責正確的答案、第一個選項負責錯誤的答案
        }
        else
        {
            option3.GetComponent<TextMesh>().text = answer.ToString();
            option2.GetComponent<TextMesh>().text = (answer + (Random.Range(0, 3) * 2 - 1)).ToString();
            option1.GetComponent<TextMesh>().text = (answer + (Random.Range(0, 3) * 3 - 1)).ToString();

            option1.GetComponent<Option>().isCorrect = false;
            option2.GetComponent<Option>().isCorrect = false;
            option3.GetComponent<Option>().isCorrect = true;
            // 分流三：第三個選項負責正確的答案、第一個選項負責錯誤的答案
        }
        question.GetComponent<TextMesh>().text = a + " " + randomOperator + " " + b + " = ?";
    }


}
