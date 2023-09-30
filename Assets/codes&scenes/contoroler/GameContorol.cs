using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameContorol : MonoBehaviour {
    public int Score { get { return score; } }
    private int score;
    public int NumberBulet { get { return numberbulet; } }
    private int numberbulet;
    private int coinnumber;
    public hudcontoroler hudcontorol;
    public buletnumbercounter counterbulet;
    public CoinRepository coinrepo;
    public ScaoreReository scorerepo;
    public ShipRepository shiprepo;
    public joystick JOYStick;
    public WinGameoverPLNManage PLNWinOrGameover;
    public void addscore(int x)
    {
        if (x > 0)
        {
            score += x;
            hudcontorol.setscore(score);
        }
    }
    public void SETnumberOf_bulets()
    {
        numberbulet -= 1;
        counterbulet.show_quantity_bulet(numberbulet);
    }
    public void SetHealthQuantity(float a)
    {
        hudcontorol.Set_txthealthpercent(a);
    }
    public void setquantity_coinnumber()
    {
        coinnumber += 1;
    }
	void Start () {
        PLNWinOrGameover.gameObject.SetActive(false);
        GameObject shipobject;
        shipobject=(GameObject)Instantiate(shiprepo.GetCurrenShip().shipprefab, Vector3.zero, Quaternion.identity);
        JOYStick.ATTACH(shipobject .GetComponent<rocketship>());
        shipobject .GetComponent<rocketship>().InIt(shiprepo.GetCurrenShip().speed,shiprepo.GetCurrenShip().health,shiprepo.GetCurrenShip().FireRate);
        score = 0;
        hudcontorol.setscore(score);
        numberbulet = 100;
        counterbulet.show_quantity_bulet(numberbulet);
        Debug.Log("lastOne="+scorerepo.ShowLastOne()+"and HightOne="+scorerepo.ShowHigthOne());
	}
    private void OnApplicationQuit()
    {
        coinrepo.Push(coinnumber);
        scorerepo.Push(score);
    }
    public void WIN()
    {
        PLNWinOrGameover.gameObject.SetActive(true);
        PLNWinOrGameover.CheckWin(true);
    }
    public void GAMEOVER()
    {
        PLNWinOrGameover.gameObject.SetActive(true);
        PLNWinOrGameover.CheckWin(false);
        JOYStick.DETTACH();
        hudcontorol.DeActive();
        counterbulet.DeActive_1();
    }
}
