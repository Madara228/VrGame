using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewScriptForUI : MonoBehaviour {

    public GameObject btn;
    public Text txt;

    void Start () {
        btn = GameObject.Find("newUi");
        txt = btn.GetComponentInChildren<Text>();
    }
	void Update () {
		
	}
}
