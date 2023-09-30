using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joystick : MonoBehaviour {
    public GameObject  fierbutton;
    public GameObject moveingbutton;
    private rocketship rocket;
    public void FIRE()
    {
        rocket.FIRE_FUNCTION();
    }
    public void MOVEUP()
    {
        rocket.moveup();
    }
    public void MOVEDOWN()
    {
        rocket.movedown();
    }
    public void MOVELEFT()
    {
        rocket.moveleft();
    }
    public void MOVERIGHT()
    {
        rocket.moveright();
    }
    public void STOP_GAMEOBJECT()
    {
        rocket.stoping();
    }
    public void ATTACH(rocketship R)
    {
        rocket = R;
        ActiveOrDeactive(true);

    }
    public void DETTACH()
    {
        rocket = null;
        ActiveOrDeactive(false);
    }

    public void ActiveOrDeactive(bool mood)
    {
        fierbutton.gameObject.SetActive(mood);
        moveingbutton.gameObject.SetActive(mood);
    }
    private void Start()
    {
        if (rocket == null)
        {
            ActiveOrDeactive(false);
        }
    }
}
