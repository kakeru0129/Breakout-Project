using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 1.0f;
    //publicをつけることによりInspectorでspeedの数値をいじれる

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.transform.position.x > -4)
            //このTransformのposition(位置)のxの数値が−４より大きければ(壁まできたら動かなくなる)
            {
                //一行の場合は波括弧を省略しても良いが今回は分かりやすくするために波括弧をつけておく
                this.transform.position += Vector3.left * speed * Time.deltaTime;
                //PlayerのPositionを左にスピードに動いて欲しい
                //Vector3はx,y,zのこと、Time.deltaTimeはパソコンによって移動速度が変わるため記述
            }
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (this.transform.position.x < 4)
                this.transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }
}