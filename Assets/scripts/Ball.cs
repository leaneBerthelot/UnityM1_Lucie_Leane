using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject plane;
    public GameObject winTextObject;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        winTextObject.SetActive(false);
    }
    void Update()
    {
        if (transform.position.y < -10)
        {
            Respawn(1);
        }
    }
    public void Respawn(int destroy)
    {
        plane.GetComponent<Controller>().Reset();
        if (destroy == 1)
        {
            rb.velocity = new Vector3(0, 0, 0);
            transform.position = new Vector3(0, 1.54f, 0);
        }
        else
        {
            winTextObject.SetActive(true);
            GameObject varGameObject = GameObject.Find("Plane");
            varGameObject.GetComponent<Controller>().enabled = false;
            rb.isKinematic = true;
        }
    }
}
