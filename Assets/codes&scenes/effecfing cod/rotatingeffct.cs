using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatingeffct : MonoBehaviour {
    public Vector3 rotating_parametr;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(rotating_parametr * Time.deltaTime);
	}
}
