using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightSwitch : MonoBehaviour {

	public GameObject imgDay;
	public GameObject imgNight;

	public const string LAYER_NAME = "background1";
	public const string LAYER_NAME2 = "background2";
	public SpriteRenderer sprite;
	public SpriteRenderer sprite2;

	// Use this for initialization
	void Start () {
		Invoke ("SwitchToDay", 0f);
	}

	void SwitchToNight () {
		sprite2.sortingLayerName = LAYER_NAME2;
		sprite.sortingLayerName = LAYER_NAME;
		LeanTween.rotate (imgNight.GetComponent<RectTransform>(), 360f, 42f);
		LeanTween.rotate (imgDay.GetComponent<RectTransform>(), 360f, 42f);
		LeanTween.alpha(imgDay, 1f,10f).setDelay(31f);
		imgDay.GetComponent<SpriteRenderer>().color = new Color(1f,1f,1f,0f);
		sprite.sortingLayerName = LAYER_NAME2;
		Invoke ("SwitchToDay", 42f);
	}

	void SwitchToDay () {
		sprite.sortingLayerName = LAYER_NAME2;
		sprite2.sortingLayerName = LAYER_NAME;
		LeanTween.rotate (imgDay.GetComponent<RectTransform>(), 360f, 78f);
		LeanTween.rotate (imgNight.GetComponent<RectTransform>(), 360f, 78f);
		LeanTween.alpha(imgNight, 1f, 19f).setDelay(58f);
		imgNight.GetComponent<SpriteRenderer>().color = new Color(1f,1f,1f,0f);
		Invoke ("SwitchToNight", 78f);
	}

	void ResetDay () {
		LeanTween.alpha(imgDay, 1f, 0f);
		imgDay.GetComponent<SpriteRenderer>().color = new Color(1f,1f,1f,1f);
		Invoke ("SwitchToDay", 0f);
	}

	void ResetNight () {
		LeanTween.alpha(imgDay, 1f, 0f);
		imgDay.GetComponent<SpriteRenderer>().color = new Color(1f,1f,1f,1f);
		Invoke ("SwitchToNight", 0f);
	}
}
