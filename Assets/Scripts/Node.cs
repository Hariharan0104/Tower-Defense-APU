using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Node : MonoBehaviour
{
    public bool checkTower;
    public Color hoverColor;
    public Color notEnoughMoneyColor;
    public Vector3 positionOffset;
    [Header("Optional")]
    public GameObject turret;

    [HideInInspector]
    public TurretBlueprint turretBlueprint;
    private Renderer rend;
    private Color startColor;
    BuildManager buildManager;

    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;

        buildManager = BuildManager.instance;
    }

    public Vector3 GetBuildPosition()
    {
        return transform.position + positionOffset;
    }
    void OnMouseDown ()
    {
       if(EventSystem.current.IsPointerOverGameObject())
        return;
        
       

        if(turret != null)
        {
            buildManager.SelectNode(this);
            return;
        }

         if(!buildManager.CanBuild)
        return;

        

        BuildTurret(buildManager.GetTurretToBuild());
    }

    void BuildTurret (TurretBlueprint blueprint)
    {
        // if(blueprint.prefab.tag == "Tank_Tower") //&& this.tag == "groundTile")
        // {
        //     checkTower = false;
        // }
        // else
        // {
        //     checkTower = true;
        // }

        // if(blueprint.prefab.tag == "Tank_Tower" && this.tag == "groundTile")
        // {
        //     checkTower = true;
        // }
        // if(checkTower)
        // {
             if(PlayerStats.Money < blueprint.cost)
            {
                Debug.Log("not enuf money");
                return;
            }
            PlayerStats.Money -= blueprint.cost;

           
            GameObject _turret = (GameObject)Instantiate(blueprint.prefab, GetBuildPosition(), Quaternion.identity);
            turret = _turret;

            turretBlueprint = blueprint;

           GameObject effect =  Instantiate(buildManager.buildEffect, GetBuildPosition(), Quaternion.identity );
            Destroy(effect, 6f);
            Debug.Log("Turret build!");
        //}
        
        
    }
    public void SellTurret()
    {
        PlayerStats.Money +=  turretBlueprint.GetSellAmount();
        
        GameObject effect =  Instantiate(buildManager.sellEffect, GetBuildPosition(), Quaternion.identity );
        Destroy(effect, 6f);

        Destroy(turret);
        turretBlueprint = null;
        

    }


    void OnMouseEnter ()
    {
        if(EventSystem.current.IsPointerOverGameObject())
        return;

       
        
        if(!buildManager.CanBuild)
        return; 

        if(buildManager.HasMoney)
        {
             rend.material.color = hoverColor;
        }
        else
        {
             rend.material.color = notEnoughMoneyColor;
        }
    }

        void OnMouseExit ()
    {
        rend.material.color = startColor;
    }
}
