using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{
    private Rigidbody2D _rigidBody;
    private NewBehaviourScript playerScript;
 
void Awake()
    {
        _rigidBody = GetComponentInParent<Rigidbody2D>();
        playerScript = GetComponentInParent<NewBehaviourScript>();
    }




}
