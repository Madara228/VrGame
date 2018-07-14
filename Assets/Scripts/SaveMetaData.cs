using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
public class SaveMetaData : MonoBehaviour {

    public Text new_txt;
    public string str;
    public string[] data;


    private void Start()
    {
        //data = File.ReadAllLines("C:/Users/karag/Documents/VR/Assets/str.txt");

    }
    private void Update()
    {
        new_txt.text = str;
    }
}
