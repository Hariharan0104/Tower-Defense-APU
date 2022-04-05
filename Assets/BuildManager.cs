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


    private TurretBlueprint turretToBuild;

    public bool CanBuild { get{ return turretToBuild != null; }}

    public void BuildTurretOn(Node node) {
        {
            if(PlayerStats.Money < turretToBuild.cost)
            {
                Debug.Log("not enuf money");
                return;
            }
            PlayerStats.Money -= turretToBuild.cost;

           
            GameObject turret = (GameObject)Instantiate(turretToBuild.prefab, node.GetBuildPosition(), Quaternion.identity);
            node.turret = turret;
            
            Debug.Log("Money left" + PlayerStats.Money);
        }
    }




    public void SelectTurretToBuild (TurretBlueprint turret)
    {
        turretToBuild = turret;
    }
    
    
}
