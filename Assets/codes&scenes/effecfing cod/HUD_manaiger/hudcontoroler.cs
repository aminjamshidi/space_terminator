using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class hudcontoroler : MonoBehaviour {
    public Text txthealthpercnt;
    public Text txtscorerate;
    public float BoundDangerOfLife;
    public Sprite redmood_life;
    public Sprite bluemood_life;
    public Image mainHud;
	// Use this for initialization
    public void setscore(int score)
    {
        txtscorerate.text = score + "";
    }
    public void Set_txthealthpercent(float lifepercent)
    {
        txthealthpercnt.text = lifepercent+"";
        if (lifepercent >=BoundDangerOfLife)
        {
            mainHud.sprite = bluemood_life;
        }
        else { mainHud.sprite = redmood_life;}
    }
    public void DeActive()
    {
        gameObject.SetActive(false);
    }
}
