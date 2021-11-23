using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject player;
    public int Camera;
    //public int JumpTop;
    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = player.transform.position;
        //カメラとプレイヤーの位置を同じにする
        transform.position = new Vector3(playerPos.x, Camera, -10);
        //transform.position = new Vector3(playerPos.x, JumpTop, -10);
    }
}
