using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingScript : MonoBehaviour {

    public Transform camera;

    public float toggleAngle = 30f;

    public float speed = 3f;

    public bool moveForward;
    public AudioSource source;

    private CharacterController cc;


	void Start () {
        cc = GetComponent<CharacterController>();
        source = GetComponent<AudioSource>();
	}
	
	
	void Update () {
        if (camera.eulerAngles.x > toggleAngle && camera.eulerAngles.x < 90f)
        {
            moveForward = true;
        }
        else
        {
            moveForward = false;
            source.Play();
        }
        if (moveForward)
        {
            Vector3 forward = camera.TransformDirection(Vector3.forward);
            cc.SimpleMove(forward * speed);
            
        }
	}
}
