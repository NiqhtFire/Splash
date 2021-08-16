using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SHOP21 : MonoBehaviour
{

    public Text buyv1;
    public Text buyv2;
    public Text buyv3;
    public Text buyv4;
    public Text buyv5;
    public Text buyv6;
    public Text buyv7;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetString("buyv1") != "use")
        {
            PlayerPrefs.SetString("buyv1", "Buy");


        }
        if (PlayerPrefs.GetString("buyv2") != "use")
        {
            PlayerPrefs.SetString("buyv2", "Buy");


        }
        if (PlayerPrefs.GetString("buyv3") != "use")
        {
            PlayerPrefs.SetString("buyv3", "Buy");


        }
        if (PlayerPrefs.GetString("buyv4") != "use")
        {
            PlayerPrefs.SetString("buyv4", "Buy");


        }
        if (PlayerPrefs.GetString("buyv5") != "use")
        {
            PlayerPrefs.SetString("buyv5", "Buy");


        }
        if (PlayerPrefs.GetString("buyv6") != "use")
        {
            PlayerPrefs.SetString("buyv6", "Buy");


        }
        if (PlayerPrefs.GetString("buyv7") != "use")
        {
            PlayerPrefs.SetString("buyv7", "Buy");


        }
    }

    // Update is called once per frame
    void Update()
    {
        buyv1.text = PlayerPrefs.GetString("buyv1");

        buyv2.text = PlayerPrefs.GetString("buyv2");

        buyv3.text = PlayerPrefs.GetString("buyv3");

        buyv4.text = PlayerPrefs.GetString("buyv4");

        buyv5.text = PlayerPrefs.GetString("buyv5");

        buyv6.text = PlayerPrefs.GetString("buyv6");

        buyv7.text = PlayerPrefs.GetString("buyv7");
    }
    public void buy1()
    {
        if (PlayerPrefs.GetFloat("coin") >= 500 && PlayerPrefs.GetString("buyv1") == "Buy")
        {


            PlayerPrefs.SetString("buyv1", "use");
            PlayerPrefs.SetFloat("coin", PlayerPrefs.GetFloat("coin") - 500);



        }
        if (PlayerPrefs.GetString("buyv1") == "use")
        {
            PlayerPrefs.SetString("skin", "skinv1");
            Debug.Log("anananaana");

        }
    }
    public void buy2()
    {
        if (PlayerPrefs.GetFloat("coin") >= 600 && PlayerPrefs.GetString("buyv2") == "Buy")
        {


            PlayerPrefs.SetString("buyv2", "use");
            PlayerPrefs.SetFloat("coin", PlayerPrefs.GetFloat("coin") - 600);



        }
        if (PlayerPrefs.GetString("buyv2") == "use")
        {
            PlayerPrefs.SetString("skin", "skinv2");
            Debug.Log("anananaana");

        }

    }
    public void buy3()
    {
        if (PlayerPrefs.GetFloat("coin") >= 300 && PlayerPrefs.GetString("buyv3") == "Buy")
        {


            PlayerPrefs.SetString("buyv3", "use");
            PlayerPrefs.SetFloat("coin", PlayerPrefs.GetFloat("coin") - 300);



        }
        if (PlayerPrefs.GetString("buyv3") == "use")
        {
            PlayerPrefs.SetString("skin", "skinv3");
            Debug.Log("anananaana");

        }

    }
    public void buy4()
    {
        if (PlayerPrefs.GetFloat("coin") >= 300 && PlayerPrefs.GetString("buyv4") == "Buy")
        {


            PlayerPrefs.SetString("buyv4", "use");
            PlayerPrefs.SetFloat("coin", PlayerPrefs.GetFloat("coin") - 300);



        }
        if (PlayerPrefs.GetString("buyv4") == "use")
        {
            PlayerPrefs.SetString("skin", "skinv4");
            Debug.Log("anananaana");

        }
    }
    public void buy5()
    {
        if (PlayerPrefs.GetFloat("coin") >= 300 && PlayerPrefs.GetString("buyv5") == "Buy")
        {


            PlayerPrefs.SetString("buyv5", "use");
            PlayerPrefs.SetFloat("coin", PlayerPrefs.GetFloat("coin") - 300);



        }
        if (PlayerPrefs.GetString("buyv5") == "use")
        {
            PlayerPrefs.SetString("skin", "skinv5");
            Debug.Log("anananaana");

        }

    }
    public void buy6()
    {
        if (PlayerPrefs.GetFloat("coin") >= 300 && PlayerPrefs.GetString("buyv6") == "Buy")
        {


            PlayerPrefs.SetString("buyv6", "use");
            PlayerPrefs.SetFloat("coin", PlayerPrefs.GetFloat("coin") - 300);



        }
        if (PlayerPrefs.GetString("buyv6") == "use")
        {
            PlayerPrefs.SetString("skin", "skinv6");
            Debug.Log("anananaana");

        }

    }
    public void buy7()
    {
        if (PlayerPrefs.GetFloat("coin") >= 2000 && PlayerPrefs.GetString("buyv7") == "Buy")
        {


            PlayerPrefs.SetString("buyv7", "use");
            PlayerPrefs.SetFloat("coin", PlayerPrefs.GetFloat("coin") - 2000);



        }
        if (PlayerPrefs.GetString("buyv7") == "use")
        {
            PlayerPrefs.SetString("skin", "skinv7");
            Debug.Log("anananaana");

        }

    }
    public void BackPage()
    {
        SceneManager.LoadScene(2);
    }
}
