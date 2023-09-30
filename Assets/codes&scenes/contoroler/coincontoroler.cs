using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coincontoroler : MonoBehaviour {
    public Vector2 direction;
    public float speed;
	// Use this for initialization
	void Start () {
        direction = Vector2.up;
        direction.x = Random.Range(-2.01f, 2.01f);
      Invoke("changing_direction", 0.4f);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(speed * direction * Time.deltaTime);
	}
    private void changing_direction()
    {
        direction.x = 0;
        direction.y = -1;
    }
}
