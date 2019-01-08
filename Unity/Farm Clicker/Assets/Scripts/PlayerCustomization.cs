using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerCustomization : MonoBehaviour {
//git
	public GameObject btnBoy;
	public GameObject btnGirl;
	public GameObject btnNextHat;
	public GameObject btnPrevHat;
	public GameObject btnNextHair;
	public GameObject btnPrevHair;
	public GameObject btnNextEyebrows;
	public GameObject btnPrevEyebrows;
	public GameObject btnNextEyes;
	public GameObject btnPrevEyes;
	public GameObject btnNextMustache;
	public GameObject btnPrevMustache;
	public GameObject btnNextSkin;
	public GameObject btnPrevSkin;
	public GameObject btnNextShirt;
	public GameObject btnPrevShirt;
	public GameObject btnNextOveralls;
	public GameObject btnPrevOveralls;
	public GameObject btnNextSleeves;
	public GameObject btnPrevSleeves;
	public GameObject btnNextBoots;
	public GameObject btnPrevBoots;
	public GameObject imgMouth;
	public GameObject btnBack;
	public GameObject panelPlayerCustomization;
	public GameObject panelMenu;

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

	//Player
	public GameObject imgFace;
	public GameObject imgOveralls;
	public GameObject imgNeck;
	public GameObject imgHand;
	public GameObject imgShirt;
	public GameObject imgFrontHair;
	public GameObject imgBackHair;
	public GameObject imgEyebrows;
	public GameObject imgEyes;
	public GameObject imgHat1;
	public GameObject imgHat2;
	public GameObject imgSleeves;
	public GameObject imgMustache;
	public GameObject imgBoots;
	public GameObject imgMouth1;

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
    int RandomGender;
    int RandomHat;
    int RandomHair;
    int RandomEyebrows;
    int RandomEyes;
    int RandomMustache;
    int RandomSkin;
    int RandomShirt;
    int RandomOveralls;
    int RandomSleeves;
    int RandomBoots;

	public AudioClip BtnSound;
	AudioSource m_source;

	void Start () {
		m_source = gameObject.GetComponent<AudioSource>();
        iGender = -1;
		HatRenderer1.sprite = ListHat1[iHat1];
		HatRenderer2.sprite = ListHat2[iHat2];
		FrontHairRenderer.sprite = ListFrontHair[iFrontHair];
        EyebrowsRenderer.sprite = ListEyebrows[iEyebrows];
        EyesRenderer.sprite = ListEyes[iEyes];
        MustacheRenderer.sprite = ListMustache[iMustache];
        HandRenderer.sprite = ListHand[iHand];
        NeckRenderer.sprite = ListNeck[iNeck];
        FaceRenderer.sprite = ListFace[iFace];
        ShirtRenderer.sprite = ListShirt[iShirt];
        OverallsRenderer.sprite = ListOveralls[iOveralls];
        SleevesRenderer.sprite = ListSleeves[iSleeves];
        BootsRenderer.sprite = ListBoots[iBoots];
		MouthRenderer.GetComponent<Renderer>().enabled = false;
		btnBoy.GetComponent<Button>().interactable = false;
		btnGirl.GetComponent<Button>().interactable = true;
	}

    public void onBtnRandomClick () {
		m_source.clip = BtnSound;
		m_source.Play();
        RandomGender = Random.Range(-5, 5);
        if (RandomGender <= 0) {
            RandomGender = -1;
        } else {
            RandomGender = 1;
        }
        Invoke ("PlayerGen", 0f);
	}

    public void PlayerGen () {
        RandomHat = Random.Range(0, 9);
        RandomHair = Random.Range(0, 14);
        RandomEyebrows = Random.Range(0, 14);
        RandomEyes = Random.Range(0, 6);
        RandomMustache = Random.Range(0, 14);
        RandomSkin = Random.Range(0, 5);
        RandomShirt = Random.Range(0, 10);
        RandomOveralls = Random.Range(0, 10);
        RandomSleeves = Random.Range(0, 10);
        RandomBoots = Random.Range(0, 2);

		iHat1 = RandomHat;
		iHat2 = RandomHat;
		iBackHair = RandomHair;
		iFrontHair = RandomHair;
		iEyebrows = RandomEyebrows;
		iEyes = RandomEyes;
		iMustache = RandomMustache;
		iHand = RandomSkin;
		iNeck = RandomSkin;
		iFace = RandomSkin;
		iShirt = RandomShirt;
		iOveralls = RandomOveralls;
		iSleeves = RandomSleeves;
		iBoots = RandomBoots;

        HatRenderer1.sprite = ListHat1[RandomHat];
		HatRenderer2.sprite = ListHat2[RandomHat];
		FrontHairRenderer.sprite = ListFrontHair[RandomHair];
		BackHairRenderer.sprite = ListBackHair[RandomHair];
        EyebrowsRenderer.sprite = ListEyebrows[RandomEyebrows];
        EyesRenderer.sprite = ListEyes[RandomEyes];
        MustacheRenderer.sprite = ListMustache[RandomMustache];
        HandRenderer.sprite = ListHand[RandomSkin];
        NeckRenderer.sprite = ListNeck[RandomSkin];
        FaceRenderer.sprite = ListFace[RandomSkin];
        ShirtRenderer.sprite = ListShirt[RandomShirt];
        OverallsRenderer.sprite = ListOveralls[RandomOveralls];
        SleevesRenderer.sprite = ListSleeves[RandomSleeves];
        BootsRenderer.sprite = ListBoots[RandomBoots];
        
        if (RandomGender == -1) {
            iGender = RandomGender;
            LeanTween.moveLocalY(btnNextSkin, -32f, 0f);
            LeanTween.moveLocalY(btnNextShirt, -108f, 0f);
            LeanTween.moveLocalY(btnNextOveralls, -183f, 0f);
            LeanTween.moveLocalY(btnNextSleeves, -258f, 0f);
            LeanTween.moveLocalY(btnNextBoots, -333f, 0f);

            LeanTween.moveLocalY(btnPrevSkin, -32f, 0f);
            LeanTween.moveLocalY(btnPrevShirt, -108f, 0f);
            LeanTween.moveLocalY(btnPrevOveralls, -183f, 0f);
            LeanTween.moveLocalY(btnPrevSleeves, -258f, 0f);
            LeanTween.moveLocalY(btnPrevBoots, -333f, 0f);

            btnBoy.GetComponent<Button>().interactable = false;
            btnGirl.GetComponent<Button>().interactable = true;
            BackHairRenderer.GetComponent<Renderer>().enabled = false;
            MouthRenderer.GetComponent<Renderer>().enabled = false;
            MustacheRenderer.GetComponent<Renderer>().enabled = true;
        }

        if (RandomGender == 1) {
            iGender = RandomGender;
            LeanTween.moveLocalY(btnNextSkin, 43f, 0f);
            LeanTween.moveLocalY(btnNextShirt, -32f, 0f);
            LeanTween.moveLocalY(btnNextOveralls, -108f, 0f);
            LeanTween.moveLocalY(btnNextSleeves, -183f, 0f);
            LeanTween.moveLocalY(btnNextBoots, -258f, 0f);

            LeanTween.moveLocalY(btnPrevSkin, 43f, 0f);
            LeanTween.moveLocalY(btnPrevShirt, -32f, 0f);
            LeanTween.moveLocalY(btnPrevOveralls, -108f, 0f);
            LeanTween.moveLocalY(btnPrevSleeves, -183f, 0f);
            LeanTween.moveLocalY(btnPrevBoots, -258f, 0f);

            btnGirl.GetComponent<Button>().interactable = false;
            btnBoy.GetComponent<Button>().interactable = true;
            BackHairRenderer.GetComponent<Renderer>().enabled = true;
            BackHairRenderer.sprite = ListBackHair[iBackHair];
            MustacheRenderer.GetComponent<Renderer>().enabled = false;
            MouthRenderer.GetComponent<Renderer>().enabled = true;
        }
    }

	public void onBtnBoyClick () {
		m_source.clip = BtnSound;
		m_source.Play();
		iGender = -1;
        LeanTween.moveLocalX(btnNextHat, 1250f, 1f);
        LeanTween.moveLocalX(btnNextHair, 1250f, 1f);
        LeanTween.moveLocalX(btnNextEyebrows, 1250f, 1f);
        LeanTween.moveLocalX(btnNextEyes, 1250f, 1f);
        LeanTween.moveLocalX(btnNextMustache, 1250f, 1f);
        LeanTween.moveLocalX(btnNextSkin, 1250f, 1f);
        LeanTween.moveLocalX(btnNextShirt, 1250f, 1f);
        LeanTween.moveLocalX(btnNextOveralls, 1250f, 1f);
        LeanTween.moveLocalX(btnNextSleeves, 1250f, 1f);
        LeanTween.moveLocalX(btnNextBoots, 1250f, 1f);

        LeanTween.moveLocalX(btnPrevHat, -1250f, 1f);
        LeanTween.moveLocalX(btnPrevHair, -1250f, 1f);
        LeanTween.moveLocalX(btnPrevEyebrows, -1250f, 1f);
        LeanTween.moveLocalX(btnPrevEyes, -1250f, 1f);
        LeanTween.moveLocalX(btnPrevMustache, -1250f, 1f);
        LeanTween.moveLocalX(btnPrevSkin, -1250f, 1f);
        LeanTween.moveLocalX(btnPrevShirt, -1250f, 1f);
        LeanTween.moveLocalX(btnPrevOveralls, -1250f, 1f);
        LeanTween.moveLocalX(btnPrevSleeves, -1250f, 1f);
        LeanTween.moveLocalX(btnPrevBoots, -1250f, 1f);

        btnBoy.GetComponent<Button>().interactable = false;
        btnGirl.GetComponent<Button>().interactable = true;
        BackHairRenderer.GetComponent<Renderer>().enabled = false;
        MouthRenderer.GetComponent<Renderer>().enabled = false;
        MustacheRenderer.GetComponent<Renderer>().enabled = true;
        Invoke("returnBtnBoy", 1f);
	}

	public void onBtnGirlClick () {
		m_source.clip = BtnSound;
		m_source.Play();
		iGender = 1;
        LeanTween.moveLocalX(btnNextHat, 1250f, 1f);
        LeanTween.moveLocalX(btnNextHair, 1250f, 1f);
        LeanTween.moveLocalX(btnNextEyebrows, 1250f, 1f);
        LeanTween.moveLocalX(btnNextEyes, 1250f, 1f);
        LeanTween.moveLocalX(btnNextMustache, 1250f, 1f);
        LeanTween.moveLocalX(btnNextSkin, 1250f, 1f);
        LeanTween.moveLocalX(btnNextShirt, 1250f, 1f);
        LeanTween.moveLocalX(btnNextOveralls, 1250f, 1f);
        LeanTween.moveLocalX(btnNextSleeves, 1250f, 1f);
        LeanTween.moveLocalX(btnNextBoots, 1250f, 1f);

        LeanTween.moveLocalX(btnPrevHat, -1250f, 1f);
        LeanTween.moveLocalX(btnPrevHair, -1250f, 1f);
        LeanTween.moveLocalX(btnPrevEyebrows, -1250f, 1f);
        LeanTween.moveLocalX(btnPrevEyes, -1250f, 1f);
        LeanTween.moveLocalX(btnPrevMustache, -1250f, 1f);
        LeanTween.moveLocalX(btnPrevSkin, -1250f, 1f);
        LeanTween.moveLocalX(btnPrevShirt, -1250f, 1f);
        LeanTween.moveLocalX(btnPrevOveralls, -1250f, 1f);
        LeanTween.moveLocalX(btnPrevSleeves, -1250f, 1f);
        LeanTween.moveLocalX(btnPrevBoots, -1250f, 1f);

        btnGirl.GetComponent<Button>().interactable = false;
        btnBoy.GetComponent<Button>().interactable = true;
        BackHairRenderer.GetComponent<Renderer>().enabled = true;
        BackHairRenderer.sprite = ListBackHair[iBackHair];
        MustacheRenderer.GetComponent<Renderer>().enabled = false;
        MouthRenderer.GetComponent<Renderer>().enabled = true;
        Invoke("returnBtnGirl", 1f);
	}

    public void returnBtnGirl () {
        LeanTween.moveLocalX(btnNextHat, 620f, 1f);
        LeanTween.moveLocalX(btnNextHair, 620f, 1f);
        LeanTween.moveLocalX(btnNextEyebrows, 620f, 1f);
        LeanTween.moveLocalX(btnNextEyes, 620f, 1f);
        LeanTween.moveLocalX(btnNextSkin, 620f, 1f);
        LeanTween.moveLocalY(btnNextSkin, 43f, 0f);
        LeanTween.moveLocalX(btnNextShirt, 620f, 1f);
        LeanTween.moveLocalY(btnNextShirt, -32f, 0f);
        LeanTween.moveLocalX(btnNextOveralls, 620f, 1f);
        LeanTween.moveLocalY(btnNextOveralls, -108f, 0f);
        LeanTween.moveLocalX(btnNextSleeves, 620f, 1f);
        LeanTween.moveLocalY(btnNextSleeves, -183f, 0f);
        LeanTween.moveLocalX(btnNextBoots, 620f, 1f);
        LeanTween.moveLocalY(btnNextBoots, -258f, 0f);

        LeanTween.moveLocalX(btnPrevHat, -638f, 1f);
        LeanTween.moveLocalX(btnPrevHair, -638f, 1f);
        LeanTween.moveLocalX(btnPrevEyebrows, -638f, 1f);
        LeanTween.moveLocalX(btnPrevEyes, -638f, 1f);
        LeanTween.moveLocalX(btnPrevSkin, -638f, 1f);
        LeanTween.moveLocalY(btnPrevSkin, 43f, 0f);
        LeanTween.moveLocalX(btnPrevShirt, -638f, 1f);
        LeanTween.moveLocalY(btnPrevShirt, -32f, 0f);
        LeanTween.moveLocalX(btnPrevOveralls, -638f, 1f);
        LeanTween.moveLocalY(btnPrevOveralls, -108f, 0f);
        LeanTween.moveLocalX(btnPrevSleeves, -638f, 1f);
        LeanTween.moveLocalY(btnPrevSleeves, -183f, 0f);
        LeanTween.moveLocalX(btnPrevBoots, -638f, 1f);
        LeanTween.moveLocalY(btnPrevBoots, -258f, 0f);
    }

    public void returnBtnBoy () {
        LeanTween.moveLocalX(btnNextHat, 620f, 1f);
        LeanTween.moveLocalX(btnNextHair, 620f, 1f);
        LeanTween.moveLocalX(btnNextEyebrows, 620f, 1f);
        LeanTween.moveLocalX(btnNextEyes, 620f, 1f);
        LeanTween.moveLocalX(btnNextMustache, 620f, 1f);
        LeanTween.moveLocalX(btnNextSkin, 620f, 1f);
        LeanTween.moveLocalY(btnNextSkin, -32f, 0f);
        LeanTween.moveLocalX(btnNextShirt, 620f, 1f);
        LeanTween.moveLocalY(btnNextShirt, -108f, 0f);
        LeanTween.moveLocalX(btnNextOveralls, 620f, 1f);
        LeanTween.moveLocalY(btnNextOveralls, -183f, 0f);
        LeanTween.moveLocalX(btnNextSleeves, 620f, 1f);
        LeanTween.moveLocalY(btnNextSleeves, -258f, 0f);
        LeanTween.moveLocalX(btnNextBoots, 620f, 1f);
        LeanTween.moveLocalY(btnNextBoots, -333f, 0f);

        LeanTween.moveLocalX(btnPrevHat, -638f, 1f);
        LeanTween.moveLocalX(btnPrevHair, -638f, 1f);
        LeanTween.moveLocalX(btnPrevEyebrows, -638f, 1f);
        LeanTween.moveLocalX(btnPrevEyes, -638f, 1f);
        LeanTween.moveLocalX(btnPrevMustache, -638f, 1f);
        LeanTween.moveLocalX(btnPrevSkin, -638f, 1f);
        LeanTween.moveLocalY(btnPrevSkin, -32f, 0f);
        LeanTween.moveLocalX(btnPrevShirt, -638f, 1f);
        LeanTween.moveLocalY(btnPrevShirt, -108f, 0f);
        LeanTween.moveLocalX(btnPrevOveralls, -638f, 1f);
        LeanTween.moveLocalY(btnPrevOveralls, -183f, 0f);
        LeanTween.moveLocalX(btnPrevSleeves, -638f, 1f);
        LeanTween.moveLocalY(btnPrevSleeves, -258f, 0f);
        LeanTween.moveLocalX(btnPrevBoots, -638f, 1f);
        LeanTween.moveLocalY(btnPrevBoots, -333f, 0f);
    }

	public void onBtnNextHatClick () {
		m_source.clip = BtnSound;
		m_source.Play();
		iHat1++;
		iHat2++;
		if (iHat1 > 8 && iHat2 > 8) {
			iHat1 = 0;
			iHat2 = 0;
		}
		HatRenderer1.sprite = ListHat1[iHat1];
		HatRenderer2.sprite = ListHat2[iHat2];
	}

	public void onBtnPrevHatClick () {
		m_source.clip = BtnSound;
		m_source.Play();
		iHat1--;
		iHat2--;
		if (iHat1 < 0 && iHat2 < 0) {
			iHat1 = 8;
			iHat2 = 8;
		}
		HatRenderer1.sprite = ListHat1[iHat1];
		HatRenderer2.sprite = ListHat2[iHat2];
	}

    public void onBtnNextHairClick () {
		m_source.clip = BtnSound;
		m_source.Play();
		iBackHair++;
		iFrontHair++;
		if (iBackHair > 13 && iFrontHair > 13) {
			iBackHair = 0;
			iFrontHair = 0;
		}
        if (iGender > 0) {
            BackHairRenderer.sprite = ListBackHair[iBackHair];
        }
		FrontHairRenderer.sprite = ListFrontHair[iFrontHair];
	}

	public void onBtnPrevHairClick () {
		m_source.clip = BtnSound;
		m_source.Play();
		iBackHair--;
		iFrontHair--;
		if (iBackHair < 0 && iFrontHair < 0) {
			iBackHair = 13;
			iFrontHair = 13;
		}
		if (iGender > 0) {
            BackHairRenderer.sprite = ListBackHair[iBackHair];
        }
		FrontHairRenderer.sprite = ListFrontHair[iFrontHair];
	}

    public void onBtnNextEyebrowsClick () {
		m_source.clip = BtnSound;
		m_source.Play();
		iEyebrows++;
		if (iEyebrows > 13) {
			iEyebrows = 0;
		}
		EyebrowsRenderer.sprite = ListEyebrows[iEyebrows];
	}

	public void onBtnPrevEyebrowsClick () {
		m_source.clip = BtnSound;
		m_source.Play();
		iEyebrows--;
		if (iEyebrows < 0) {
			iEyebrows = 13;
		}
		EyebrowsRenderer.sprite = ListEyebrows[iEyebrows];
	}

    public void onBtnNextEyesClick () {
		m_source.clip = BtnSound;
		m_source.Play();
		iEyes++;
		if (iEyes > 5) {
			iEyes = 0;
		}
		EyesRenderer.sprite = ListEyes[iEyes];
	}

	public void onBtnPrevEyesClick () {
		m_source.clip = BtnSound;
		m_source.Play();
		iEyes--;
		if (iEyes < 0) {
			iEyes = 5;
		}
		EyesRenderer.sprite = ListEyes[iEyes];
	}

    public void onBtnNextMustacheClick () {
		m_source.clip = BtnSound;
		m_source.Play();
		iMustache++;
		if (iMustache > 13) {
			iMustache = 0;
		}
		MustacheRenderer.sprite = ListMustache[iMustache];
	}

	public void onBtnPrevMustacheClick () {
		m_source.clip = BtnSound;
		m_source.Play();
		iMustache--;
		if (iMustache < 0) {
			iMustache = 13;
		}
		MustacheRenderer.sprite = ListMustache[iMustache];
	}

    public void onBtnNextSkinClick () {
		m_source.clip = BtnSound;
		m_source.Play();
		iHand++;
		iNeck++;
		iFace++;
		if (iHand > 4 && iNeck > 4 && iFace > 4) {
			iHand = 0;
			iNeck = 0;
			iFace = 0;
		}
		HandRenderer.sprite = ListHand[iHand];
		NeckRenderer.sprite = ListNeck[iNeck];
		FaceRenderer.sprite = ListFace[iFace];
	}

	public void onBtnPrevSkinClick () {
		m_source.clip = BtnSound;
		m_source.Play();
		iHand--;
		iNeck--;
		iFace--;
		if (iHand < 0 && iNeck < 0 && iFace < 0) {
			iHand = 4;
			iNeck = 4;
			iFace = 4;
		}
		HandRenderer.sprite = ListHand[iHand];
		NeckRenderer.sprite = ListNeck[iNeck];
		FaceRenderer.sprite = ListFace[iFace];
	}

    public void onBtnNextShirtClick () {
		m_source.clip = BtnSound;
		m_source.Play();
		iShirt++;
		if (iShirt > 9) {
			iShirt = 0;
		}
		ShirtRenderer.sprite = ListShirt[iShirt];
	}

	public void onBtnPrevShirtClick () {
		m_source.clip = BtnSound;
		m_source.Play();
		iShirt--;
		if (iShirt < 0) {
			iShirt = 9;
		}
		ShirtRenderer.sprite = ListShirt[iShirt];
	}

    public void onBtnNextOverallsClick () {
		m_source.clip = BtnSound;
		m_source.Play();
		iOveralls++;
		if (iOveralls > 9) {
			iOveralls = 0;
		}
		OverallsRenderer.sprite = ListOveralls[iOveralls];
	}

	public void onBtnPrevOverallsClick () {
		m_source.clip = BtnSound;
		m_source.Play();
		iOveralls--;
		if (iOveralls < 0) {
			iOveralls = 9;
		}
		OverallsRenderer.sprite = ListOveralls[iOveralls];
	}

    public void onBtnNextSleevesClick () {
		m_source.clip = BtnSound;
		m_source.Play();
		iSleeves++;
		if (iSleeves > 9) {
			iSleeves = 0;
		}
		SleevesRenderer.sprite = ListSleeves[iSleeves];
	}

	public void onBtnPrevSleevesClick () {
		m_source.clip = BtnSound;
		m_source.Play();
		iSleeves--;
		if (iSleeves < 0) {
			iSleeves = 9;
		}
		SleevesRenderer.sprite = ListSleeves[iSleeves];
	}

    public void onBtnNextBootsClick () {
		m_source.clip = BtnSound;
		m_source.Play();
		iBoots++;
		if (iBoots > 1) {
			iBoots = 0;
		}
		BootsRenderer.sprite = ListBoots[iBoots];
	}

	public void onBtnPrevBootsClick () {
		m_source.clip = BtnSound;
		m_source.Play();
		iBoots--;
		if (iBoots < 0) {
			iBoots = 1;
		}
		BootsRenderer.sprite = ListBoots[iBoots];
	}

	public void onBtnContinueClick () {
		PlayerPrefs.SetInt("Gender", iGender);
		PlayerPrefs.SetInt("Hat 1", iHat1);
		PlayerPrefs.SetInt("Hat 2", iHat2);
		PlayerPrefs.SetInt("Back Hair", iBackHair);
		PlayerPrefs.SetInt("Front Hair", iFrontHair);
		PlayerPrefs.SetInt("Eyebrows", iEyebrows);
		PlayerPrefs.SetInt("Eyes", iEyes);
		PlayerPrefs.SetInt("Mustache", iMustache);
		PlayerPrefs.SetInt("Hand", iHand);
		PlayerPrefs.SetInt("Neck", iNeck);
		PlayerPrefs.SetInt("Face", iFace);
		PlayerPrefs.SetInt("Shirt", iShirt);
		PlayerPrefs.SetInt("Overalls", iOveralls);
		PlayerPrefs.SetInt("Sleeves", iSleeves);
		PlayerPrefs.SetInt("Boots", iBoots);
		Debug.Log ("Player settings saved");
		m_source.clip = BtnSound;
		m_source.Play();
		Invoke("ChangeScenePlay", 1f);
	}

	public void OnBtnBackClick() {
		m_source.clip = BtnSound;
		m_source.Play();
		panelPlayerCustomization.SetActive(false);
		panelMenu.SetActive(true);

		//Do not show player on this screen
		imgFace.SetActive(false);
		imgOveralls.SetActive(false);
		imgHand.SetActive(false);
		imgNeck.SetActive(false);
		imgShirt.SetActive(false);
		imgFrontHair.SetActive(false);
		imgBackHair.SetActive(false);
		imgEyebrows.SetActive(false);
		imgEyes.SetActive(false);
		imgHat1.SetActive(false);
		imgHat2.SetActive(false);
		imgSleeves.SetActive(false);
		imgMustache.SetActive(false);
		imgBoots.SetActive(false);
		imgMouth1.SetActive(false);
	}

	void ChangeScenePlay()
	{
		SceneManager.LoadScene(1);
	}
}
