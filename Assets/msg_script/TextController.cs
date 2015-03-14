using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextController : MonoBehaviour {
	public string[] scenarios;
	public Text uiText;

	int currentLine = 0;

	// Use this for initialization
	void Start () {
		TextUpdate ();
	}
	
	// Update is called once per frame
	void Update () {
		if (currentLine < scenarios.Length && Input.GetMouseButtonDown (0)) {
			TextUpdate();
		}
	}

	void TextUpdate (){
		uiText.text = scenarios [currentLine];
		currentLine ++;
	}
}
