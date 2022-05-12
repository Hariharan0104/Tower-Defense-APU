using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontDestroy : MonoBehaviour
{
    private static GameObject instance;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Awake()
    {
        DontDestroyOnLoad (transform.gameObject);
        if (instance == null)
         instance = transform.gameObject;
        else
         Destroy(transform.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
