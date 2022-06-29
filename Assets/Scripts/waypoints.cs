
using UnityEngine;

public class waypoints : MonoBehaviour
{

    public static Transform[] points;
    public float whichWay;

    // make several waypoints, and enemies move different to them

//get all waypoints "coordinates"
//this is how we address them
    private void Awake()
    {
        points = new Transform[transform.childCount];

        for(int i = 0; i < points.Length; i++)
        {
            points[i] = transform.GetChild(i);
        }
    }

}
