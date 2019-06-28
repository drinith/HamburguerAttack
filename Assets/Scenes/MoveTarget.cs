using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveTarget : MonoBehaviour {

	// Use this for initialization
	public Text pontos;

	public float velocidade; 

	void Start () {
		if(gameObject.name=="hanburger(Clone)"){
			velocidade=-10f;

		}
		velocidade= velocidade * (1.0f+0.1f* float.Parse(pontos.text));
	}
	
	// Update is called once per frame
	void Update () {
		// Move the object forward along its z axis 1 unit/second.
		if(gameObject.name!="hanburguer"){
		transform.Translate(0, 0,velocidade*Time.deltaTime);
		}
	}
}
