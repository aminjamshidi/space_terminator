using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum indicateofdirectionbullet{down,up}
public class shootingsimpelboolet : MonoBehaviour {
    public indicateofdirectionbullet direction;
    public int power;
    public GameObject explosion;
    private Vector3 move;
    public Sprite[] sprits;
    [SerializeField]float speedofshooting;
    [SerializeField]private SpriteRenderer myrender;
	// Use this for initialization
	void Start () {
        myrender.sprite = sprits[Random.Range(0, sprits.Length)];
        if (direction == indicateofdirectionbullet.down)
        {
            move = Vector3.down;
        }
        else
        {
            move = Vector3.up;
        }
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(move * speedofshooting * Time.deltaTime);
	}
    private void OnCollisionEnter2D(Collision2D col)
    {
        Instantiate(explosion, col.contacts[0].point, Quaternion.identity);
        Destroy(gameObject);
    }
}
