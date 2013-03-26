using UnityEngine;
using System.Collections;

public class SphereMover : MonoBehaviour {
	
	private float speed = 3;
	private float maxHeight = 4;
	private float minHeight = 2;
	private bool direction = true;
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y > maxHeight || transform.position.y < minHeight)
			direction = !direction;
		transform.position += (direction ? 1 : -1) * Vector3.up * speed * Time.deltaTime;
	}
}
