using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class buletnumbercounter : MonoBehaviour {
    public  Text buletnumbers;
    public int BoundOfDangerOFbulet;
    public Sprite redmood_bulet;
    public Sprite bluemood_bulet;
    public Image mainHud2;
    public void show_quantity_bulet(int num)
    {
        buletnumbers.text = num.ToString();
        if (num >= BoundOfDangerOFbulet)
        {
            mainHud2.sprite = bluemood_bulet;
        }
        else
        {
            mainHud2.sprite = redmood_bulet;
        }
    }
    public void DeActive_1()
    {
        gameObject.SetActive(false);
    }
}
