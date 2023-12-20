using UnityEngine;

public class DeadPlayer : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player")) 
        {
            Destroy(other.gameObject);
        }
    }
}
