using UnityEngine;
using System.Collections;

public class SphereMover : MonoBehaviour {
	
	private float speed = 8;
	private float maxheight = 30;
	private float minheight = 26;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if ((transform.position.y >= maxheight && speed > 0) || (transform.position.y <= minheight && speed < 0))
			speed = -speed;
		
		transform.position = new Vector3(transform.position.x, transform.position.y + Time.deltaTime * speed, transform.position.z);
	
	}
}
