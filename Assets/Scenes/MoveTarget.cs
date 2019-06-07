using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTarget : MonoBehaviour {

	// Use this for initialization
	public int velocidade=-10; 

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// Move the object forward along its z axis 1 unit/second.
		transform.Translate(0, 0,velocidade*Time.deltaTime);
		
	}
}
