using UnityEngine;
using System.Collections;

public class MatoBehavior : MonoBehaviour {
	private Vector2 m_pos;

	// コンストラクタ
	void Start () {
		// 初期位置の情報を取得
		m_pos = transform.localPosition;
	}
	
	// Update is called once per frame
	// 1フレームごとの呼び出し
	void Update () {
		// 現在位置を変更
		transform.localPosition = m_pos;
		// 現在位置の更新情報を作成
		m_pos.y -= 0.50f;
	}
}
