using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wave_spawner : MonoBehaviour
{
    // Start is called before the first frame update

    // make big variable Total time
    // and when it reacches one of threshhold (if>=40, later if >=20, if >=10 etc)how to avoid repeating execution? and we need to use method ones, and forget about it

    public Transform enemyPrefab;
    public Transform spawnPoint;

    public float timeBetweenWaves = 5f;
    private float countdown = 2f;

    private int waveNumber = 0;

    public Text waveCountDownText;

    

    //test comment

    private void Update()
    {
        // UnityEngine.Debug.Log(UnityEngine.Time.deltaTime);
        if(countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
        }

        countdown -= UnityEngine.Time.deltaTime;

        waveCountDownText.text = Mathf.Floor(countdown).ToString();
    }


    // when you spawn them dont do this in straight line, one after anaother
    // they shouldnt be like a train, but as a crowd 
    IEnumerator SpawnWave()
    {
        waveNumber++;

        UnityEngine.Debug.Log("Wave Incoming");
        for( int i = 0; i<waveNumber; i++  )
        {
            spawnEnemy();
            yield return new WaitForSeconds(0.5f);

        }
        
    }


    // give them half random speed
    // find a way to address them later, to change course for example
    void spawnEnemy()
    {

        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);

    }

}
