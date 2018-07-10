using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigeerred : MonoBehaviour {

	public void triggered()
    {
        transform.Rotate(new Vector3(12f,5f,5f));
        print("it's fucking work!"); 
    }
}
