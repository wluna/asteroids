using UnityEngine;
using System.Collections;

public class LimitController : MonoBehaviour {

	public float topLimit;
	public float bottomLimit;
	public float leftLimit;
	public float rightLimit;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		CheckLimits();
	}

	private void CheckLimits(){
		if (transform.position.z > topLimit){
			Vector3 newPosition = new Vector3(transform.position.x, 0f, bottomLimit);
			transform.position = newPosition;
		}
		if (transform.position.z < bottomLimit){
			Vector3 newPosition = new Vector3(transform.position.x, 0f, topLimit);
			transform.position = newPosition;
		} 
		if (transform.position.x > rightLimit){
			Vector3 newPosition = new Vector3(leftLimit, 0f, transform.position.z);
			transform.position = newPosition;
		}
		if (transform.position.x < leftLimit){
			Vector3 newPosition = new Vector3(rightLimit, 0f, transform.position.z);
			transform.position = newPosition;
		}
	}
}
