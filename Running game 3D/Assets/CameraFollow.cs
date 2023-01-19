using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform runner;
    Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - runner.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = runner.position + offset;
        //targetPosition.x = 0;
        transform.position = targetPosition;
    }
}
