using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Character : MonoBehaviour
{
    public GameObject sag;

    public Joystick joystick;

    public GameObject sol;

    public GameObject asagi;

    public GameObject yukari;

    public GameObject PM;
    
    public bool anan;


    /*
public SpriteRenderer render;
public Sprite sprite1;
public Sprite sprite2;
public Sprite sprite3;
    */

    void OnTriggerEnter2D(Collider2D col)
{
    if (col.gameObject.tag == ("Bullet"))
    {
        Debug.Log("Hit!");
        PM.SetActive(true);
        anan = true;
        Time.timeScale = 0f;
    }
}

    void Start()
{
    sol.SetActive(false);
    sag.SetActive(false);
    asagi.SetActive(false);
    yukari.SetActive(false);
    PM.SetActive(false);
    Time.timeScale = 1f;
}

// Update is called once per frame
void Update()
{

    if (Input.GetKeyDown(KeyCode.A))
    {
        sol.SetActive(true);
        StartCoroutine(Sola());
    }
    if (Input.GetKeyDown(KeyCode.D))
    {
        sag.SetActive(true);
        StartCoroutine(Saga());
    }
    if (Input.GetKeyDown(KeyCode.W))
    {
        yukari.SetActive(true);
        StartCoroutine(Yukariya());
    }
    if (Input.GetKeyDown(KeyCode.S))
    {
        asagi.SetActive(true);
        StartCoroutine(Asagiya());
    }

    /*
    if (PlayerPrefs.GetString("skin") == "skin1")
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

    /*
    if(Swipe.swipeRight)
    {
        sag.SetActive(true);
        StartCoroutine(Saga());
    }
    if (Swipe.swipeLeft)
    {
        sol.SetActive(true);
        StartCoroutine(Sola());
    }
    if (Swipe.swipeUp)
    {
        yukari.SetActive(true);
        StartCoroutine(Yukariya());
    }
    if (Swipe.swipeDown)
    {
        asagi.SetActive(true);
        StartCoroutine(Asagiya());
    }
    */
}



IEnumerator Saga()
    {
        yield return new WaitForSeconds(0.5f);
        sag.SetActive(false);
        
    }
    IEnumerator Sola()
    {
        yield return new WaitForSeconds(0.5f);
        sol.SetActive(false);
        
    }
    IEnumerator Asagiya()
    {
        yield return new WaitForSeconds(0.5f);
        asagi.SetActive(false);
        
    }
    IEnumerator Yukariya()
    {
        yield return new WaitForSeconds(0.5f);
        yukari.SetActive(false);

    }




public void solaz(){
        
            sol.SetActive(true);
            StartCoroutine(Sola());

}
public void sagaz() {
        
         sag.SetActive(true);
         StartCoroutine(Saga());
         }
public void asagiyaz()
    {

        asagi.SetActive(true);
        StartCoroutine(Asagiya());
    }
public void yukariyaz()
    {

        yukari.SetActive(true);
        StartCoroutine(Yukariya());
    }



}
