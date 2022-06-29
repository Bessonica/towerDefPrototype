using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{


    public Vector3 positionOffset;

    [Header("its when you want pre setup turrets for level")]
    public GameObject turret;


    public Color hoverColor;
    private Renderer rend;

    private Color startColor;

    BuildManager buildManager;

    void Start()
    {
        // here we get Mesh Renderer component of our object
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;

        buildManager = BuildManager.instance;
    }

    public Vector3 GetBuildPosition()
    {
        return transform.position + positionOffset;
    }

    void OnMouseDown()
    {

        if(!buildManager.CanBuild)
        {
            return;
        }


        // if turret exists
        if(turret != null)
        {
            UnityEngine.Debug.Log("Cant place turrets on top of each other");
            return;
        }

        buildManager.BuildTurretOn(this);


    }

    // method for every time you hover over object
    void OnMouseEnter()
    {
     
        if(!buildManager.CanBuild)
        {
            return;
        }
     
        rend.material.color = hoverColor;
 
    }

    void OnMouseExit()
    {
        rend.material.color = startColor;
    }

}
