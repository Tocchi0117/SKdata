using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LoadText : MonoBehaviour
{
	//�@�ǂݍ��񂾃e�L�X�g���o�͂���UI�e�L�X�g
	[SerializeField] private Text dataText;
	//�@�ǂލ��ރe�L�X�g���������܂�Ă���.txt�t�@�C��
	[SerializeField] private TextAsset[] textAsset;
	//�@���ݕ\�����e�L�X�g1�ԍ�
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