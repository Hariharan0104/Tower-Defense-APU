using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretBlueprint coin_Turret;
    public TurretBlueprint tanker_Turret;
    public TurretBlueprint Turret1;
    public TurretBlueprint Turret2;
    public TurretBlueprint Turret3;
    public TurretBlueprint Turret4;
    public TurretBlueprint Turret5;
    public TurretBlueprint Turret6;
    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }
    public void coin_Turret_F()
    {
        Debug.Log("coin turret Selected");
        buildManager.SelectTurretToBuild(coin_Turret);
    }
    public void tanker_Turret_F()
    {
        Debug.Log("tanker turret Selected");
        buildManager.SelectTurretToBuild(tanker_Turret);
    }

    public void Turret_1()
    {
        Debug.Log("Turret1 turret Selected");
        buildManager.SelectTurretToBuild(Turret1);
    }

    public void Turret_2()
    {
        Debug.Log("Turret2 turret Selected");
        buildManager.SelectTurretToBuild(Turret2);
    }

    public void Turret_3()
    {
        Debug.Log("Turret3 turret Selected");
        buildManager.SelectTurretToBuild(Turret3);
    }

    public void Turret_4()
    {
        Debug.Log("Turret4 turret Selected");
        buildManager.SelectTurretToBuild(Turret4);
    }

    public void Turret_5()
    {
        Debug.Log("Turret5 turret Selected");
        buildManager.SelectTurretToBuild(Turret5);
    }

    public void Turret_6()
    {
        Debug.Log("Turret6 turret Selected");
        buildManager.SelectTurretToBuild(Turret6);
    }

 

}
