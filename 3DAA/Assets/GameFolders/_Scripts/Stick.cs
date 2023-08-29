using System;
using UnityEngine;

public class Stick : MonoBehaviour
{
    [SerializeField] Transform stickSpawnPoint;
    [SerializeField] GameObject stick;
    [SerializeField] float throwForce;
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
            rb.isKinematic = true;
            GameManager.Instance.Score++;
            GameManager.Instance.SpawnKnife();
        }
        else if (other.gameObject.CompareTag("Stick"))
        {
            Debug.Log("Game Over");
        }
    }
}
