using UnityEngine;
using System.Collections;

public class Enemy_AI : MonoBehaviour {
	public Transform target;
	public int moveSpeed;
	public int rotationSpeed;

	private Transform myTransform;

	void Awake() {
		myTransform = transform; //transform from unity
	//happens before anything else happens in the script
	}
	// Use this for initialization
	void Start () {
		GameObject go = GameObject.FindGameObjectWithTag ("Player"); //when you select your player in unity, the tag is 'player' --that's where this is pointing to (can be seen in inspector

		target = go.transform;



	
	}
	
	// Update is called once per frame
	void Update () {
		Debug.DrawLine(target.position, myTransform.position, Color.yellow); //draws a line from the enemy to the player (didn't work?)
	//look at target
		myTransform.rotation = Quaternion.Slerp (myTransform.rotation, Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed * Time.deltaTime);
	//move towards target
		myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
		//time.deltatime normalizes movement speed between systems
	
	}
}
