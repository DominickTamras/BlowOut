using UnityEngine;
using System.Collections;

public class LaunchSimulation2 : MonoBehaviour
{
    public Transform Target2;
    public float firingAngle2 = 45.0f;
    public float gravity2 = 9.8f;
    public GameObject Projectile2;
    private Transform myTransform2;
    public float timeBetweenShots2 = 1f;
    private float timeStamp2;

    void Awake()
    {
        myTransform2 = transform;
    }

    void Update()
    {
        if (Time.time >= timeStamp2 && (Input.GetKey(KeyCode.KeypadEnter)))

        {
            StartCoroutine(SimulateProjectile());

            timeStamp2 = Time.time + timeBetweenShots2;

            GameObject clone = Instantiate(Projectile2, transform.position, transform.rotation) as GameObject;


        }
    }


    IEnumerator SimulateProjectile()
    {
        

        // Move projectile to the position of throwing object + add some offset if needed.
        gameObject.transform.position = myTransform2.position + new Vector3(0, 0.0f, 0);

        // Calculate distance to target
        float target_Distance = Vector3.Distance(gameObject.transform.position, Target2.position);

        // Calculate the velocity needed to throw the object to the target at specified angle.
        float projectile_Velocity = target_Distance / (Mathf.Sin(2 * firingAngle2 * Mathf.Deg2Rad) / gravity2);

        // Extract the X  Y componenent of the velocity
        float Vx = Mathf.Sqrt(projectile_Velocity) * Mathf.Cos(firingAngle2 * Mathf.Deg2Rad);
        float Vy = Mathf.Sqrt(projectile_Velocity) * Mathf.Sin(firingAngle2 * Mathf.Deg2Rad);

        // Calculate flight time.
        float flightDuration = target_Distance / Vx;

        // Rotate projectile to face the target.
        gameObject.transform.rotation = Quaternion.LookRotation(Target2.position - gameObject.transform.position);

        float elapse_time = 0;

        while (elapse_time < flightDuration)
        {
            gameObject.transform.Translate(0, (Vy - (gravity2 * elapse_time)) * Time.deltaTime, Vx * Time.deltaTime);

            elapse_time += Time.deltaTime;

            yield return null;
        }
    }
}