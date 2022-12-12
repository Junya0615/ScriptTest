using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100; // 体力
    private int power = 25; // 攻撃力
    private int mp = 53; // マジックポイント

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

    // 魔法攻撃用の関数
    public void Magic()
    {
        if (this.mp >= 5)
        {
            // 残りmpを5減らす
            this.mp -= 5;

            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        } else
        {
            Debug.Log("MPが足りないため、魔法が使えない。");
        }
    }
}

public class Test : MonoBehaviour
{

    void Start()
    {
        // 要素数5個の配列を宣言
        int[] array = new int[5];

        // 配列を初期化
        array[0] = 1;
        array[1] = 2;
        array[2] = 3;
        array[3] = 4;
        array[4] = 5;

        // 順番に表示
        for (int i = 0;i < array.Length;i++)
        {
            Debug.Log(array[i]);
        }

        // 逆順に表示
        for (int i = array.Length - 1; i >= 0;i--)
        {
            Debug.Log(array[i]);
        }

        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);
        // 魔法攻撃を11回呼び出す
        for (int i = 0;i < 11;i++)
        {
            lastboss.Magic();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}