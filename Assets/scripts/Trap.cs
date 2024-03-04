using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour
{
    public GameObject Sphere;
    public int isTrap;
    void OnTriggerEnter(Collider otherObject)
    {
        if (otherObject.gameObject == Sphere)
        {
            Sphere.GetComponent<Ball>().Respawn(isTrap);
        }
    }
}