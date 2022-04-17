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

     public GameObject buildEffect;
     public GameObject sellEffect;


    private TurretBlueprint turretToBuild;
    private Node selectedNode;

    public NodeUI nodeUI;

    public bool CanBuild { get{ return turretToBuild != null; }}
    public bool HasMoney { get{ return PlayerStats.Money >= turretToBuild.cost; }}// returns true if sufficient money



//enable 1 and disable other 1
    public void SelectNode (Node node)
    {

        if(selectedNode == node)
        {
            DeselectNode();
            return;
        }
        selectedNode = node;
        turretToBuild = null;

        nodeUI.SetTarget(node); 
    }

    public void DeselectNode()
    {
        selectedNode = null;
        nodeUI.Hide();
    }

    public void SelectTurretToBuild (TurretBlueprint turret)
    {
        turretToBuild = turret;
        selectedNode = null;

        nodeUI.Hide();
        DeselectNode();
    }

    public TurretBlueprint GetTurretToBuild()
    {
        return turretToBuild;
    }
    
    
}
