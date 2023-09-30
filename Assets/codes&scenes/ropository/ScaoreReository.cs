using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaoreReository : MonoBehaviour {
    private const string LastScorerepository = "lastscorRepo";
    private const string HigthScorerepository = "HigthscorRepo";
    public int ShowHigthOne()
    {
        return PlayerPrefs.GetInt(HigthScorerepository);
    }
    public int ShowLastOne()
    {
        return PlayerPrefs.GetInt(LastScorerepository);
    }
    public void SaveScore(string key, int s)
    {
        PlayerPrefs.SetInt(key, s);
    }
    public void Push(int s){
        SaveScore(LastScorerepository, s);
        int h = ShowHigthOne();
        if (s > h)
        {
            SaveScore(HigthScorerepository, s);
        }
    }
}
