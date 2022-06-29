using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{

    private GameObject turret;


    public Color hoverColor;
    private Renderer rend;

    private Color startColor;

    void Start()
    {
        // here we get Mesh Renderer component of our object
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }

    void OnMouseDown()
    {

        // if turret exists
        if(turret != null)
        {
            UnityEngine.Debug.Log("Cant place turrets on top of each other");
            return;
        }

        //if turret doesnt exist, place it
        GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position, transform.rotation);
    }

    // method for every time you hover over object
    void OnMouseEnter()
    {
        rend.material.color = hoverColor;
 
    }

    void OnMouseExit()
    {
        rend.material.color = startColor;
    }

}
