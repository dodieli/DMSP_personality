using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class count : MonoBehaviour
{
    public static int tik_tok = 0;
    public static int weibo = 0;
    public static int facebook = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string text_string = "Weibo: " + weibo + "\n" + "TikTok: " + tik_tok + "\n" + "Facebook: " + facebook + "\n";
        this.gameObject.GetComponent<TMP_Text>().text = "<size=36><color=white>" + text_string + "</color></size>";
    }
}
