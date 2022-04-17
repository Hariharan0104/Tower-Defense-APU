using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public Transform target;
    public float range = 15f;

    public string enemyTag = "Enemy";

    public float fireRate = 1f;
    private float fireCountdown = 0f;

    public int damageOverTime = 30; //30 dmg per second

    public GameObject bulletPrefab;
    public Transform firePoint;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
    }
    void UpdateTarget()
    {
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
        }
        else
        {
            target = null;// to remove target once it leaves the short distance
        }
    }


    // Update is called once per frame
    void Update()
    {
        if(target == null)
            return;

        //function_slowing down

            if(fireCountdown <= 0f)
            {
                Shoot();
                
                fireCountdown = 1f/fireRate;
            }
            fireCountdown -= Time.deltaTime;
    }

    // void Slow()
    // {
    //     target.GetComponent<Enemy>().TakeDamage(damageOverTime * Time.deltaTime);
    // }

    void Shoot()
    {
        GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Bullet bullet = bulletGO.GetComponent<Bullet>();

        if(bullet != null)
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
