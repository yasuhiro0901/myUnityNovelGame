using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextController : MonoBehaviour {
	public string[] scenarios;
	//public Text uiText;
	[SerializeField] Text uiText;
	[SerializeField][Range (0.001f,0.3f)]
	float intervalForCharacterDisplay = 0.05f;

	private int currentLine = 0;
	private string currentText = string.Empty;//now string
	private float timeUntilDisplay = 0;
	private float timeElapsed = 1;
	private int lastUpdateCharacter = -1;//display String Num
	
	// Use this for initialization
	void Start () {
		TextUpdate ();
	}
	
	// Update is called once per frame
	void Update () {
		if (currentLine < scenarios.Length && Input.GetMouseButtonDown (0)) {
			TextUpdate();
		}

		int displayCharacterCount = (int)(Mathf.Clamp01 ((Time.time - timeElapsed) / timeUntilDisplay) * currentText.Length);

		if (displayCharacterCount != lastUpdateCharacter) {
			uiText.text = currentText.Substring(0,displayCharacterCount);
			lastUpdateCharacter = displayCharacterCount;
		}
	}

	void TextUpdate (){
		//uiText.text = scenarios [currentLine];
		currentText = scenarios [currentLine];
		currentLine ++;

		timeUntilDisplay = currentText.Length * intervalForCharacterDisplay;
		timeElapsed = Time.time;

		lastUpdateCharacter = -1;
	}
}
