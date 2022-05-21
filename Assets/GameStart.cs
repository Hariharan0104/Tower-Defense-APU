using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    public GameObject StartUI;
    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(TimerCount());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator TimerCount()
    {
        
        
         yield return new WaitForSeconds(3);
         
         StartUI.SetActive(false);
         
         
         
         
    }
}
