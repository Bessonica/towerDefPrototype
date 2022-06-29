using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_movement : MonoBehaviour
{

    //several problems
    //   movement is to static, it feel not as monster but as a machine
    //   need to create methods for scripted events, where you control GROUPS of enemies, 
    //     or all of them

    //look into ai design of pacman games

    //idea for movement: different type of waypoints
    //to simulate/fake carefull behaiviour create differrnet type of waypoints
    //and change them naybe mid game, to simulate learning 
    
    // carefull waypoint, enemies slows down when approaching
    // confident waypoints, enemies go straight to point
    // IDEA: in the beggining put a lot of carefull waypoints
    //       but later change them, as if monsters now confident, they "know"layout

    // question  how create "path" with waypoints for monsters, if there is several paths?
    // monsters move from wp to wp as an array wp[0] -> wp[1] etc
    //    what if we create several sepparate arrays for each path
    //      way1: wp1 wp2 wp3 etc,   way2: wp1 wp2 etc.
    //  !!and by changing array monsters can simulate pathfinding!!
    public float speed = 10f;

    private Transform target;
    private int wavepointIndex = 0;


    //choose target to move to
    private void Start()
    {
        target = waypoints.points[0];
    }

    //every frame we move enemy closer to target

    //create 2 methods: goForward, goBackwards
    //  its all to move forward and backwards, to change route.
    private void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);


        if (Vector3.Distance(transform.position, target.position) <= 0.4f)
        {
            GetNextWayPoint();
        }

    }

    //when reached target move to neext one
    // handle change of path, pathA finished
    private void GetNextWayPoint()
    {
        // so if we have reached the end then do...
        if(wavepointIndex >= waypoints.points.Length - 1)
        {
            EndPath();
            return;
        }
        wavepointIndex++;
        target = waypoints.points[wavepointIndex];
    }

    void EndPath()
    {
        PlayerStats.HealthPoints--;
        UnityEngine.Debug.Log("Your lives now are " + PlayerStats.HealthPoints.ToString());
        Destroy(gameObject);
    }
}
