using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    
    [SerializeField]
    GameObject bullet;
    public bool speedable = true;
    
    public float fireRate;
    public float nextFire;
    public float faster = 0.8f;
    // Use this for initialization
    void Start()
    {
 
        nextFire = Time.time;
        fireRate = Random.Range(3, 9);
    }

    // Update is called once per frame
    void Update()
    {
        CheckIfTimeToFire();
        StartCoroutine(randomlababa());
        
    }

    void CheckIfTimeToFire()
    {
        if (Time.time > nextFire)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
        }

    }
    IEnumerator randomlababa()
    {
        yield return new WaitForSeconds(2);
        fireRate = Random.Range(3, 9);


    }
}