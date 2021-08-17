using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Discord;

public class Discord2 : MonoBehaviour
{
    string discordscorestring;
    public string discordhighscore;
    Discord.Discord discord;
    Discord.ActivityManager activityManager;
    public string discordscore;
    string discorddetails;
    public static Discord2 instance;
    public GameObject scoregameobject;
    public ScoreScript score;
    public int scene;
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

    }
    void Start()
    {

        

        discord = new Discord.Discord(877155800722858025, (uint)Discord.CreateFlags.Default);
        activityManager = discord.GetActivityManager();
        UpdatePresence();



    }

    // Update is called once per frame
    void Update()
    {
        discordhighscore = PlayerPrefs.GetFloat("highscore").ToString();
        discord.RunCallbacks();
        UpdatePresence();
        scene = SceneManager.GetActiveScene().buildIndex;
        
        if( scene == 0)
        {
            discorddetails = "Daha Menüde";


        }
        if (scene == 1)
        {
            discorddetails = "Düşmanları Kesiliyor";
            scoregameobject = GameObject.Find("score");
            score = (ScoreScript)scoregameobject.GetComponent(typeof(ScoreScript));

        }
        if (scene == 2)
        {
            discorddetails = "Shopta Geziniyor";


        }
        if (scene == 3)
        {
            discorddetails = "Shopta Geziniyor";


        }




        if (score == null)
        {
            discordscore = discordhighscore;
            discordscorestring = "HighScore ";

        }
        else
        {
            discordscore = score.intscore.ToString();
            discordscorestring = "Score ";
        }
    }
    void UpdatePresence()
    {
        activityManager.UpdateActivity(new Discord.Activity
        {
            Details = discorddetails,
            State = discordscorestring + discordscore,
            Assets = {
                LargeImage = "resized-image-promo_1_",
                LargeText = "Splashing"
            }
        }, (res) => { });
    }
}
