using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btn_maybe : MonoBehaviour
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
        count.facebook++;
    }
}
