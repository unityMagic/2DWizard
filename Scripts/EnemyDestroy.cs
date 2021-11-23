using UnityEngine;

//マップにマジックタグのエフェクトが付いたら消す処理
public class EnemyDestroy : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    { 
        if (collision.gameObject.tag == "Shot")
        {
           Destroy(gameObject);
        }
    }
}