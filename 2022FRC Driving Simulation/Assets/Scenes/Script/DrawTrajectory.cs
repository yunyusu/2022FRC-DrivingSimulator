using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawTrajectory : MonoBehaviour
{
    ShooterController shooterController;
    LineRenderer lineRenderer;
    public int numPoints = 50;
    //Number of points on the line
    public float timeBetweenPoints = 0.1f;
    //Distance between those points on the line
    public LayerMask CollidableLayers;
    //The physic layers that will cause the line to stop being drawn
    
    // Start is called before the first frame update
    void Start()
    {
        shooterController = GetComponent<ShooterController>();
        lineRenderer = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        lineRenderer.positionCount = numPoints;
        List<Vector3> points = new List<Vector3>();
        Vector3 startingPosition = shooterController.Shootpoint.position;
        Vector3 startingVelocity = shooterController.Shootpoint.up * shooterController.BlastPower;
        for(float t = 0; t< numPoints; t += timeBetweenPoints){
            Vector3 newPoint = startingPosition + t * startingVelocity;
            newPoint.y = startingPosition.y + startingVelocity.y * t + Physics.gravity.y/2f * t * t;
            //y=y0+v0y+gt^2/2
            points.Add(newPoint);

            if(Physics.OverlapSphere(newPoint, 2, CollidableLayers).Length > 0){
                lineRenderer.positionCount = points.Count;
                break;
            }
        }
        lineRenderer.SetPositions(points.ToArray());
    }
}
