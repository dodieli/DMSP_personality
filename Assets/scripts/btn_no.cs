﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btn_no : MonoBehaviour
{
    GameObject root;
    GameObject questionsCanvas;

    // Start is called before the first frame update
    void Start()
    {
        root = GameObject.Find("root");
        questionsCanvas = root.transform.Find("Questions").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClick()
    {
        questionsCanvas.SetActive(false);
        int questionNum = question.questionNum;

        switch (questionNum)
        {
            case 0:
                count.weibo++;
                break;
            case 1:
                count.tik_tok++;
                break;
            case 2:
                count.tik_tok++;
                break;
            case 3:
                count.weibo++;
                break;
        }
    }
}