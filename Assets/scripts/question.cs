using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class question : MonoBehaviour
{
    public static int questionNum = 0;

    GameObject root;
    GameObject content;
    GameObject Questions_canvas;

    // Start is called before the first frame update
    void Start()
    {
      root = GameObject.Find("root");
      content = root.transform.Find("Questions/QuestionContentArea/Question_Info/question_content").gameObject;
      Questions_canvas = root.transform.Find("Questions").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
      switch(questionNum){
          case 0:
            content.GetComponent<TMP_Text>().text= "<size=8>Question 1</size>\n <size=5>I am the life of the party?</size>"; 
            break;
          case 1:
            content.GetComponent<TMP_Text>().text= "<size=8>Question 2</size>\n <size=5>I sympathize with others’ feelings.</size>";
            break;
          case 2:
            content.GetComponent<TMP_Text>().text= "<size=8>Question 3</size>\n <size=5>I get chores done right away.</size>"; 
            break;
          case 3:
            content.GetComponent<TMP_Text>().text= "<size=8>Question 4</size>\n <size=5>I have frequent mood swings.</size>"; 
            break;
      }
    }
}
