using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] float rotateSpeed;

    private void Update()
    {
        transform.Rotate(new Vector3(1,0,1),rotateSpeed * Time.deltaTime);
    }
}
