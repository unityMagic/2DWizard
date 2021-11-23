using UnityEngine;
public class Playerline : MonoBehaviour
{
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if ( collision.gameObject.tag == "Map")
        {
             
        }
    }

}