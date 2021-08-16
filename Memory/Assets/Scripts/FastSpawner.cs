using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastSpawner : MonoBehaviour
{


    [SerializeField]
    GameObject bullet;
    public bool speedable = true;

    public float fireRate;
    public float nextFire = 5;
    public float faster = 0.8f;
    // Use this for initialization
    void Start()
    {
        fireRate = Random.Range(5, 10);
        nextFire = Time.time;
       
    }

    // Update is called once per frame
    void Update()
    {
        
        CheckIfTimeToFire();
        StartCoroutine(randomlababa());
        StartCoroutine(baslangic());


    }

    void CheckIfTimeToFire()
    {
       

    }
    IEnumerator randomlababa()
    {
        yield return new WaitForSeconds(2);
        fireRate = Random.Range(3, 22);



    }
    IEnumerator baslangic()
    {
        yield return new WaitForSeconds(12);
        if (Time.time > nextFire)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
        }

    }

}