using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contorolerofenemyspaceship : MonoBehaviour {
    [SerializeField]float verticalspeed;
    [SerializeField]float horizontalspeed;
    public GameObject bulletofgun;
    public GameObject enemygum;
    public int health;
        private int showdirection;
	// Use this for initialization
	void Start () {
        InvokeRepeating("makeingrandondirection", 1, 0.5f);
        InvokeRepeating("shootinggun", 1f, 2f);
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 posofmoveing;
        posofmoveing = Vector3.down;
        posofmoveing.x =horizontalspeed *showdirection;
        posofmoveing.y = posofmoveing.y * verticalspeed;
        transform.position += posofmoveing * Time.deltaTime;
        checkingboundofx();
	}
    void checkingboundofx()
    {
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -7, 7);
        transform.position = pos;
    }
    void makeingrandondirection(){
        showdirection = Random.Range(-1, 2);
    }
    void shootinggun()
    {
        Instantiate(bulletofgun,enemygum.transform.position, Quaternion.identity);
    }
}
