using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharactorController : MonoBehaviour
{
    private float speed = 0.01f;
    //---ここから追加----
    private SpriteRenderer renderer;
    //---ここまで追加----

    public int m_nextExpBase; // 次のレベルまでに必要な経験値の基本値
    public int m_nextExpInterval; // 次のレベルまでに必要な経験値の増加値
    public int m_level; // レベル
    public int m_exp; // 経験値
    public int m_prevNeedExp; // 前のレベルに必要だった経験値
    public int m_needExp; // 次のレベルに必要な経験値

    public static MoveCharactorController instance;

    public void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    

    public void AddExp( int exp )
    {
        // 経験値を増やす
        m_exp += exp;

        // まだレベルアップに必要な経験値に足りていない場合、ここで処理を終える
        if ( m_exp < m_needExp ) return;
        
        // レベルアップする
        m_level++;

        // 今回のレベルアップに必要だった経験値を記憶しておく
        // （経験値ゲージの表示に使用するため）
        m_prevNeedExp = m_needExp;

        // 次のレベルアップに必要な経験値を計算する
        m_needExp = GetNeedExp( m_level );

        // // レベルアップした時にボムを発動する
        // // ボムの発射数や速さは決め打ちで定義しているため
        // // 必要であれば public 変数にして、
        // // Unity エディタ上で設定できるように変更してください
        // var angleBase = 0;
        // var angleRange = 360;
        // var count = 28;
        // ShootNWay( angleBase, angleRange, 0.15f, count );
        // ShootNWay( angleBase, angleRange, 0.2f, count );
        // ShootNWay( angleBase, angleRange, 0.25f, count );
    }

    // 指定されたレベルに必要な経験値を計算する関数
    private int GetNeedExp( int level )
    {
        /*
        * 例えば、m_nextExpBase が 16、m_nextExpInterval が 18 の場合、
        *
        * レベル 1：16 + 18 * 0 = 16
        * レベル 2：16 + 18 * 1 = 34
        * レベル 3：16 + 18 * 4 = 88
        * レベル 4：16 + 18 * 9 = 178
        *
        * このような計算式になり、レベルが上がるほど必要な経験値が増えていく
        */
        return m_nextExpBase + 
            m_nextExpInterval * ( ( level - 1 ) * ( level - 1 ) );
    }

    void Start()
    {
        //---ここから追加----
        renderer = GetComponent<SpriteRenderer>();
        //---ここまで追加----
    }

    void Update()
    {
        if (Mathf.Approximately(Time.timeScale, 0f)) {
		return;
	}
        Vector2 position = transform.position;

        if (Input.GetKey("left"))
        {
            position.x -= speed;
        　//---ここから追加----
            renderer.flipX = false;
        　//---ここまで追加----
        }
        else if (Input.GetKey("right"))
        {
            position.x += speed;
        　//---ここから追加----
            renderer.flipX = true;
        　//---ここまで追加----
        }
        else if (Input.GetKey("up"))
        {
            position.y += speed;
        }
        else if (Input.GetKey("down"))
        {
            position.y -= speed;
        }

        transform.position = position;
    }
}