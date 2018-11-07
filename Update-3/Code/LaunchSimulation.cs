using UnityEngine;
using System.Collections;

public class LaunchSimulation : MonoBehaviour
{
    public Transform Target;
    public float firingAngle = 45.0f;
    public float gravity = 9.8f;
    public GameObject Projectile; 
    private Transform myTransform;
    public float timeBetweenShots = 1f;
    private float timeStamp;

    void Awake()
    {
        myTransform = transform;
    }

    void Update()
    {
        if (Time.time >= timeStamp && (Input.GetKey(KeyCode.Space)) )

        {
            StartCoroutine(SimulateProjectile());

            timeStamp = Time.time + timeBetweenShots;

            GameObject clone = Instantiate(Projectile, transform.position, transform.rotation) as GameObject;


        }
    }


    IEnumerator SimulateProjectile()
    {
       

        // Move projectile to the position of throwing object.
        gameObject.transform.position = myTransform.position + new Vector3(0, 0.0f, 0);

        // Calculate distance to target
        float target_Distance = Vector3.Distance(gameObject.transform.position, Target.position);

        // Calculate the velocity needed to throw the object to the target at specified angle.
        float projectile_Velocity = target_Distance / (Mathf.Sin(2 * firingAngle * Mathf.Deg2Rad) / gravity);

        // Extract the X  Y componenent of the velocity
        float Vx = Mathf.Sqrt(projectile_Velocity) * Mathf.Cos(firingAngle * Mathf.Deg2Rad);
        float Vy = Mathf.Sqrt(projectile_Velocity) * Mathf.Sin(firingAngle * Mathf.Deg2Rad);

        // Calculate flight time.
        float flightDuration = target_Distance / Vx;

        // Rotate projectile to face the target.
        gameObject.transform.rotation = Quaternion.LookRotation(Target.position - gameObject.transform.position);

        float elapse_time = 0;

        while (elapse_time < flightDuration)
        {
            gameObject.transform.Translate(0, (Vy - (gravity * elapse_time)) * Time.deltaTime, Vx * Time.deltaTime);

            elapse_time += Time.deltaTime;

            yield return null;
        }
    }
}