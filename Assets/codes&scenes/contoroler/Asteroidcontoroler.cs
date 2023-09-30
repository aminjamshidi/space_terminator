using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroidcontoroler : MonoBehaviour
{
    [SerializeField]GameObject explosion;
    public int health;
    [SerializeField]float speedofastrodformoving;
    [SerializeField]float speedofastrodforrotating;
    private Animator amin_of_destroying;
    public Sprite[] healthsprits;
    public GameObject coinspawner;
    SpriteRenderer SPrender;
    private GameContorol gamecontorol;
    private int health_as_score;
	// Use this for initialization
	void Start () {
        health_as_score = health;
        amin_of_destroying = GetComponent<Animator>();
        SPrender = GetComponent<SpriteRenderer>();
        gamecontorol = GameObject.FindObjectOfType<GameContorol>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.position+=Vector3.down * speedofastrodformoving * Time.deltaTime;
        transform.Rotate(Vector3.forward*speedofastrodforrotating*Time.deltaTime);
	}
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "friend_bulet")
        {
            health = health - col.gameObject.GetComponent<shootingsimpelboolet>().power;
        }
            if (health <= 0)
            {
                int rnd = Random.Range(0, 6);
                if (rnd % 2 == 0) { Instantiate(coinspawner, transform.position, Quaternion.identity); }
                gamecontorol.addscore(health_as_score);
                Instantiate(explosion, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
            else
            {
                check_method();
            }
    }
    void check_method()
    {
        if (amin_of_destroying != null)
        {
            amin_of_destroying.SetInteger("health", health);
        }
        else
        {
            SPrender.sprite = healthsprits[health - 1];
        }
    }
}
