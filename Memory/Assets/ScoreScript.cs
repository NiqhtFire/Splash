using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreScript : MonoBehaviour
{
  
    public Text scoreText;
    public Text highscore;
    public float score;
    public float pointsecond;
    public Character cha;
    public Text coin;
    private int coinz;
   
    void Start()
    {
        score = 0f;
        pointsecond = 2;
        highscore.text = PlayerPrefs.GetFloat("highscore", 0).ToString();
        coin.text = PlayerPrefs.GetFloat("coin", 0).ToString();
        
    }

    // Update is called once per frame
    void Update()
    {


        coin.text = PlayerPrefs.GetFloat("coin").ToString();
        scoreText.text = "Score " + (int)score;
        score += pointsecond * Time.deltaTime;
       
        if (score > PlayerPrefs.GetFloat("highscore", 0))
        {
            PlayerPrefs.SetFloat("highscore", (int)score);
            highscore.text = PlayerPrefs.GetFloat("highscore", 0).ToString();
        }

        if (cha.anan == true)
        {
            PlayerPrefs.SetFloat("coin", PlayerPrefs.GetFloat("coin") + (int)score / 4);
            cha.anan = false;
        }
        
    }

}