using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{

    public TurretBlueprint standardTurret;

    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void PurchaseStandardTurret()
    {
        UnityEngine.Debug.Log("you have purchased a turret");
        buildManager.SetTurretToBuild(standardTurret);
    }




}
