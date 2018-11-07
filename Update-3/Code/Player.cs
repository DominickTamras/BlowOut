using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public float movementSpeed = 10;
    public float turningSpeed = 60;
    public float verticalTurnSpeed = 50;
 
    // Update is called once per frame


    void Update()
    {

        //Moves Player Foward
        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.back * Time.deltaTime * movementSpeed);
        //Moves Player Back
        if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed);

        //Rotates Player Right
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.up * Time.deltaTime * turningSpeed);
        //Rotates Plater Left
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.down * Time.deltaTime * turningSpeed);

        /*if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(Vector3.right * Time.deltaTime * strafeSpeed);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * turningSpeed);
        }
        */

        //Lift cannon up and down

    }

    /*public void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Missle")
        {
            Destroy(col.gameObject);
        }
    } */

}