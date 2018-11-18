using UnityEngine;
using System.Collections;

public class LineRender : MonoBehaviour
{
    // Creates a line renderer that follows a Sin() function
    // and animates it.

    public Color c1 = Color.yellow;
    public Color c2 = Color.red;
    public GameObject objectOne;
    public GameObject objectTwo;
    public int lengthOfLineRenderer = 20;

    void Start()
    {
        LineRenderer lineRenderer = gameObject.AddComponent<LineRenderer>();
        lineRenderer.material = new Material(Shader.Find("Sprites/Default"));
        lineRenderer.widthMultiplier = 0.2f;
        lineRenderer.positionCount = lengthOfLineRenderer;
        lineRenderer.SetPosition(0, new Vector3(objectOne.transform.position.x, objectOne.transform.position.y, objectOne.transform.position.z));
        lineRenderer.SetPosition(1, new Vector3(objectTwo.transform.position.x, objectTwo.transform.position.y, objectTwo.transform.position.z));

        // A simple 2 color gradient with a fixed alpha of 1.0f.
        float alpha = 1.0f;
        Gradient gradient = new Gradient();
        gradient.SetKeys(
            new GradientColorKey[] { new GradientColorKey(c1, 0.0f), new GradientColorKey(c2, 1.0f) },
            new GradientAlphaKey[] { new GradientAlphaKey(alpha, 0.0f), new GradientAlphaKey(alpha, 1.0f) }
            );
        lineRenderer.colorGradient = gradient;
    }

    void Update()
    {
        
    }
}