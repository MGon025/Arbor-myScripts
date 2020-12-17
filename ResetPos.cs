using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPos : MonoBehaviour
{
    public string resetButton = "p";

    private Vector3 startPos;
    private Quaternion startRot;

    void Start() {
        startPos = transform.position;
        startRot = transform.rotation;
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(resetButton.ToLower()))
        {
            transform.position = startPos;
            transform.rotation = startRot;
        }
    }
}
