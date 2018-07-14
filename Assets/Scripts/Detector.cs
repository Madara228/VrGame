using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector : MonoBehaviour {

    public GameObject btn;
    NewScriptForUI newScriptForUi;


	void Start () {
        btn = GameObject.Find("newUi");
        newScriptForUi = btn.GetComponent<NewScriptForUI>();
	}

    void onClicK()
    {
        //newScriptForUi.txt.text == "Название: Метан" +
        //    "Описание: простейший по составу углеводород, бесцветный газ (в нормальных условиях) без запаха, химическая формула — CH4. Малорастворим в воде, легче воздуха. При использовании в быту, промышленности в метан обычно добавляют одоранты (обычно тиолы) со специфическим «запахом газа». Метан нетоксичен и неопасен для здоровья человека. Однако имеются данные, что метан относится к токсическим веществам, действующим на центральную нервную систему." ;


    }
}
