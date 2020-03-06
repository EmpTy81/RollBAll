using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour {
    private Rigidbody rb;
	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        Debug.Log(moveHorizontal);
        float moreVertical = Input.GetAxis("Vertical");
        Debug.Log(moreVertical);

        Vector3 movement = new Vector3(moveHorizontal,0,moreVertical);
        rb.AddForce(movement*5);

    }
}
