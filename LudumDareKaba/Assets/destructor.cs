using UnityEngine;
using System.Collections;

public class destructor : MonoBehaviour {
    void OnTriggerEnter2D(Collider2D coll)
    {
        Destroy(coll.gameObject);
    }
}
