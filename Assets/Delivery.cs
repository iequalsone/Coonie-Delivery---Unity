using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Package" && !hasPackage) {
            hasPackage = true;
            Destroy(other.gameObject, 1f);
        }

        if (other.tag == "Person" && hasPackage) {
            hasPackage = false;
            Debug.Log("Package delivered");
        }
    }
}
