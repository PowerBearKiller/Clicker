using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Shop : MonoBehaviour
{
    public int money;


    void Start()
    {
        money = PlayerPrefs.GetInt("money");

    }

    public void BuyAxe()
    {
        if (money >= 40)
        {
            money = money - 40;
        }
    }
   
    void Update()
    {
        
    }
}
