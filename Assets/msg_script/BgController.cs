using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BgController : MonoBehaviour {
	public RawImage bg;
	public Texture[] bgImages;
	private int bgImagesIndex;
	// Use this for initialization
	void Start () {
		bgImagesIndex = 0;
		bg.texture = bgImages [bgImagesIndex];
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			bgImagesIndex++;
			bg.texture = bgImages [bgImagesIndex];
		}
	}
}
