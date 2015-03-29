using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CharaController : MonoBehaviour {
	public RawImage centerChara;
	public Texture[] charaImages;
	private int charaImagesIndex;

	// Use this for initialization
	void Start () {
		charaImagesIndex = 0;
		centerChara.texture = charaImages [charaImagesIndex];
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			charaImagesIndex++;
			centerChara.texture = charaImages [charaImagesIndex];
		}
	}
}
