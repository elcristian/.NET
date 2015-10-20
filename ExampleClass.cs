using UnityEngine;
using System.Collections;


//The gravity applied to all rigid bodies in the scene.

//Gravity can be turned off for an individual rigidbody using its useGravity property.
public class ExampleClass : MonoBehaviour {
    void Example() {
        Physics.gravity = new Vector3(0, -1.0F, 0);
    }
   
//Controls whether gravity affects this rigidbody.

//If set to false the rigidbody will behave as in outer space.
   public Collider coll;
    void Start() {
        coll = GetComponent<Collider>();
        coll.isTrigger = true;
    }
    void OnTriggerEnter(Collider other) {
        if (other.attachedRigidbody)
            other.attachedRigidbody.useGravity = false;
        
    }
}