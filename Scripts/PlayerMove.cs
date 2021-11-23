using UnityEngine;
public class PlayerMove : MonoBehaviour
{
    private Animator anim = null;
    public float sx = 0; //x方向移動量を入れる変数
    public bool Rnow = true; //Event Trigger用　bool型変数。　Rボタンが押されているかどうかを検知
    public bool Lnow = true; //Event Trigger用　bool型変数。　Lボタンが押されているかどうかを検知
    public bool Jump = true; //Event Trigger用　bool型変数。　Jumpボタンが押されているかどうかを検知
    public bool Jumpcheck = true; //Event Trigger用　bool型変数。　Jumpボタンが押されているかどうかを検知
    private Rigidbody2D rb2d; // Rigidbody2Dを保持するメンバ変数
    public float jumpForce;// ジャンプ力

    void Start(){
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();// ゲームオブジェクトが持っているRigidbody2Dコンポーネントを 取得してメンバ変数に保持
    }
    public void UPRnow(){
        Rnow = true;
    }
    public void DownRnow(){
        Rnow = false;
    }
    public void UPLnow(){
        Lnow = true;
    }
    public void DownLnow(){
        Lnow = false;
    }
    public void UPJump(){ 
        Jump = true;
    }
    public void DownJump(){
        Jump = false;
    }

  
    //UpdateをFixedUpdateに変更
    void FixedUpdate()
    {
      Vector3 scale = transform.localScale;
        if (Rnow == true){
           //anim.SetBool("Dash2", true);
            this.sx = 0f;
            transform.Translate(this.sx, 0, 0);
        }
        if (Rnow == false){
            //anim.SetBool("Dash2", false);
            this.sx =0.1f;  
            transform.Translate(this.sx, 0, 0);
        }
        if (Lnow == true){
           // anim.SetBool("Dash1", true);
            this.sx = 0f;
            transform.Translate(this.sx, 0, 0);
        }
        if (Lnow == false){
           // anim.SetBool("Dash1", false);
            this.sx = -0.1f;
            transform.Translate(this.sx, 0, 0);
        }
        if (Jump == true){
          //  anim.SetBool("Jump", true);
            //this.sy = 0f;
            //transform.Translate(0, this.sy, 0);
        }
        if (Jump == false && Jumpcheck){
          //  anim.SetBool("Jump", false);
            rb2d.AddForce(Vector2.up * jumpForce);
            Jumpcheck = true;
            //this.sy = 0.5f;
            //transform.Translate(0, this.sy, 0);
        }  

    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Top"))
        {
            Jumpcheck = false;
        }
        else
        {
            Jumpcheck = true;
        }
    }
}
