using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroling_star : MonoBehaviour {
    public Vector2 speed;
    private Renderer star_render;
	// Use this for initialization
	void Start () {
        star_render = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
        star_render.material.mainTextureOffset = Time.time * speed;
	}
}
