using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pantsCtrl : MonoBehaviour
{
    // タップ可能フラグ
    static bool isTappable;

    // 音声関連
    AudioSource audioSource;
    public AudioClip sePants;

    // ゲームオブジェクト
    GameObject pants;
    GameObject click;

    // Start is called before the first frame update
    void Start()
    {
        // 音声のコンポーネントを取得
        audioSource = GetComponent<AudioSource>();

        // オブジェクトの取得
        pants = GameObject.Find("pants");
        click = GameObject.Find("click");

        // タップ可能にして終了
        isTappable = true;
    }

    // タップしたら
    public void onClick()
    {
        // タップ可能だったら
        if (isTappable)
        {
            // clickを非表示に
            click.SetActive(false);

            // 効果音
            audioSource.PlayOneShot(sePants);

            // パンツの移動関数コール
            StartCoroutine("pantsMove");

            // タップ不可にして終了
            isTappable = false;
        }
    }

    // パンツの移動
    IEnumerator pantsMove()
    {
        for (int i = 0; i < 10; i++)
        {
            pants.transform.Translate(-0.752f, -0.05f, 0);
            yield return new WaitForSeconds(0.02f);
        }
    }
}
