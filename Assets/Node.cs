using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    public Vector3 positionOffset;
    private GameObject turret;
    private Renderer rend;
    private Color startColor;
    BuildManager buildManager;

    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;

        buildManager = BuildManager.instance;
    }
    void OnMouseDown ()
    {
       if(EventSystem.current.IsPointerOverGameObject())
        return;
        
        if(buildManager.GetTurretToBuild() == null)
        return;

        if(turret != null)
        {
            Debug.Log("Cant build there!");
            return;
        }

        GameObject turretToBuild = buildManager.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);
    }

    void OnMouseEnter ()
    {
        if(EventSystem.current.IsPointerOverGameObject())
        return;

        rend.material.color = hoverColor;
        if(buildManager.GetTurretToBuild() == null)
        return; 
    }

        void OnMouseExit ()
    {
        rend.material.color = startColor;
    }
}
