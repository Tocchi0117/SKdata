using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LoadText : MonoBehaviour
{
	//　読み込んだテキストを出力するUIテキスト
	[SerializeField] private Text dataText;
	//　読む込むテキストが書き込まれている.txtファイル
	[SerializeField] private TextAsset[] textAsset;
	//　現在表示中テキスト1番号
	int textNum1;

	public static TextAsset TA;
	bool flag;


	void Start()
	{
		TA = textAsset[Random.Range(0, textAsset.Length)];
		dataText.text = TA.text;
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.J))
		{
			TA = textAsset[Random.Range(0, textAsset.Length)];
			dataText.text = TA.text;
		}

		//Debug.Log(TA.name);
	}
}