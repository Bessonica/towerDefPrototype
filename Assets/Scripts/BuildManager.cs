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
    
    private TurretBlueprint turretToBuild;

    public bool CanBuild { get { return turretToBuild != null; } }

    //when in node you on mouse press, you send node to this function
    // which places turret on its place
    public void BuildTurretOn(Node node)
    {
        // check money
        if(PlayerStats.Money < turretToBuild.cost)
        {
            UnityEngine.Debug.Log("no money !");
            return;
        }

        PlayerStats.Money -= turretToBuild.cost;
        UnityEngine.Debug.Log("money" + PlayerStats.Money);


        GameObject turret = (GameObject)Instantiate(turretToBuild.prefab, node.GetBuildPosition(), Quaternion.identity);
        node.turret = turret;
    }



    public void SetTurretToBuild(TurretBlueprint turret)
    {
        turretToBuild = turret;
    }

}
