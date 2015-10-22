using UnityEngine;
using System.Collections;

public class asteroidSpawner : MonoBehaviour {

    public GameObject asteroidPrototype;

    public float spawnTime;
    float elapsedTime;
    public Transform shipTransform;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
       elapsedTime += Time.deltaTime;

        if (elapsedTime > spawnTime)
        {
            elapsedTime = 0;
            Quaternion randomRotation = new Quaternion();
            float randomYAngle = Random.value * 360;
            randomRotation.eulerAngles = new Vector3(0,randomYAngle,0);

            float randomZ = (Random.value * 11) - 5.5f;
            float randomX = (Random.value * 13) - 6.5f;
            Vector3 randomPosition = new Vector3(randomX, 0, randomZ);
            if (shipTransform != null)
            {
                while (Vector3.Distance(randomPosition, shipTransform.position) < 2)
                {
                    randomZ = (Random.value * 11) - 5.5f;
                    randomX = (Random.value * 13) - 6.5f;
                    randomPosition = new Vector3(randomX, 0, randomZ);
                }
            }
            Instantiate(asteroidPrototype, randomPosition, randomRotation);
        }
	}
}
