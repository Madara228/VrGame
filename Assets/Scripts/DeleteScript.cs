using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeleteScript : MonoBehaviour {
    [SerializeField]
    getTexter getTexter;

    public GameObject[] gameObjects;
    public GameController gameController;
    public SaveMetaData saveMetaData;
    public GameObject txt;
    public Transform gObj;



    private void Start()
    {
        txt = GameObject.Find("NewUIText");
        saveMetaData = txt.GetComponent<SaveMetaData>();

    }
    public  void omClick()
    {
       
        delete();
    }

    public void appendNew()
    {
       // Instantiate(gameObjects[0], gObj.position, Quaternion.identity);
        Debug.Log("bugaga");
        Debug.Log(saveMetaData.data.Count + "mass lenght");
        for (int i = 0; i < saveMetaData.data.Count; i++)
        {
            if (saveMetaData.str == saveMetaData.data[i])
            {
                Debug.Log("work");
                if (saveMetaData.str == "HHO")
                {
                    Debug.Log(saveMetaData.str);
                    Instantiate(gameObjects[0], gObj.transform.position, Quaternion.identity);
                }
                else if (saveMetaData.str == "CHHHH")
                {
                    Instantiate(gameObjects[1], gObj.transform.position, Quaternion.identity);
                }
            }
                else
                {
                     Debug.Log("nope");
                }
        }

   }

    public void delete()
    {
        Debug.Log(gameController.strs.Count + "./////////////////////////");
        gameController.strs.RemoveAt(gameController.strs.Count - 1);
        Debug.Log(gameController.strs.Count + "..................................");
        addNewElement();
    }

    void addNewElement()
    {
        saveMetaData.str = "";
        for (int i = 0; i < gameController.strs.Count; i++)
        {   
            saveMetaData.str += gameController.strs[i];
        }
    }

    
}
