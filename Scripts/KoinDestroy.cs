using UnityEngine;
public class KoinDestroy : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    { 
        if (collision.gameObject.tag == "Player")
        {
           Destroy(gameObject);
        }
    }
}
