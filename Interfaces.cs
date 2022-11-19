using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Interfaces : MonoBehaviour
{
    public void Ak47()
    {
        Debug.Log("Is an Assault Rifle");
        Debug.Log("Fires 7.62mm bullets");
    }

    public void pistol()
    {
        Debug.Log("Is an SMG");
        Debug.Log("Fires 9mm bullets");
    }
    public void DLQ33()
    {
        Debug.Log("Is an Sniper");
        Debug.Log("Long Range Weapon");
    }
    public virtual void Multiply(int x,int y)
    {
        Debug.Log(x + y);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
}
