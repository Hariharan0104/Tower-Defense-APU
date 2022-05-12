using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnCoins : MonoBehaviour
{
    
    public GameObject coinPrefab;
    public int coinAdded;

    private bool canSpawn = true;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(canSpawn)
        {
             StartCoroutine("Delay");
        }
        
        
        if (Input.GetMouseButtonDown(0))
         {
             RaycastHit raycastHit;
             Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
             if (Physics.Raycast(ray, out raycastHit, 1000f))
             {
                 if (raycastHit.transform != null)
                 {
                    
                     ObjectClicked(raycastHit.transform.gameObject);
                 }
             }
         }
        
    }

    IEnumerator Delay()
    {
        Vector3 center = transform.position;
        Vector3 pos = RandomCircle(center, .1f);
        pos.y = pos.y + 1f;

        Quaternion rot = Quaternion.FromToRotation(Vector3.forward, center-pos);
        
       canSpawn = !canSpawn;
       float num = Random.Range(1f,5f);
        yield return new WaitForSecondsRealtime (num);
        GameObject coin =  (GameObject)Instantiate (coinPrefab, pos, rot);
        Destroy(coin, 3f);
        canSpawn = !canSpawn;
        
         
        
        
        
        
        
    }

    Vector3 RandomCircle ( Vector3 center ,   float radius  ){
         float ang = Random.value * 360;
         Vector3 pos;
         pos.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
         pos.y = center.y + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
         pos.z = center.z;
         return pos;
     }


      public void ObjectClicked(GameObject gameObject)
 {
     if(gameObject.tag=="coin")
     {
         Destroy(gameObject);
         //add coins
         PlayerStats.Money = PlayerStats.Money + coinAdded;
     }
 }
}
