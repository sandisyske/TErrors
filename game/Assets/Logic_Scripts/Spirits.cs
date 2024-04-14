using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spirits : MonoBehaviour
{
    private KeyCode nupp;
    private GameObject summon;



    void Call() 
    {
        Instantiate(summon);
    }

}


public class Spirit1 : Spirits 
{

    private KeyCode nupp = KeyCode.Alpha1;
    private GameObject summon;

    public Spirit1( GameObject summon)
    {
        this.summon = summon;
    }

    void Call()
    {
        Instantiate(summon);
    }

}



public class Spirit2 : Spirits
{
    private KeyCode nupp = KeyCode.Alpha2;
    private GameObject summon;

    public Spirit2(GameObject summon)
    {
        this.summon = summon;
    }
    void Call()
    {
        Instantiate(summon);
    }
}



public class Spirit3 : Spirits
{
    private KeyCode nupp = KeyCode.Alpha3;
    private GameObject summon;

    public Spirit3(GameObject summon)
    {
        this.summon = summon;
    }
    void Call()
    {
        Instantiate(summon);
    }
}
