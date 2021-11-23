using UnityEngine;
public class ShotDestroy : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Shot")
        {
            Destroy(gameObject);
        }
    }
}
