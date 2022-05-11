using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Enemy))]
public class EnemyMovement : MonoBehaviour
{
Quaternion enemyRotationtowaypoint;
   private Transform target;
    private int wavepointIndex = 0;

    private Enemy enemy;

    private void Start() 
    {
        enemy = GetComponent<Enemy>();
        target = Waypoints.points[0];
    }

        private void Update() {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * enemy.speed * Time.deltaTime, Space.World);
        enemyRotationtowaypoint = Quaternion.LookRotation(dir);
        
        transform.rotation = Quaternion.Slerp(transform.rotation, enemyRotationtowaypoint, Time.deltaTime * 10);

        if(Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextWaypoint();
        }

        
        //enemy.speed = enemy.startSpeed;
    }


        

    
        
 

    void GetNextWaypoint()
    {
        if(wavepointIndex >= Waypoints.points.Length - 1)
        {
           EndPath();
            return;
        }
        wavepointIndex++;
        target = Waypoints.points[wavepointIndex];
    }

    void EndPath()
    {
        PlayerStats.Lives--;
        WaveSpawner.EnemiesAlive--;
        Destroy(gameObject);
    }
}
