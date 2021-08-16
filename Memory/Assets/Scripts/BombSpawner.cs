using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : MonoBehaviour
{


    [SerializeField]
    GameObject bullet;
    public bool speedable = true;

    public float fireRate = 10;
    public float nextFire = 4;
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
        randomlababa();
        StartCoroutine(baslangic());


    }
    IEnumerator randomlababa()
    {
        yield return new WaitForSeconds(2);
        fireRate = Random.Range(10, 18);



    }
    void CheckIfTimeToFire()
    {


    }
   
    IEnumerator baslangic()
    {
        yield return new WaitForSeconds(16);
        if (Time.time > nextFire)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
        }

    }

}