using UnityEngine;
using UnityEngine.UI;
public class TIME : MonoBehaviour
{
    public float countdown = 0.0f;
    public Text timeText;
    void Update(){
        //時間をカウントダウンする
        countdown -= Time.deltaTime;
        //時間を表示する
        timeText.text = countdown.ToString   ("f1") + "秒";

        //countdownが0以下になったとき
        if (countdown <= 0){
            timeText.text = "TIME　UP";
        }
        if (countdown <= -2){
            timeText.text = "GAME OVER";
        }
    }
}
