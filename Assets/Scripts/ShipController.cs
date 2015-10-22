using UnityEngine;
using System.Collections;

public class ShipController : MonoBehaviour {

	public float speed;
    public float back;
	public Vector3 direction;
	public KeyCode moveKey;
    public KeyCode backKey;
    public int lifes;

	public float angles;
	public KeyCode rotateLeftKey;
	public KeyCode rotateRightKey;

	public KeyCode shootKey;
	public GameObject bulletPrototype;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Move();
		Rotate();
		Shoot();
        Back();
	}

	private void Shoot(){
		if (Input.GetKeyDown(shootKey)){
			Instantiate(bulletPrototype, transform.position, transform.rotation);
		}
	}

	private void Move(){
		if (Input.GetKey(moveKey)){
			transform.Translate( direction * speed * Time.deltaTime );
		}
	}

    private void Back()
    {
        if (Input.GetKey(backKey))
        {
            transform.Translate(direction * back * Time.deltaTime * -1);
        }
    }

	private void Rotate(){
		if (Input.GetKey(rotateLeftKey)){
			transform.Rotate(new Vector3(0,angles * Time.deltaTime * -1,0));
		}
		if (Input.GetKey(rotateRightKey)){
			transform.Rotate(new Vector3(0,angles * Time.deltaTime,0));
		}
	}
}
