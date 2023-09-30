using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swapnerOfcoins : MonoBehaviour {
    public GameObject coinprefab;
    public int limitation_prize1;
    public int limitation_prize2;
    private int numberOfcoin;
	// Use this for initialization
	void Start () {
        numberOfcoin = Random.Range(limitation_prize1, limitation_prize2);
        for (int i = 1; i <= numberOfcoin; i++)
        {
            Instantiate(coinprefab, transform.position, Quaternion.identity);
        }
        Destroy(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
