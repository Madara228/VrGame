using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class getTexter : MonoBehaviour {


    public Button btn;
    public string new_str;

    void Start()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(return_text);
    }   
    void return_text()
    {
        Text txt = btn.GetComponentInChildren<Text>();
        new_str = txt.text.ToString();
        print(new_str);

    }
}
