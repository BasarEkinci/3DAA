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
        rotateDirection = Vector3.one;
        StartCoroutine(DirectionChangeTimeAsync());
    }

    private void Update()
    {
        transform.Rotate(rotateDirection,rotateSpeed * Time.deltaTime);
        if (GameManager.Instance.IsGameOver && rotateSpeed > 0)
        {
            rotateSpeed -= 40f * Time.deltaTime;
        }
    }

    IEnumerator DirectionChangeTimeAsync()
    {
        while (true)
        {
            yield return new WaitForSeconds(4f);
            rotateDirection = new Vector3(Random.Range(1, 2), Random.Range(0, 2), Random.Range(0, 2));    
        }
    }


}
