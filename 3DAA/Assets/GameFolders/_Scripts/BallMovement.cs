using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class BallMovement : MonoBehaviour
{
    private float rotateSpeed = 120f;
    private Vector3 rotateDirection;
    private void Start()
    {
        rotateDirection = Vector3.one;
        StartCoroutine(DirectionChangeTimeAsync());
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
            rotateSpeed = 180f;
        else if (Input.GetKey(KeyCode.LeftControl))
            rotateSpeed = 75f;
        else
            rotateSpeed = 120f;
        
        if (GameManager.Instance.IsGameOver && rotateSpeed > 0f)
            rotateSpeed -= Time.deltaTime;
        transform.Rotate(rotateDirection,rotateSpeed * Time.deltaTime);
        
    }

    IEnumerator DirectionChangeTimeAsync()
    {
        while (true)
        {
            yield return new WaitForSeconds(4f);
            rotateDirection = new Vector3(Random.Range(1, 4), Random.Range(0, 4), Random.Range(0, 4));    
        }
    }
}
