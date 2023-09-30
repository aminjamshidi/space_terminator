using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerastroid : MonoBehaviour {
    public GameObject[] astroidbulet;
    public float limitationtime1;
    public float limitationtime2;
	// Use this for initialization
	void Start () {
        InvokeRepeating("throwing", 1, Random.Range(limitationtime1, limitationtime2));
	}

    private void throwing()
    {
        Vector3 nowPOSITION;
        nowPOSITION =transform.position;
        nowPOSITION+=new Vector3(Random.Range(-7.7f,7.7f),0,0);
        Instantiate(astroidbulet[Random.Range(0,astroidbulet.Length)],nowPOSITION,Quaternion.identity);
    }
}
