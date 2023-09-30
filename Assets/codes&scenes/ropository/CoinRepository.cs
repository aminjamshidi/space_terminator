using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRepository : MonoBehaviour {
    private const string nameRepository = "coinrespository";
    private int coins;

    public bool Pop(int count)
    {
        if (HasCoin(count))
        {
            coins = coins - count;
            SaveRepo();
            return true;
        }
        return false;
    }
    public void Push(int count)
    {
        coins = coins + count;
        SaveRepo();
    }
    public void Save(int count)
    {
        SaveRepo();
    }
    public int  Show()
    {
        return coins;
    }
    private bool HasCoin(int count)
    {
        if (coins >= count)
        {
            return true;
        }
        else { return false; }
    }
    private void Start()
    {
        if (PlayerPrefs.HasKey(nameRepository))
        {
            coins = PlayerPrefs.GetInt(nameRepository);
        }
        else { coins = 0; }
    }
    private void SaveRepo()
    {
        PlayerPrefs.SetInt(nameRepository,coins );
    }

}
