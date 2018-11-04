using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockFall : MonoBehaviour 
{
    public GameObject[] Cubes7;

	// Use this for initialization
	void Start () 
    {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
		
	}

    public void OnTriggerEnter(Collider col)
    {
       if(Cubes7[0] && col.gameObject.tag == "Missle")
        {
            Destroy(Cubes7[0].gameObject);
            print("destroyed");
        }
        if (Cubes7[6] && col.gameObject.tag == "Missle")
        {
            Destroy(Cubes7[6].gameObject);
            print("destroyed");
        }

    }
}
