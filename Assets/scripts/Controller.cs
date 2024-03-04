using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour {

    public float tiltSensitivity;

    public Vector3 currentRot;

    void Start () {
    }
    
    void Update () {

        currentRot = GetComponent<Transform> ().eulerAngles;
        
        if (Input.GetKey(KeyCode.RightArrow)  && (currentRot.z >= 349 || currentRot.z <= 11)) 
        {
            transform.Rotate(new Vector3(0, 0, -1) * 50 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow) && (currentRot.z <= 10 || currentRot.z >= 348)) 
        {
            transform.Rotate(new Vector3(0, 0, 1) * 50 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.UpArrow) && (currentRot.x <= 10 || currentRot.x >= 348)) 
        {
            transform.Rotate(new Vector3(1, 0, 0) * 50 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow) && (currentRot.x >= 349 || currentRot.x <= 11)) 
        {
            transform.Rotate(new Vector3(-1, 0, 0) * 50 * Time.deltaTime);
        }

    }

    public void Reset()
    {
        transform.rotation = Quaternion.identity;
    }
}