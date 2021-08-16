using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skinshower : MonoBehaviour
{
    public SpriteRenderer render;
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public Sprite spritev1;
    public Sprite spritev2;
    public Sprite spritev3;
    public Sprite spritev4;
    public Sprite spritev5;
    public Sprite spritev6;
    public Sprite spritev7;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.GetString("skin") == "skin1")
        {
            render.sprite = sprite1;
        }
        if (PlayerPrefs.GetString("skin") == "skin2")
        {
            render.sprite = sprite2;
        }
        if (PlayerPrefs.GetString("skin") == "skin3")
        {
            render.sprite = sprite3;
        }
        if (PlayerPrefs.GetString("skin") == "skinv1")
        {
            render.sprite = spritev1;
        }
        if (PlayerPrefs.GetString("skin") == "skinv2")
        {
            render.sprite = spritev2;
        }
        if (PlayerPrefs.GetString("skin") == "skinv3")
        {
            render.sprite = spritev3;
        }
        if (PlayerPrefs.GetString("skin") == "skinv4")
        {
            render.sprite = spritev4;
        }
        if (PlayerPrefs.GetString("skin") == "skinv5")
        {
            render.sprite = spritev5;
        }
        if (PlayerPrefs.GetString("skin") == "skinv6")
        {
            render.sprite = spritev6;
        }
        if (PlayerPrefs.GetString("skin") == "skinv7")
        {
            render.sprite = spritev7; 
        }


    }
}
