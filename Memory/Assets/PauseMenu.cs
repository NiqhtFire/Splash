using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public static bool GamePaused = false;
    
    public GameObject PMenuUI;
    public static PauseMenu a;
    public float coin;
    [SerializeField] public int backLEVEL;
    private int currentLEVEL;
    private void Start()
    {
       
      

    }
    private void Awake()
    {
        if (a == null)
            a = this;

        else
        {
            Destroy(gameObject);

            return;
        }

    }// Update is called once per frame
    void Update()
    {
       
    }
    public void Retry()
    {
        PMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GamePaused = false;
        SceneManager.LoadScene(1);
    }

    public void LoadMenu()
    {
        
        SceneManager.LoadScene(0);
        


    }
    public void Shop()
    {

        SceneManager.LoadScene(2);



    }

    public void QuitGame()
    {
        Application.Quit();
    }
    
    public void Back()
    {
        SceneManager.LoadScene(0);
    }
   
    
}