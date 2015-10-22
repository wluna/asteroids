using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {

	public Vector3 direction;
	public float speed;
    public float lifeTime;

	// Use this for initialization
	void Start () {
        Destroy(gameObject, lifeTime);
	}
	
	// Update is called once per frame
	void Update () {
		Move();
	}

	private void Move(){
		transform.Translate(direction * speed * Time.deltaTime);
	}

    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Se estrello");
        Destroy(collider.gameObject);
        Destroy(gameObject);
    }
}
