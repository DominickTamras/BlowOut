using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubes7 : MonoBehaviour 
{
    public GameObject Cube70;
    public GameObject Cube71;
    public GameObject Cube72;
    public GameObject Cube73;
    public GameObject Cube74;
    public GameObject Cube75;
    public GameObject Cube76;
    public GameObject Cube77;
    public GameObject Cube78;
    public GameObject Cube79;
    public GameObject Cube710;
    public GameObject Cube711;
    public GameObject Cube712;
    public GameObject Cube713;


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
        if (col.gameObject.tag == "7.0")
        {
            Destroy(Cube70);
        }
        if (col.gameObject.tag == "7.1")
        {
            Destroy(Cube71);
        }
        if (col.gameObject.tag == "7.3")
        {
            Destroy(Cube73);
        }
        if (col.gameObject.tag == "7.4")
        {
            Destroy(Cube74);
        }
        if (col.gameObject.tag == "7.5")
        {
            Destroy(Cube75);
        }
        if (col.gameObject.tag == "7.6")
        {
            Destroy(Cube76);
        }
        if (col.gameObject.tag == "7.7")
        {
            Destroy(Cube77);
        }
        if (col.gameObject.tag == "7.8")
        {
            Destroy(Cube78);
        }
        if (col.gameObject.tag == "7.9")
        {
            Destroy(Cube79);
        }
        if (col.gameObject.tag == "7.10")
        {
            Destroy(Cube710);
        }
        if (col.gameObject.tag == "7.11")
        {
            Destroy(Cube711);
        }
        if (col.gameObject.tag == "7.12")
        {
            Destroy(Cube712);
        }
        if (col.gameObject.tag == "7.13")
        {
            Destroy(Cube713);
        }

    }
}
