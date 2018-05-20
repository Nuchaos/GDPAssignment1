using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour {
    public float launchboi;
    private void OnTriggerStay (Collider other)
    {
        other.GetComponent<Rigidbody>().AddForce(Vector3.up * launchboi, ForceMode.Acceleration);
        
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		
	}
}
