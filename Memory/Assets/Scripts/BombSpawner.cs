using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : MonoBehaviour
{

    
    [SerializeField]
    GameObject bullet;
    public bool speedable = true;
    public float random;
    public float fireRate;
    public float nextFire = 5;
    // Use this for initialization
    void Start()
    {
        fireRate = Random.Range(15f, 30f);
        nextFire = Time.time;
        random = Random.Range(15, 30);
    }

    // Update is called once per frame
    void Update()
    {
        
        CheckIfTimeToFire();
        randomlababa();
        StartCoroutine(baslangic());


    }
    IEnumerator randomlababa()
    {
        yield return new WaitForSeconds(2);
        fireRate = Random.Range(15, 30);
        


    }
    void CheckIfTimeToFire()
    {


    }
   
    IEnumerator baslangic()
    {
        yield return new WaitForSecondsRealtime(random);
        if (Time.time > nextFire)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
        }

    }

}