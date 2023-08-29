using System;
using UnityEngine;

public class Stick : MonoBehaviour
{
    [SerializeField] float throwForce;
    [SerializeField] GameObject stuckEffect;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.AddForce(Vector3.down * throwForce,ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            transform.SetParent(other.collider.transform);
            rb.velocity = Vector3.zero;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.5f, transform.position.z);
            rb.isKinematic = true;
            GameManager.Instance.Score++;
            Instantiate(stuckEffect, new Vector3(0,-0.702f,1.44f), Quaternion.identity);
            GameManager.Instance.SpawnKnife();
        }
        else if (other.gameObject.CompareTag("Stick"))
        {
            Debug.Log("Game Over");
        }
    }
}
