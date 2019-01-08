using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerLookInGame : MonoBehaviour {

	public List<Sprite> ListHat1;
	public SpriteRenderer HatRenderer1;
	public List<Sprite> ListHat2;
	public SpriteRenderer HatRenderer2;
	public List<Sprite> ListBackHair;
	public SpriteRenderer BackHairRenderer;
	public List<Sprite> ListFrontHair;
	public SpriteRenderer FrontHairRenderer;
	public List<Sprite> ListEyebrows;
	public SpriteRenderer EyebrowsRenderer;
	public List<Sprite> ListEyes;
	public SpriteRenderer EyesRenderer;
	public List<Sprite> ListMustache;
	public SpriteRenderer MustacheRenderer;
	public List<Sprite> ListHand;
	public SpriteRenderer HandRenderer;
	public List<Sprite> ListNeck;
	public SpriteRenderer NeckRenderer;
	public List<Sprite> ListFace;
	public SpriteRenderer FaceRenderer;
	public List<Sprite> ListShirt;
	public SpriteRenderer ShirtRenderer;
	public List<Sprite> ListOveralls;
	public SpriteRenderer OverallsRenderer;
	public List<Sprite> ListSleeves;
	public SpriteRenderer SleevesRenderer;
	public List<Sprite> ListBoots;
	public SpriteRenderer BootsRenderer;
	public SpriteRenderer MouthRenderer;

	int iGender = 0;
	int iHat1 = 0;
	int iHat2 = 0;
	int iBackHair = 0;
	int iFrontHair = 0;
	int iEyebrows = 0;
	int iEyes = 0;
	int iMustache = 0;
	int iHand = 0;
	int iNeck = 0;
	int iFace = 0;
	int iShirt = 0;
	int iOveralls = 0;
	int iSleeves = 0;
	int iBoots = 0;

	void Awake () {
		iGender = PlayerPrefs.GetInt("Gender");
		iHat1 = PlayerPrefs.GetInt("Hat 1");
		iHat2 = PlayerPrefs.GetInt("Hat 2");
		iBackHair = PlayerPrefs.GetInt("Back Hair");
		iFrontHair = PlayerPrefs.GetInt("Front Hair");
		iEyebrows = PlayerPrefs.GetInt("Eyebrows");
		iEyes = PlayerPrefs.GetInt("Eyes");
		iMustache = PlayerPrefs.GetInt("Mustache");
		iHand = PlayerPrefs.GetInt("Hand");
		iNeck = PlayerPrefs.GetInt("Neck");
		iFace = PlayerPrefs.GetInt("Face");
		iShirt = PlayerPrefs.GetInt("Shirt");
		iOveralls = PlayerPrefs.GetInt("Overalls");
		iSleeves = PlayerPrefs.GetInt("Sleeves");
		iBoots = PlayerPrefs.GetInt("Boots");
		Debug.Log ("Player look restored");
		HatRenderer1.sprite = ListHat1 [iHat1];
		HatRenderer2.sprite = ListHat2 [iHat2];
		BackHairRenderer.sprite = ListBackHair [iBackHair];
		FrontHairRenderer.sprite = ListFrontHair [iFrontHair];
		EyebrowsRenderer.sprite = ListEyebrows [iEyebrows];
		EyesRenderer.sprite = ListEyes [iEyes];
		MustacheRenderer.sprite = ListMustache [iMustache];
		HandRenderer.sprite = ListHand [iHand];
		NeckRenderer.sprite = ListNeck [iNeck];
		FaceRenderer.sprite = ListFace [iFace];
		ShirtRenderer.sprite = ListShirt [iShirt];
		OverallsRenderer.sprite = ListOveralls [iOveralls];
		SleevesRenderer.sprite = ListSleeves [iSleeves];
		BootsRenderer.sprite = ListBoots [iBoots];
		if (iGender == -1) {
			BackHairRenderer.GetComponent<Renderer>().enabled = false;
			MouthRenderer.GetComponent<Renderer>().enabled = false;
			MustacheRenderer.GetComponent<Renderer>().enabled = true;
		} else {
			BackHairRenderer.GetComponent<Renderer>().enabled = true;
			MouthRenderer.GetComponent<Renderer>().enabled = true;
			MustacheRenderer.GetComponent<Renderer>().enabled = false;
		}
	}

		
}
