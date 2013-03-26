using UnityEngine;
using System.Collections;

public class SunMover : MonoBehaviour {
	
	private float speed = 10;
	private float radius;
	private float angle = 0;
	private float height;
	
	
	void Start () {
		radius = Vector3.Distance(new Vector3(0, transform.position.y, 0), transform.position);
		height = transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(radius * Mathf.Cos(angle / 180 * Mathf.PI), 
			height, 
			radius * Mathf.Sin(angle / 180 * Mathf.PI));
		if (angle > 360) angle = 0;
		angle += speed * Time.deltaTime;
		transform.LookAt(Vector3.zero);
	}
}
