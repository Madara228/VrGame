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
    public Transform gm;
    Vector3 pos;
    public randomInstance randomInstance;



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
        check();
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

    public void check()
    {
        Debug.Log(saveMetaData.data.Length);
        for (int i = 0; i < saveMetaData.data.Length; i++)
        {
            if (saveMetaData.str == saveMetaData.data[i])
            {
                Debug.Log("work");
                if(saveMetaData.str == "HHO")
                {
                    pos = randomInstance.center + new Vector3(Random.Range(-randomInstance.size.x / 2, randomInstance.size.x / 2), randomInstance.size.y, Random.Range(-randomInstance.size.z / 2, randomInstance.size.z / 2));
                    Debug.Log(saveMetaData.str);
                    Instantiate(gameObjects[0],pos,Quaternion.identity);
                }
                else if(saveMetaData.str == "CHHHH")
                {
                    pos = randomInstance.center + new Vector3(Random.Range(-randomInstance.size.x / 2, randomInstance.size.x / 2), randomInstance.size.y, Random.Range(-randomInstance.size.z / 2, randomInstance.size.z / 2));
                    Instantiate(gameObjects[1], pos, Quaternion.identity);
                }
            }
            else
            {
                Debug.Log("nope");
            }
        }
    }

    void checkIt()
    {
    }
}
