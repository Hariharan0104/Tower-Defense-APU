using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NodeUI : MonoBehaviour
{
    private Node target;
    public GameObject ui;
    public Text sellAmount;

    public void SetTarget (Node _target)
    {
        target = _target;

        transform.position = target.GetBuildPosition();

        sellAmount.text = "$" + target.turretBlueprint.GetSellAmount();

        ui.SetActive(true);


    }

    public void Hide()
    {
        ui.SetActive(false);
    }

    public void Sell()
    {
        target.SellTurret();
        BuildManager.instance.DeselectNode();
    }

}
