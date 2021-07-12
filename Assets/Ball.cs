using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 1.0f;
    private Rigidbody myRigid;
    //privateはこの中で使うという表記、myRigidを宣言している

    // Start is called before the first frame update
    void Start()
    {
        myRigid = this.GetComponent<Rigidbody>();
        //Ballについているコンポーネント(Rigidbodyコンポーネント)を取得し、myRigidに入れている
        myRigid.AddForce((transform.forward + transform.right) * speed, ForceMode.VelocityChange);
        //AddForceは力を加える命令でベクトル(向きと力を合わせた数値)を与えてる
        //ベクトルは(transform.forward + transform.right) * speedでforwardは前でrightは右なので右斜め前に一のスピード
        //ForceModeは色々ありvelocityChangeを今回(このモードは一回だけ力を与えてくれる)は使っている
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
