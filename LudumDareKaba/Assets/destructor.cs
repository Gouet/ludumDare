using UnityEngine;
using System.Collections;

public class destructor : MonoBehaviour {
    void OnCollisionEnter2D(Collision2D coll)
    {
        Debug.Log("collision name = " + coll.gameObject.name);
        Destroy(coll.gameObject);
    }
}
