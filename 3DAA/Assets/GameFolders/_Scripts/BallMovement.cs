using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class BallMovement : MonoBehaviour
{
    [SerializeField] float rotateSpeed;
    private Vector3 rotateDirection;


    private void Start()
    {
        StartCoroutine(DirectionChangeTime());
    }

    private void Update()
    {
        transform.Rotate(rotateDirection,rotateSpeed * Time.deltaTime);
    }

    IEnumerator DirectionChangeTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(4f);
            rotateDirection = new Vector3(Random.Range(0, 2), Random.Range(0, 2), Random.Range(0, 2));    
        }
    }
}
