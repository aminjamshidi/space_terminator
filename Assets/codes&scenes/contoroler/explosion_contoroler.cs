using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion_contoroler : MonoBehaviour {
    public Animator anim_explosion;
	// Use this for initialization
	void Start () {
        StartCoroutine(DestroyThis());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private IEnumerator  DestroyThis(){
        yield return new WaitForSeconds(anim_explosion.GetCurrentAnimatorStateInfo(0).length);
        Destroy(gameObject);
    }
}
