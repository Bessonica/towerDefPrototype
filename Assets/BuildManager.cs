using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    // singleton
    public static BuildManager instance;

    void Awake()
    {
        instance = this;
    }

    //reference to turret object
    public GameObject standartTurretPrefab;
    
    // void Start()
    // {
    //     turretToBuild = standartTurretPrefab;
    // }

    private GameObject turretToBuild;

    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }
 
    // now we can assign turret for any new turret in future
    public void SetTurretToBuild(GameObject turret)
    {
        turretToBuild = turret;
    }

}
