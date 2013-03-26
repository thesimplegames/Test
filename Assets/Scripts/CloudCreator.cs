using UnityEngine;
using System.Collections;

public class CloudCreator : MonoBehaviour {
	
	public GameObject Cloud;
	GameObject newCloud;
	Vector3 direction;
	
	// Use this for initialization
	void Start () {
	
		direction = new Vector3(Random.Range(-3,4), 0, Random.Range(-3,4));		
		newCloud = Instantiate(Cloud, new Vector3 (Random.Range(-30, 30), 20, Random.Range(-30, 30)), Quaternion.identity) as GameObject;
		newCloud.AddComponent<SphereMover>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
		//newCloud.transform.position = newCloud.transform.position + direction * Time.deltaTime;
	
	}
}
