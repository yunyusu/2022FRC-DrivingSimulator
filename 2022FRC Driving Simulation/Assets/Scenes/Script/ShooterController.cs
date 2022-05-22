using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterController : MonoBehaviour
{
    public float rotationSpeed = 1;
    public float BlastPower = 5;
    public GameObject Ball;
    public Transform Shootpoint;

    private void Update(){
        float HorizontalRotation = Input.GetAxis("AimingHorizontal");
        float VerticalRotation = Input.GetAxis("AimingVertical");
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0,HorizontalRotation * rotationSpeed, VerticalRotation * rotationSpeed));
        //turn shooter point higher or lower
        if(Input.GetKeyDown(KeyCode.Space) && ScoreSystem.theBalls > 0){
            GameObject CreatedBall = Instantiate(Ball,Shootpoint.position, Shootpoint.rotation);
            ScoreSystem.theBalls -= 1;
            CreatedBall.GetComponent<Rigidbody>().velocity = Shootpoint.transform.up * BlastPower;
        }
        //spawn ball on shooter and shoot it
    }
}
