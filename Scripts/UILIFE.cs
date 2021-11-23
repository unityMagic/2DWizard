using UnityEngine;
using UnityEngine.SceneManagement;

public class UILIFE : MonoBehaviour
{
    public GameObject Hart1;
    public GameObject Hart2;
    public GameObject Hart3;
    public GameObject Hart4;
    public GameObject Hart5;
    int    LIFE =5 ;
    public float Back = -1; //x方向移動量を入れる変数
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            LIFE -= 1;
            transform.Translate(this.Back, 0, 0);
            if (LIFE < 5)
                Hart1.SetActive(false); 
            if (LIFE < 4)
                Hart2.SetActive(false);
            if (LIFE < 3)
                Hart3.SetActive(false);
            if (LIFE < 2)
                Hart4.SetActive(false);
            if (LIFE < 1)
                Hart5.SetActive(false);//SceneManager.LoadScene("Over");
                 
        }
        if (collision.gameObject.tag == "Ally")
        {
            LIFE = 5;
            Hart1.SetActive(true);   
            Hart2.SetActive(true);       
            Hart3.SetActive(true);
            Hart4.SetActive(true);
            Hart5.SetActive(true);
        }
        if (collision.gameObject.tag == "DEATH")
        {
            LIFE = 0;
            Hart1.SetActive(false);
            Hart2.SetActive(false);
            Hart3.SetActive(false);
            Hart4.SetActive(false);
            Hart5.SetActive(false);
        }
        if (LIFE<1) {
            //SceneManager.LoadScene("Over");
        }
    }
}
