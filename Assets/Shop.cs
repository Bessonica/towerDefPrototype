using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{

    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void PurchaseStandardTurret()
    {
        UnityEngine.Debug.Log("you have purchased a turret");
        buildManager.SetTurretToBuild(buildManager.standartTurretPrefab);
    }




}
