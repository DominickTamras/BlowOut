using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour {

    public Rigidbody shell;

    public Transform FireStart;

    private Transform mCanon;

	void Start ()
    {
        mCanon = FireStart.parent;
	}
	
	
    public void Shoot()
    {
        Rigidbody rbShell = Instantiate(shell, FireStart.position, mCanon.rotation);
        rbShell.velocity = 10.0f * mCanon.forward;
    }
    
    // Update is called once per frame
	void Update ()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Invoke("Shoot", 1.5f);
        }
	}
}
