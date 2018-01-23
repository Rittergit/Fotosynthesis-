using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplaceObject : MonoBehaviour {

    public GameObject blume1;
    public GameObject blume2;
    public GameObject blume3;
    public GameObject positionempty;
    public Animator ani;
    Vector3 pos;
    Vector3 pos2;
    private int replacer = 0;

    private void Start()
    {
        pos = new Vector3(0, positionempty.transform.position.y, 0);
        ani.enabled = false;
        pos2 = new Vector3(0,10000000,0);
    }

    void replace()
    {
        switch(replacer)
        {
            case 0:
                blume1.transform.position = pos;
                blume2.transform.position = pos2;
                blume3.transform.position = pos2;
                ani.enabled = false;
                break;
            case 1:
                blume1.transform.position = pos2;
                blume2.transform.position = pos;
                blume3.transform.position = pos2;
                ani.enabled = true;
                break;
            case 2:
                blume1.transform.position = pos2;
                blume2.transform.position = pos2;
                blume3.transform.position = pos;
                ani.enabled = false;
                break;
        }
    }

    public void setblume1()
    {
        replacer = 0;
        replace();
    }

    public void setblume2()
    {
        replacer = 1;
        replace();
    }

    public void setblume3()
    {
        replacer = 2;
        replace();
    }

   
}
