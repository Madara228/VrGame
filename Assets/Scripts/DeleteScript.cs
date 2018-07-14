using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteScript : MonoBehaviour {
    [SerializeField]
    getTexter getTexter;

    public GameObject[] gameObjects;
    public GameController gameController;
    public SaveMetaData saveMetaData;
    public GameObject txt;




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
        Debug.Log("bugaga");
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

    void checkIt()
    {

    }
}
