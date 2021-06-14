using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusyuBallController : MonoBehaviour
{
    public Sprite[] busyuS;//部首の画像保存用
    SpriteRenderer SR;//SpriteRenderer保存用変数
    private int RandomBusyu;//
    private float x, y;
    private Vector2 startPos;
    private Vector2 RDestroyPos,LDestroyPos;//指定範囲から出るとオブジェクトを消す値を保存する
    void Mouse()//スワイプ操作
    {
        //スワイプの長さを求める
        if (Input.GetMouseButtonDown(0))
        {
            //マウスをクリックした座標
            startPos = Input.mousePosition;
        }else if (Input.GetMouseButtonUp(0))
        {
            //マウスを離した座標
            Vector2 endPos = Input.mousePosition;
            float Xbusyu = endPos.x - startPos.x;
            float Ybusyu = endPos.y - startPos.y;

            //スワイプの長さを初速度に変換する
            x = Xbusyu / 500.0f;
            y = Ybusyu / 500.0f;
        }
        transform.Translate(x, y, 0);
    }
    void Destroy()
    {
        if (transform.position.x>=RDestroyPos.x|| transform.position.y >= RDestroyPos.y|| transform.position.x <= LDestroyPos.x)
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        SR = gameObject.GetComponent<SpriteRenderer>();//自分のゲームオブジェクトからSpriteRendererを取得
        RandomBusyu = Random.Range(0, 5);//どの部首をだすかの数値をランダムにだす
        SR.sprite = busyuS[RandomBusyu];//RandomBusyuと同じ数値のbusyuSに保存したsprite画像をSRのspriteに保存する
        //Debug.Log(RandomBusyu);
        RDestroyPos = new Vector2(6.5f, 17f);
        LDestroyPos = new Vector2(-6.5f,16.5f);

    }

    // Update is called once per frame
    void Update()
    {
        Mouse();
        Destroy();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("当たった");
        var If = collision.gameObject.GetComponent<Interface>();
        if (If != null)//当たったオブジェクトにInterfaceがあるか
        {
            If.Dameg(RandomBusyu);
        }
    }
}
