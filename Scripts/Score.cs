using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Text text;
    public GameObject score = null; // Textオブジェクト
    public int score_num = 10; // スコア変数

    // Update is called once per frame
    void Update(){
        if (score_num ==0)
        {
            Text score_text = score.GetComponent<Text>();
            score_text.text = "GAMEクリア";
           // SceneManager.LoadScene("Clear");
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Koin")
        {
            Text score_text = score.GetComponent<Text>();
            score_num -= 1; // とりあえず1
            score_text.text = "残りコイン" + score_num+"枚";
        }
    }
}
