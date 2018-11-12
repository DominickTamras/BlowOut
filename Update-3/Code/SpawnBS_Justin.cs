using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBS_Justin : MonoBehaviour {

    public GameObject[] SpawnPoints;
    public GameObject BS;

    public float timeStart = 5;
    public float timecurrent = 5;

    public bool cooldown = true;
    int WhichSP;

    // Use this for initialization
    void Start () {
        timecurrent = timeStart;
	}
	
	// Update is called once per frame
	void FixedUpdate () 
    {
        if (timecurrent <= 0){
            cooldown = false;
        }
        if (!cooldown)
        {
            WhichSP = Random.Range(0, 9);
            Instantiate(BS, SpawnPoints[WhichSP].transform.position, SpawnPoints[WhichSP].transform.rotation);
            timecurrent = timeStart;
            cooldown = true;
        }
        else
        {
            timecurrent -= Time.deltaTime;
        }

	}
}
