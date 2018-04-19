using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour {

    public static bool isGrounded;
    public Transform groundCheck;

	// Update is called once per frame
	void Update () {
        isGrounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));
        if(isGrounded){
            Debug.Log("Entered");
        }else{
            Debug.Log("Exited");
        }
    }
   
}
