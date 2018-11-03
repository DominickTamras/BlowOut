using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public float movementSpeed = 10;
    public float turningSpeed = 60;
    public float verticalTurnSpeed = 50;
    public float strafeSpeed = 10;
    bool strafe = true;
    // Update is called once per frame


    void Update()
    {

        //Moves Player Foward
        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed);
        //Moves Player Back
        if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.back * Time.deltaTime * movementSpeed);
        //Moves Player strafe Right
        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.LeftShift))
            transform.Translate(Vector3.right * Time.deltaTime * strafeSpeed);
        //Moves Player strafe Left
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.LeftShift))
            transform.Translate(Vector3.left * Time.deltaTime * strafeSpeed);
        //Rotates Player Right
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.up * Time.deltaTime * turningSpeed);
        //Rotates Plater Left
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.down * Time.deltaTime * turningSpeed);
        //this part of code makes it turn up
 
    }
}