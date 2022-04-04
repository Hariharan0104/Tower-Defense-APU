using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;
    // Start is called before the first frame update
    void Awake() {
        if(instance != null)
        {
            Debug.Log("more than 1 builmanager in scene");
            return;
        }
        instance = this;
    }
    public GameObject standardTurretPrefab;
     public GameObject anotherTurretPrefab;


    private GameObject turretToBuild;
    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }

    public void SetTurretToBuild (GameObject turret)
    {
        turretToBuild = turret;
    }
    
    
}
