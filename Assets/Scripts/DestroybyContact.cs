using UnityEngine;
using System.Collections;

public class DestroybyContact : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "asteroid")
        {
            Destroy(col.gameObject);
        }
    }
}