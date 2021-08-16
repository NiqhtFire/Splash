using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopM : MonoBehaviour
{
    public Text coint;
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        coint.text = PlayerPrefs.GetFloat("coin").ToString();
    }
}
