using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCargo : MonoBehaviour
{
    public AudioSource collectSound;
    public GameObject intake;
    void Start(){
        Collider intake_collider = intake.GetComponent<Collider>();
    }
    void OnTriggerEnter(Collider intake_collider) {
        collectSound.Play();
        ScoreSystem.theBalls += 1;
        Destroy(gameObject);
    }
}
