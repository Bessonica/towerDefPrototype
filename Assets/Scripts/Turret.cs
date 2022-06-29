using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public Transform target;
    public float range = 15f;

    public string enemyTag = "Enemy";

    public float fireRate = 1f;
    private float fireCountDown = 0f;


    public GameObject bulletPrefab;
    public Transform firePoint;

    void Start()
    {
        //instead of doing function each frame we do it every half second
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
    }

    void UpdateTarget()
    {
        //got all enemies
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;



        foreach (GameObject enemy in enemies)
        {

            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if(distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;

            }

        }

        if(nearestEnemy != null && shortestDistance <= range)
        {
            target = nearestEnemy.transform;
        }else
        {
            target = null;
        }

    }


    void Update()
    {
        if(target == null)
           return;

        if(fireCountDown <= 0)
        {
            Shoot();
            fireCountDown = 1f / fireRate;
        }

        fireCountDown -= UnityEngine.Time.deltaTime;

    }

    void Shoot()
    {
        UnityEngine.Debug.Log("shoot");
        
        // might be usefull
        // this is how we send info to anoter object, or scrept
        GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Bullet bullet = bulletGO.GetComponent<Bullet>();

        if(bullet !=null)
        {
            bullet.Seek(target);
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;

        Gizmos.DrawWireSphere(transform.position, range);
 
    }
}
