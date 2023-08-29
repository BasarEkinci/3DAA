using UnityEngine;

public class ParticleEffect : MonoBehaviour
{
    private void OnEnable()
    {
        Destroy(gameObject,1.5f);        
    }
}
