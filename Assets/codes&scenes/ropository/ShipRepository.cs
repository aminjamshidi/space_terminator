using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipRepository : MonoBehaviour {
    public enum ships{green1, green2, green3, red1, red2, red3, blue1, blue2, blue3}
    public enum buletType { laser,rocket,bomb}
    [System.Serializable]public struct ship
    {
        public GameObject shipprefab;
        public ships shipnumber;
        [Range(1,10)]
        public int speed;
        [Range(0,1)]
        public float FireRate;
        [Range(1,3)]
        public int number_guns;
        [Range (1,6)]
        public int health;
        public buletType type_bulet;
        public string model;
        public bool locked;
        public int price;
        [Range(1,3)]
        public int powerbulet;
    }
    private const string CurrentShipRepo = "currentshiprepo";
    private const string ShipRepo = "shiprepo";
    public ship[] ships_prefab;
    public void SetCurrentShip()
    {}
    public ship GetCurrenShip()
    {
        return ships_prefab[PlayerPrefs.GetInt(CurrentShipRepo)];
    }
    public void ActiveNewShip(){}
    private  void Awake()
    {
        int rnd;
        rnd = Random.Range(0, ships_prefab.Length);
        PlayerPrefs.SetInt(CurrentShipRepo, rnd);
    } 
}
