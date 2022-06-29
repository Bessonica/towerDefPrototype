using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Transform target;

    public float speed = 70f;
    
    // might be usefull 
    //!!!!!  this is how bullet gets enemy to chaise !!!
    public void Seek (Transform _target)
    {
        target = _target;

    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(target == null)
        {
            // might be wrong   GameObject
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * UnityEngine.Time.deltaTime;
        
        //if we hit target
        if(dir.magnitude <= distanceThisFrame)
        {
            HitTarget();
            return;
        }

        // movement
        transform.Translate(dir.normalized * distanceThisFrame, Space.World);
    }

    void HitTarget()
    {
        UnityEngine.Debug.Log("target is hit");
        Destroy(target.gameObject);
        Destroy(gameObject);
    }
}
