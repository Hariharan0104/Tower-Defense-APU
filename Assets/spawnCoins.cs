using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnCoins : MonoBehaviour
{
    public float xCor;
    public float yCor;
    public float zCor;
    public GameObject coinPrefab;

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
        
        
        
        
    }

    IEnumerator Delay()
    {
        
       canSpawn = !canSpawn;
       float num = Random.Range(1f,5f);
        yield return new WaitForSecondsRealtime (num);
        xCor = Random.Range(-4f,4f);
        zCor =  Random.Range(-7f,1f);
        GameObject coin =  (GameObject)Instantiate (coinPrefab, new Vector3(xCor,yCor,zCor), Quaternion.identity);
        Destroy(coin, 3f);
        canSpawn = !canSpawn;
        
         
        
        
        
        
        
    }
}
