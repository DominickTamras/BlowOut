using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDestroy : MonoBehaviour 
{


	// Use this for initialization
	void Start () 
    {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
		
	}

    public void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Missle")
        {
            Destroy(col.gameObject);
            Destroy(this.gameObject);
        }
    }
}
