using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
public class getTexter : MonoBehaviour {


    public Button btn;
    public SaveMetaData saveMetaData;
    public GameObject txt;
    public GameController gameController;
    public GameObject pref;
    
    void Start()
    {
        txt = GameObject.Find("NewUIText");
        saveMetaData = txt.GetComponent<SaveMetaData>();
        btn = GetComponent<Button>();
        btn.onClick.AddListener(return_text);
        pref = GameObject.Find("GameController");
        gameController = pref.GetComponent<GameController>();
    }
    void return_text()
    {
        Text txt = btn.GetComponentInChildren<Text>();
        gameController.new_str = txt.text.ToString();
        gameController.strs.Add(gameController.new_str.ToString());
       // print(gameController.strs.Count + " 22  ");
        saveMetaData.str += gameController.new_str;
      //  check();
        Debug.Log(saveMetaData.str);
    }

    void check()
    {
        for (int i = 0; i < saveMetaData.data.Length; i++)
        {
            if (saveMetaData.str == saveMetaData.data[i])
            {
                Debug.Log("it's work!");
            }
        }
    }
   


    
}
