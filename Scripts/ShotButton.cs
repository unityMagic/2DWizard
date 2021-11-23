using UnityEngine;
public class ShotButton : MonoBehaviour
{
    bool AButton = false; //Event Trigger用　bool型変数。　Atackボタンが押されているかどうかを検知
    bool isCalledOnce = false;
    public GameObject bulletPrefab;

    public AudioClip audioClip;
    private AudioSource audioSource;
    private Animator anim = null;
    private Rigidbody2D rb2d; // Rigidbody2Dを保持するメンバ変数

    void Start(){
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();// ゲームオブジェクトが持っているRigidbody2Dコンポーネントを 取得してメンバ変数に保持
    }
    public void ADown(){
        AButton = true;
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = audioClip;
        audioSource.Play();
    }
    public void AUp(){
        AButton = false;
    }
    void Update(){
        if (AButton == true && !isCalledOnce){
            isCalledOnce = true;
            anim.SetBool("isattack", true);
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        }
        else　if (AButton == false){
            isCalledOnce = false;
            anim.SetBool("isattack", false);
        }
    }
}
