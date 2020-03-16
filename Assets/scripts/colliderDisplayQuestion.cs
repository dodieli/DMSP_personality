using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderDisplayQuestion : MonoBehaviour
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

    void OnTriggerEnter(Collider obj) 
    {
        if(obj.tag=="Player"){
            Debug.Log("success");
            question.questionNum = 0;
            questionsCanvas.SetActive(true);
        } 
    }

    void OnTriggerExit(Collider collision) { }
    void OnTriggerStay(Collider collision) { }
}
