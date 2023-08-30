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
        if (Input.GetKeyDown(KeyCode.Space) && !GameManager.Instance.IsGameOver)
        { 
            rb.AddForce(Vector3.forward * throwForce,ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            transform.SetParent(other.collider.transform);
            rb.velocity = Vector3.zero;
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.5f);
            rb.isKinematic = true;
            GameManager.Instance.Score++;
            Instantiate(stuckEffect, new Vector3(0,-1.88f,2f), Quaternion.identity);
            GameManager.Instance.SpawnKnife();
        }
        else if (other.gameObject.CompareTag("Stick"))
        {
            GameManager.Instance.IsGameOver = true;
        }
    }
}
