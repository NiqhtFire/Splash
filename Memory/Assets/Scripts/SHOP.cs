using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SHOP : MonoBehaviour
{
    public Text buyvv1;
    public Text buyvv2;
    public Text buyvv3;
  
    void Start()
    {

        if (PlayerPrefs.GetString("buyvv2") != "use")
        {
            PlayerPrefs.SetString("buyvv2", "Buy");


        }
        if (PlayerPrefs.GetString("buyvv3") != "use")
        {
            PlayerPrefs.SetString("buyvv3", "Buy");


        }
        if (PlayerPrefs.GetString("buyvv1") != "use")
        {
            PlayerPrefs.SetString("buyvv1", "Buy");


        }
        if (PlayerPrefs.GetString("buyvv3") != "use")
        {
            PlayerPrefs.SetString("buyvv3", "Buy");


        }
    }

    // Update is called once per frame
    void Update()
    {
        buyvv1.text = PlayerPrefs.GetString("buyvv1");
        
        buyvv2.text = PlayerPrefs.GetString("buyvv2");
        buyvv3.text = PlayerPrefs.GetString("buyvv3");
    }
    public void buy1()
    {
        if (PlayerPrefs.GetFloat("coin") >= 500 && PlayerPrefs.GetString("buyvv1") == "Buy")
        {


            PlayerPrefs.SetString("buyvv1", "use");
            PlayerPrefs.SetFloat("coin", PlayerPrefs.GetFloat("coin") - 750);



        }
        if (PlayerPrefs.GetString("buyvv1") == "use")
        {
            PlayerPrefs.SetString("skin", "skin1");
            Debug.Log("anananaana");

        }
    }
    public void buy2()
    {
        if (PlayerPrefs.GetFloat("coin") >= 1500 && PlayerPrefs.GetString("buyvv2") == "Buy")
        {


            PlayerPrefs.SetString("buyvv2", "use");
            PlayerPrefs.SetFloat("coin", PlayerPrefs.GetFloat("coin") - 800);



        }
        if (PlayerPrefs.GetString("buyvv2") == "use")
        {
            PlayerPrefs.SetString("skin", "skin2");
            Debug.Log("anananaana");

        }

    }
    public void buy3()
    {
        if (PlayerPrefs.GetFloat("coin") >= 2500 && PlayerPrefs.GetString("buyvv3") == "Buy")
        {


            PlayerPrefs.SetString("buyvv3", "use");
            PlayerPrefs.SetFloat("coin", PlayerPrefs.GetFloat("coin") - 900);



        }
        if (PlayerPrefs.GetString("buyvv3") == "use")
        {
            PlayerPrefs.SetString("skin", "skin3");
            Debug.Log("anananaana");

        }

    }
    public void Back()
    {
        SceneManager.LoadScene(0);
    }

    public void NextPage()
    {
        SceneManager.LoadScene(3);
            
    }

   


}
