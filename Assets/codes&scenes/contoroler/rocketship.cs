using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketship : MonoBehaviour {
    Transform dots;
    [SerializeField]GameObject boolet;
    private  int speed;
    private int _health;
    [SerializeField]GameObject[] guns;
    private float x;
    private float y;
    private  float fireRate;
    public Animator flam_anima;
    public GameContorol gamecontorol_1;
    public GameObject exploding;
    private float lastSHot=0;
    private float SavequantityOflife;
    public int Health { get { return _health; } }
	// Use this for initialization
    public void InIt(int _s, int _h, float _f)
    {
        speed = _s;
        _health = _h;
        fireRate = _f;
    }
    public void FIRE_FUNCTION()
    {
        if (Time.time > fireRate + lastSHot)
        {
            fire_gun();
            lastSHot = Time.time;
        }
    }
    public void moveup()
    {
        y = 1;
    }
    public void movedown()
    {
        y = -1;
    }
    public void moveright()
    {
        x = 1;
    }
    public void moveleft()
    {
        x = -1;
    }
    public void stoping()
    {
        x = 0;
        y = 0;
    }
	void Start () {
        gamecontorol_1 = GameObject.FindObjectOfType<GameContorol>();
        dots = GetComponent<Transform>();
        SavequantityOflife = _health;
	}
	
	// Update is called once per frame
	void Update () {
        check_for_inputofkeyboard();
        Vector3 move = new Vector3(x, y, 0) * speed * Time.deltaTime;
        dots.position += move;
        flam_anima.SetFloat("speed", move.sqrMagnitude);
         checkingofbondofrocket();
         if (Input.GetKeyDown(KeyCode.Space))
         {
             if (Time.time > fireRate + lastSHot)
             {
                 fire_gun();
                 lastSHot = Time.time;
             }
         }
      }

    private void check_for_inputofkeyboard()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow)) { moveright(); }
        if (Input.GetKeyDown(KeyCode.LeftArrow)) { moveleft(); }
        if (Input.GetKeyDown(KeyCode.UpArrow)) { moveup(); }
        if (Input.GetKeyDown(KeyCode.DownArrow)) { movedown(); }
        if (Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow)) { stoping(); }
    }

    private void fire_gun()
    {
        for (int i = 0; i < guns.Length; i++)
        {
            if (gamecontorol_1.NumberBulet>0)
            {
                Instantiate(boolet, guns[i].transform.position, Quaternion.identity);
                gamecontorol_1.SETnumberOf_bulets();
            }
        }
    }
    private void checkingofbondofrocket()
    {
        dots.position = new Vector3(
            Mathf.Clamp(dots.position.x, -8f, 7.95f),
            Mathf.Clamp(dots.position.y, -4.5f, 4.5f),
            0
            );
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "astroid")
        {
            _health -= col.gameObject.GetComponent<Asteroidcontoroler>().health;
            calculating_of_lifepercent();
            checkinghealth();
        }
        else if (col.gameObject.tag == "enemy_bulet_ship")
        {
            _health -= col.gameObject.GetComponent<shootingsimpelboolet>().power;
            calculating_of_lifepercent();
            checkinghealth();
        }
        else if (col.gameObject.tag == "enemy_ship")
        {
            _health -= col.gameObject.GetComponent<contorolerofenemyspaceship>().health;
            calculating_of_lifepercent();
            checkinghealth();
        }
        }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "coin")
        {
            gamecontorol_1.setquantity_coinnumber();
            Destroy(col.gameObject);
        }
    }
    private void checkinghealth()
    {
        if (_health <= 0)
        {
            Instantiate(exploding, transform.position, Quaternion.identity);
            gamecontorol_1.GAMEOVER();
            Destroy(gameObject);
        }
    }
    private void calculating_of_lifepercent()
    {
        float u;
        u = (_health / SavequantityOflife) * 100;
        gamecontorol_1.SetHealthQuantity(u);
    }
    }

