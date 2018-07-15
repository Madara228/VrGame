using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
public class SaveMetaData : MonoBehaviour {

    public Text new_txt;
    public string str;
    public List<string> data = new List<string>();


    private void Start()
    {
        //data = File.ReadAllLines("C:/Users/karag/Documents/VR/Assets/str.txt");
        data.Add("HHO");
        data.Add("CHHHH");
    }
    private void Update()
    {
        new_txt.text = str;
    }
}
