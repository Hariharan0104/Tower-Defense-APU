using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WaveSpawner : MonoBehaviour
{
    
    public static int EnemiesAlive = 0;

    public int lvl;
    public Wave[] waves;
    public Transform enemyPrefab;
    
    public Transform spawnPoint;

    public float timeBetweenWaves = 5f;
    private float countdown = 5f;

    public Text waveCountdownText;

    private int waveIndex = 1;
    void Awake()
    {
        EnemiesAlive = 0;
    }

    void Update ()
    {
         
        if(EnemiesAlive > 0)
        {
           
            return;
        }
        if(waveIndex == waves.Length && EnemiesAlive <=0)
        {
            if(waveIndex == waves.Length )
        {
            Debug.Log("Level Won!");
            this.enabled = false;
            SceneManager.LoadScene("Stage Lvl");
            PlayerPrefs.SetInt("levelReached", lvl);
        }
        }
        if(countdown <= 0f)
        {
            
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
            return;
        }
        countdown -= Time.deltaTime;
        waveCountdownText.text = Mathf.Round(countdown).ToString();
    }

    IEnumerator SpawnWave()
    {

        Wave wave = waves[waveIndex];
        
        for (var i = 0; i < wave.count; i++)
        {
            SpawnEnemy(wave.enemy);
            yield return new WaitForSeconds(1f/wave.rate);
        }
        waveIndex++;

        // if(waveIndex == waves.Length )
        // {
        //     Debug.Log("Level Won!");
        //     this.enabled = false;
        //     SceneManager.LoadScene("Stage Lvl");
        //     PlayerPrefs.SetInt("levelReached", lvl);
        // }
       
    }

    void SpawnEnemy(GameObject enemy)
    {

        Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
        EnemiesAlive++;
    }
   
}
