using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private int money;
    [SerializeField] private string many_money;
    [SerializeField] private int scale_axe;
    [SerializeField] private int scale_Drovosek;
    [SerializeField] private int scale_Brigada;
    [SerializeField] private int scale_Farm;
    [SerializeField] private int scale_Zavod;
    [SerializeField] private int scale_Fabric;
    
    [SerializeField] private int farm_axe;
    [SerializeField] private int farm_Drovosek;
    [SerializeField] private int farm_Brigada;
    [SerializeField] private int farm_Farm;
    [SerializeField] private int farm_Zavod;
    [SerializeField] private int farm_Fabric;
 
    [SerializeField] public int aps;
  
    public Text moneyText;
    public Text apsText;
    public Text scale_axeText;
    public Text scale_DrovosekText;
    public Text scale_BrigadaText;
    public Text scale_FarmText;
    public Text scale_ZavodText;
    public Text scale_FabricText;
   


    private void Start()

        
    {
        //Эта шляпа обнуляет все!!!! Раскоментировать для обнуления прогресса и заного закоментить!
        //PlayerPrefs.DeleteAll();
        aps = PlayerPrefs.GetInt("aps");
        money = PlayerPrefs.GetInt("money");
        

     
        scale_axe = PlayerPrefs.GetInt("scale_axe");
        scale_axeText.text = scale_axe.ToString();

        scale_Drovosek = PlayerPrefs.GetInt("scale_Drovosek");
        scale_DrovosekText.text = scale_Drovosek.ToString();

        scale_Brigada = PlayerPrefs.GetInt("scale_Brigada");
        scale_BrigadaText.text = scale_Brigada.ToString();

        scale_Farm = PlayerPrefs.GetInt("scale_Farm");
        scale_FarmText.text = scale_Farm.ToString();

        scale_Zavod = PlayerPrefs.GetInt("scale_Zavod");
        scale_ZavodText.text = scale_Zavod.ToString();

        scale_Fabric = PlayerPrefs.GetInt("scale_Fabric");
        scale_FabricText.text = scale_Fabric.ToString();

        farm_axe = PlayerPrefs.GetInt("farm_axe");
        farm_Drovosek = PlayerPrefs.GetInt("farm_Drovosek");
        farm_Brigada = PlayerPrefs.GetInt("farm_Brigada");
        farm_Farm = PlayerPrefs.GetInt("farm_Farm");
        farm_Zavod = PlayerPrefs.GetInt("farm_Zavod");
        farm_Fabric = PlayerPrefs.GetInt("farm_Fabric");

        StartCoroutine(FarmAxe());
        StartCoroutine(FarmDrovosek());
        StartCoroutine(FarmBrigada());
        StartCoroutine(FarmFarm());
        StartCoroutine(FarmZavod());
        StartCoroutine(FarmFabric());
      
        OfflineTime();
        
    }
    public void ButtonClick()
    {
        money++;
        PlayerPrefs.SetInt("money", money);

    }

    public void ToShop()
    {
        SceneManager.LoadScene(1);
    }

    public void ToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void BuyAxe()
    
        
    {
        if (scale_axe == 0)

            scale_axe = 1000;
        else
        {
            if (money >= scale_axe)
            {
                money = money - scale_axe;
                PlayerPrefs.SetInt("money", money);

                scale_axe = Convert.ToInt32(scale_axe * 1.3);
                farm_axe = farm_axe + 1;
                aps = aps + 1;
                PlayerPrefs.SetInt("aps", aps);
                PlayerPrefs.SetInt("farm_axe", farm_axe);
                PlayerPrefs.SetInt("scale_axe", scale_axe);
                scale_axeText.text = scale_axe.ToString();

            }
        }

        
            
    }
    public void BuyDrovosek()
    {
        if (scale_Drovosek == 0)
        
            scale_Drovosek = 10000;

            else
            {
                if (money >= scale_Drovosek)
                {
                    money = money - scale_Drovosek;
                    PlayerPrefs.SetInt("money", money);

                    scale_Drovosek = Convert.ToInt32(scale_Drovosek * 1.3);
                    farm_Drovosek = farm_Drovosek + 3;
                    aps = aps + 3;
                    PlayerPrefs.SetInt("aps", aps);
                    PlayerPrefs.SetInt("farm_Drovosek", farm_Drovosek);
                    PlayerPrefs.SetInt("scale_Drovosek", scale_Drovosek);
                    scale_DrovosekText.text = scale_Drovosek.ToString();

                }
            }
        
    }

    public void BuyBrigada()
    {
        if (scale_Brigada == 0)

            scale_Brigada = 60000;
        else
        {
            if (money >= scale_Brigada)
            {
                money = money - scale_Brigada;
                PlayerPrefs.SetInt("money", money);

                scale_Brigada = Convert.ToInt32(scale_Brigada * 1.3);
                farm_Brigada = farm_Brigada + 6;
                aps = aps + 6;
                PlayerPrefs.SetInt("aps", aps);
                PlayerPrefs.SetInt("farm_Brigada", farm_Brigada);
                PlayerPrefs.SetInt("scale_Brigada", scale_Brigada);
                scale_BrigadaText.text = scale_Brigada.ToString();

            }
        }
        

        
        
    }

    public void BuyFarm()
    {
        if (scale_Farm == 0)

            scale_Farm = 200000;
        else
        {
            if (money >= scale_Farm)
            {
                money = money - scale_Farm;
                PlayerPrefs.SetInt("money", money);

                scale_Farm = Convert.ToInt32(scale_Farm * 1.3);
                farm_Farm = farm_Farm + 20;
                aps = aps + 20;
                PlayerPrefs.SetInt("aps", aps);
                PlayerPrefs.SetInt("farm_Farm", farm_Farm);
                PlayerPrefs.SetInt("scale_Farm", scale_Farm);
                scale_FarmText.text = scale_Farm.ToString();

            }
        }

        
        
    }

    public void BuyZavod()
    {
        if (scale_Zavod == 0)

            scale_Zavod = 600000;
        else
        {
            if (money >= scale_Zavod)
            {
                money = money - scale_Zavod;
                PlayerPrefs.SetInt("money", money);

                scale_Zavod = Convert.ToInt32(scale_Zavod * 1.3);
                farm_Zavod = farm_Zavod + 40;
                aps = aps + 40;
                PlayerPrefs.SetInt("aps", aps);
                PlayerPrefs.SetInt("farm_Zavod", farm_Zavod);
                PlayerPrefs.SetInt("scale_Zavod", scale_Zavod);
                scale_ZavodText.text = scale_Zavod.ToString();

            }
        }

       
        
    }

    public void BuyFabric()
    {
        if (scale_Fabric == 0)

            scale_Fabric = 1000000;
        else
        {
            if (money >= scale_Fabric)
            {
                money = money - scale_Fabric;
                PlayerPrefs.SetInt("money", money);

                scale_Fabric = Convert.ToInt32(scale_Fabric * 1.3);
                farm_Fabric = farm_Fabric + 70;
                aps = aps + 70;
                PlayerPrefs.SetInt("aps", aps);
                PlayerPrefs.SetInt("farm_Fabric", farm_Fabric);
                PlayerPrefs.SetInt("scale_Fabric", scale_Fabric);
                scale_FabricText.text = scale_Fabric.ToString();

            }
        }

      
        
    }

    
    IEnumerator FarmAxe()
    {
        yield return new WaitForSeconds(1);
        money = money + farm_axe;
        PlayerPrefs.SetInt("money", money);
        StartCoroutine(FarmAxe());
    }
    IEnumerator FarmDrovosek()
    {
        yield return new WaitForSeconds(1);
        money = money + farm_Drovosek;
        PlayerPrefs.SetInt("money", money);
        StartCoroutine(FarmDrovosek());
    }

    IEnumerator FarmBrigada()
    {
        yield return new WaitForSeconds(1);
        money = money + farm_Brigada;
        PlayerPrefs.SetInt("money", money);
        StartCoroutine(FarmBrigada());
    }

    IEnumerator FarmFarm()
    {
        yield return new WaitForSeconds(1);
        money = money + farm_Farm;
        PlayerPrefs.SetInt("money", money);
        StartCoroutine(FarmFarm());
    }

    IEnumerator FarmZavod()
    {
        yield return new WaitForSeconds(1);
        money = money + farm_Zavod;
        PlayerPrefs.SetInt("money", money);
        StartCoroutine(FarmZavod());
    }

    IEnumerator FarmFabric()
    {
        yield return new WaitForSeconds(1);
        money = money + farm_Fabric;
        PlayerPrefs.SetInt("money", money);
        StartCoroutine(FarmFabric());
    }
   
    private void OfflineTime()
    {
        TimeSpan ts;
        if (PlayerPrefs.HasKey("LastSession"))
        {
            ts = DateTime.Now - DateTime.Parse(PlayerPrefs.GetString("LastSession"));
            money += aps*(int)ts.TotalSeconds;
        }
    }

#if UNITY_ANDROID && !UNITY_EDITOR
    private void OnApplication(bool pause)
    {
        if (pause)
        {
            PlayerPrefs.SetString("LastSession", DateTime.Now.ToString());
        }
    }
#else
    private void OnApplicationQuit()
    {
        PlayerPrefs.SetString("LastSession", DateTime.Now.ToString());
    }
#endif



    void Update()

    {
        if (money >= 1000000)
        {
            many_money = Convert.ToString(money / 1000000) + "." + Convert.ToString((money%1000000)/1000) + "KK";
            moneyText.text = many_money.ToString();
        }
        else
        {
            moneyText.text = money.ToString();
        }

       
        apsText.text = aps.ToString();
        
        
        scale_BrigadaText.text = scale_Brigada.ToString();
        scale_FarmText.text = scale_Farm.ToString();
        scale_ZavodText.text = scale_Zavod.ToString();
        scale_FabricText.text = scale_Fabric.ToString();
       
    }
}