using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinGameoverPLNManage : MonoBehaviour {
    public Text txtwinOrgameover;
    private const string MassageWin = "°¨nIM";
    private const string MassageGameover = "!Ájp k¹¬";
    public void CheckWin(bool m)
    {
        SETtxtMassage(m);
    }
    private  void SETtxtMassage(bool x)
    {
        if(x){
            txtwinOrgameover.text=MassageWin;
        }else{txtwinOrgameover.text=MassageGameover;}
    }
}
