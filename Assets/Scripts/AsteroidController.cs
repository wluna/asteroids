using UnityEngine;
using System.Collections;


public class AsteroidController : MonoBehaviour
{

    public float speed;
    public Vector3 direction;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider collider)
    {
        ShipController ship = collider.gameObject.GetComponent<ShipController>();
        if (ship != null)
        {
          //  shiplifes--;
            if (false)//ship.lifes == 0)
            {
                Destroy(collider.gameObject);
            }
            else
            {
                ship.transform.position = new Vector3(0, 0, 0);
                ship.transform.rotation = new Quaternion();
                Destroy(this.gameObject);

                AsteroidController[] asteroids = FindObjectsOfType<AsteroidController>();

                for (int i = 0; i < asteroids.Length; i++)
                {
                    if (asteroids[i].gameObject != this.gameObject)
                    {
                        Destroy(asteroids[i].gameObject);
                    }
                }

                Destroy(this.gameObject);
            }

        }
        else
        {
            Destroy(collider.gameObject);
        }
        Destroy(collider.gameObject);
    }
}
