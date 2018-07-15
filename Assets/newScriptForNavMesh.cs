using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newScriptForNavMesh : MonoBehaviour {



    public Vector3 pos;
    public Vector3 size, center;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 9, 9, 4f);
        Gizmos.DrawCube(center, size);
    }
}
