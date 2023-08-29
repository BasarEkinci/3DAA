using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick : MonoBehaviour
{
    [SerializeField] Transform stickSpawnPoint;
    [SerializeField] GameObject stick;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.AddForce(Vector3.down * (1000 * Time.deltaTime),ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            transform.SetParent(other.collider.transform);
            rb.velocity = Vector3.zero;

            Instantiate(stick, stickSpawnPoint.position, transform.rotation);
        }
    }
}
