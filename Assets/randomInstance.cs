using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomInstance : MonoBehaviour {

    public Vector3 center;
    public Vector3 size;

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 9, 9, 4f);
        Gizmos.DrawCube(center, size);
    }
}
