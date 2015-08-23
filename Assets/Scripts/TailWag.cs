using UnityEngine;
using System.Collections;

public class TailWag : MonoBehaviour {
    Animator animator;
    float lastInput = 0;

	// Use this for initialization
	void Start () {
        animator = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	    if ((lastInput < 0 && Input.GetAxis("Horizontal") > 0) ||(lastInput >= 0 && Input.GetAxis("Horizontal") < 0))
        {
            lastInput = Input.GetAxis("Horizontal");
            animator.SetTrigger("WagTail");
        }
	}
}
