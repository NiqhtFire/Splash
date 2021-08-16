using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trail : MonoBehaviour
{Vector3 lastMousePosition;
    public GameObject obje;
    public int scene;
    private Animator anim;
    public ParticleSystem slice;
    void Start()
    {
        Cursor.visible = false;
        Time.timeScale = 1.0f;
        anim = GetComponent<Animator>();
    }
    
    // Update is called once per frame
    void Update()

    {
        
        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = pos;
        
        if(Time.timeScale == 0) {


            gameObject.GetComponent<TrailRenderer>().enabled = false;
            GetComponent<TrailRenderer>().Clear();

        }
        
        if (Input.mousePosition != lastMousePosition) 
        {
            lastMousePosition = Input.mousePosition;
     

        }
        if (Input.GetMouseButton(0) == true)
        {
            
            gameObject.GetComponent<TrailRenderer>().enabled = true;
            
        }
        else
        {
            gameObject.GetComponent<TrailRenderer>().enabled = false;
        }

        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == ("Bullet"))
        {

            CreateSlice();


        }
    }
    void CreateSlice()
    {
        slice.Play();
    }
}
