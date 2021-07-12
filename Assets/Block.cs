using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //blockはstartもupdateも使わない今回はオブジェクトがブロックに当たるとき

    private void OnCollisionEnter(Collision collision)
    //OnCollisionEnterはブロックに何かあたった時の処理をかける(今回はDestroy(this.gameObject)でこのオブジェクトを消す)
    //(Collision collision)の後ろのcollisionは何が当たったかを持ってこれるが今回は何に当たっても消されるため一応記述してある
    {
        Destroy(this.gameObject);
    }
}