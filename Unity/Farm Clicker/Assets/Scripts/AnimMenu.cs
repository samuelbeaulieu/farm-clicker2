using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AnimMenu : MonoBehaviour {

	//Buttons & UI
	public GameObject Logo;
	public GameObject inputName;
	public GameObject btnPlay;
	public GameObject btnContinue;
	public GameObject btnMenu;
	public GameObject imgIcon;
	public GameObject imgIconX;
	public GameObject imgMenu;
	public GameObject btnLanguage;
	public GameObject btnFrancais;
	public GameObject btnEnglish;
	public GameObject btnRestart;
	public GameObject btnCancel;
	public GameObject btnConfirm;
	public GameObject btnExit;
	public GameObject txtMenu;
	public GameObject txtCopy;
	public GameObject panelPlayerCustomization;
	public GameObject panelMenu;
	public InputField mainInputField;

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
	public GameObject imgMouth;

	public AudioClip btnSound;
	public bool menuActive = false;
	public bool menuLanguageActive = false;
	public bool menuRestartActive = false;

	public Text playerNameInput;
	private string playerName;

	AudioSource m_source;

	//On start do this
	void Start () {
		m_source = gameObject.GetComponent<AudioSource>();

		//Do not show player on this screen
        panelPlayerCustomization.SetActive(false);
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
        imgMouth.SetActive(false);

		if (PlayerPrefs.HasKey ("Name")) {
			btnPlay.SetActive(false);
			btnContinue.SetActive(true);
			inputName.SetActive(false);
		} else {
			btnPlay.SetActive(true);
			btnContinue.SetActive(false);
			inputName.SetActive(true);
		}
	}

	void Update () {
		if (mainInputField.text == "") {
			btnPlay.GetComponent<Button>().interactable = false;
		} else if (mainInputField.text != "") {
			playerName = mainInputField.text;
			btnPlay.GetComponent<Button>().interactable = true;
			PlayerPrefs.SetString ("Name", playerName);
			PlayerPrefs.Save ();
		}
	}

	//When you click the hamburger menu button
	public void OnBtnMenuClick()
	{
		if (menuActive == false) {		//When side menu is disabled
			m_source.clip = btnSound;
			m_source.Play();
			imgIcon.SetActive(false);
			imgIconX.SetActive(true);
			LeanTween.moveLocalX(btnMenu, -474.7f, 0.5f);
			LeanTween.moveLocalX(imgMenu, -741.51f, 0.5f);
			LeanTween.moveLocalX(txtMenu, -741.51f, 0.5f);
			LeanTween.moveLocalX(btnLanguage, -734.51f, 0.5f);
			LeanTween.moveLocalX(btnFrancais, -734.51f, 0.5f);
			LeanTween.moveLocalX(btnEnglish, -734.51f, 0.5f);
			LeanTween.moveLocalX(btnRestart, -734.51f, 0.5f);
			LeanTween.moveLocalX(btnCancel, -734.51f, 0.5f);
			LeanTween.moveLocalX(btnConfirm, -734.51f, 0.5f);
			LeanTween.moveLocalX(btnExit, -734.51f, 0.5f);
			LeanTween.moveLocalX(txtCopy, -741.51f, 0.5f);
			menuActive = true;
		} else if (menuActive == true) {		//When side menu is enabled
			m_source.clip = btnSound;
			m_source.Play();
			imgIcon.SetActive(true);
			imgIconX.SetActive(false);
			if (menuLanguageActive == true || menuRestartActive == true) {
				LeanTween.moveLocalY(btnFrancais, 275f, 0.25f);
				LeanTween.moveLocalY(btnEnglish, 275f, 0.25f);
				LeanTween.moveLocalY(btnRestart, 150f, 0.25f);
				LeanTween.moveLocalY(btnCancel, 150f, 0.25f);
				LeanTween.moveLocalY(btnConfirm, 150f, 0.25f);
				LeanTween.moveLocalY(btnExit, 25f, 0.25f);
			}
			LeanTween.moveLocalX(btnMenu, -912.3f, 0.5f);
			LeanTween.moveLocalX(imgMenu, -1178.5f, 0.5f);
			LeanTween.moveLocalX(txtMenu, -1178.5f, 0.5f);
			LeanTween.moveLocalX(btnLanguage, -1172f, 0.5f);
			LeanTween.moveLocalX(btnFrancais, -1172f, 0.5f);
			LeanTween.moveLocalX(btnEnglish, -1172f, 0.5f);
			LeanTween.moveLocalX(btnCancel, -1172f, 0.5f);
			LeanTween.moveLocalX(btnConfirm, -1172f, 0.5f);
			LeanTween.moveLocalX(btnRestart, -1172f, 0.5f);
			LeanTween.moveLocalX(btnExit, -1172f, 0.5f);
			LeanTween.moveLocalX(txtCopy, -1178.5f, 0.5f);
			menuActive = false;
			menuLanguageActive = false;
			menuRestartActive = false;
		}
	}

	//When you click the Language button
	public void OnBtnLanguageClick()
	{
		if (menuLanguageActive == false) {		//When Language menu is enabled
			m_source.clip = btnSound;
			m_source.Play();
			if (menuRestartActive == true) {		//When Language menu is disabled
				m_source.clip = btnSound;
				m_source.Play();
				LeanTween.moveLocalY(btnCancel, 150f, 0.25f);
				LeanTween.moveLocalY(btnConfirm, 150f, 0.25f);
				LeanTween.moveLocalY(btnExit, 25f, 0.25f);
				menuRestartActive = false;
			}
			LeanTween.moveLocalY(btnFrancais, 125f, 0.25f);
			LeanTween.moveLocalY(btnEnglish, 175f, 0.25f);
			LeanTween.moveLocalY(btnRestart, 25f, 0.25f);
			LeanTween.moveLocalY(btnCancel, 25f, 0.25f);
			LeanTween.moveLocalY(btnConfirm, 25f, 0.25f);
			LeanTween.moveLocalY(btnExit, -100f, 0.25f);
			menuLanguageActive = true;
		} else if (menuLanguageActive == true) {		//When Language menu is disabled
			m_source.clip = btnSound;
			m_source.Play();
			LeanTween.moveLocalY(btnFrancais, 275f, 0.25f);
			LeanTween.moveLocalY(btnEnglish, 275f, 0.25f);
			LeanTween.moveLocalY(btnRestart, 150f, 0.25f);
			LeanTween.moveLocalY(btnCancel, 150f, 0.25f);
			LeanTween.moveLocalY(btnConfirm, 150f, 0.25f);
			LeanTween.moveLocalY(btnExit, 25f, 0.25f);
			menuLanguageActive = false;
		}
	}

	public void OnBtnRestartClick () {
		if (menuRestartActive == false) {		//When Language menu is enabled
			m_source.clip = btnSound;
			m_source.Play();
			if (menuLanguageActive == true) {		//When Language menu is disabled
				m_source.clip = btnSound;
				m_source.Play();
				LeanTween.moveLocalY(btnFrancais, 275f, 0.25f);
				LeanTween.moveLocalY(btnEnglish, 275f, 0.25f);
				LeanTween.moveLocalY(btnRestart, 150f, 0.25f);
				LeanTween.moveLocalY(btnCancel, 150f, 0.25f);
				LeanTween.moveLocalY(btnConfirm, 150f, 0.25f);
				LeanTween.moveLocalY(btnExit, 25f, 0.25f);
				menuLanguageActive = false;
			}
			LeanTween.moveLocalY(btnCancel, 0f, 0.25f);
			LeanTween.moveLocalY(btnConfirm, 50f, 0.25f);
			LeanTween.moveLocalY(btnExit, -100f, 0.25f);
			menuRestartActive = true;
		} else if (menuRestartActive == true) {		//When Language menu is disabled
			m_source.clip = btnSound;
			m_source.Play();
			LeanTween.moveLocalY(btnCancel, 150f, 0.25f);
			LeanTween.moveLocalY(btnConfirm, 150f, 0.25f);
			LeanTween.moveLocalY(btnExit, 25f, 0.25f);
			menuRestartActive = false;
		}
	}

	public void OnBtnConfirmClick () {
		m_source.clip = btnSound;
		m_source.Play();
		PlayerPrefs.DeleteAll();
		Debug.Log ("Player reset completed");
		imgIcon.SetActive(true);
		imgIconX.SetActive(false);
		if (menuLanguageActive == true || menuRestartActive == true) {
			LeanTween.moveLocalY(btnFrancais, 275f, 0.25f);
			LeanTween.moveLocalY(btnEnglish, 275f, 0.25f);
			LeanTween.moveLocalY(btnRestart, 150f, 0.25f);
			LeanTween.moveLocalY(btnCancel, 150f, 0.25f);
			LeanTween.moveLocalY(btnConfirm, 150f, 0.25f);
			LeanTween.moveLocalY(btnExit, 25f, 0.25f);
		}
		LeanTween.moveLocalX(btnMenu, -912.3f, 0.5f);
		LeanTween.moveLocalX(imgMenu, -1178.5f, 0.5f);
		LeanTween.moveLocalX(txtMenu, -1178.5f, 0.5f);
		LeanTween.moveLocalX(btnLanguage, -1172f, 0.5f);
		LeanTween.moveLocalX(btnFrancais, -1172f, 0.5f);
		LeanTween.moveLocalX(btnEnglish, -1172f, 0.5f);
		LeanTween.moveLocalX(btnCancel, -1172f, 0.5f);
		LeanTween.moveLocalX(btnConfirm, -1172f, 0.5f);
		LeanTween.moveLocalX(btnRestart, -1172f, 0.5f);
		LeanTween.moveLocalX(btnExit, -1172f, 0.5f);
		LeanTween.moveLocalX(txtCopy, -1178.5f, 0.5f);
		menuActive = false;
		menuLanguageActive = false;
		menuRestartActive = false;
		btnPlay.SetActive(true);
		btnContinue.SetActive(false);
		inputName.SetActive(true);
	}

	public void OnBtnCancelClick () {
		m_source.clip = btnSound;
		m_source.Play();
		LeanTween.moveLocalY(btnCancel, 150f, 0.25f);
		LeanTween.moveLocalY(btnConfirm, 150f, 0.25f);
		LeanTween.moveLocalY(btnExit, 25f, 0.25f);
		menuRestartActive = false;
	}

	//When you click the input field
    public void OnInputFieldClick() {
		m_source.clip = btnSound;
		m_source.Play();
	}

	//When you click the exit button
	public void OnBtnExitClick() {
		m_source.clip = btnSound;
		m_source.Play();
		Invoke("ExitApp", 1f);
	}
    
	//When you click the Play button
	public void OnBtnPlayClick() {
		m_source.clip = btnSound;
		m_source.Play();

		//Show Player on next panel
		panelPlayerCustomization.SetActive(true);
        imgFace.SetActive(true);
        imgOveralls.SetActive(true);
        imgHand.SetActive(true);
        imgNeck.SetActive(true);
        imgShirt.SetActive(true);
        imgFrontHair.SetActive(true);
        imgBackHair.SetActive(true);
        imgEyebrows.SetActive(true);
        imgEyes.SetActive(true);
        imgHat1.SetActive(true);
        imgHat2.SetActive(true);
        imgSleeves.SetActive(true);
        imgMustache.SetActive(true);
        imgBoots.SetActive(true);
        imgMouth.SetActive(true);

		//Close side panel on Menu Panel
		panelMenu.SetActive(false);
		imgIcon.SetActive(true);
		imgIconX.SetActive(false);
		LeanTween.moveLocalX(btnMenu, -912.3f, 0.5f);
		LeanTween.moveLocalX(imgMenu, -1178.5f, 0.5f);
		LeanTween.moveLocalX(txtMenu, -1178.5f, 0.5f);
		LeanTween.moveLocalX(btnLanguage, -1172f, 0.5f);
		LeanTween.moveLocalX(btnFrancais, -1172f, 0.5f);
		LeanTween.moveLocalX(btnEnglish, -1172f, 0.5f);
		LeanTween.moveLocalX(btnRestart, -1172f, 0.5f);
		LeanTween.moveLocalX(btnExit, -1172f, 0.5f);
		LeanTween.moveLocalX(txtCopy, -1178.5f, 0.5f);
		LeanTween.moveLocalY(btnFrancais, 275f, 0.25f);
		LeanTween.moveLocalY(btnEnglish, 275f, 0.25f);
		LeanTween.moveLocalY(btnRestart, 150f, 0.25f);
		LeanTween.moveLocalY(btnExit, 25f, 0.25f);
		menuLanguageActive = false;
		menuActive = false;
		PlayerPrefs.Save();
	}

	//When you click the Play button
	public void OnBtnContinueClick() {
		m_source.clip = btnSound;
		m_source.Play();

		//Close side panel on Menu Panel
		panelMenu.SetActive(false);
		imgIcon.SetActive(true);
		imgIconX.SetActive(false);
		LeanTween.moveLocalX(btnMenu, -912.3f, 0.5f);
		LeanTween.moveLocalX(imgMenu, -1178.5f, 0.5f);
		LeanTween.moveLocalX(txtMenu, -1178.5f, 0.5f);
		LeanTween.moveLocalX(btnLanguage, -1172f, 0.5f);
		LeanTween.moveLocalX(btnFrancais, -1172f, 0.5f);
		LeanTween.moveLocalX(btnEnglish, -1172f, 0.5f);
		LeanTween.moveLocalX(btnRestart, -1172f, 0.5f);
		LeanTween.moveLocalX(btnExit, -1172f, 0.5f);
		LeanTween.moveLocalX(txtCopy, -1178.5f, 0.5f);
		LeanTween.moveLocalY(btnFrancais, 275f, 0.25f);
		LeanTween.moveLocalY(btnEnglish, 275f, 0.25f);
		LeanTween.moveLocalY(btnRestart, 150f, 0.25f);
		LeanTween.moveLocalY(btnExit, 25f, 0.25f);
		menuLanguageActive = false;
		menuActive = false;
		PlayerPrefs.Save();

		Invoke("ChangeScenePlay", 1f);
	}

	void ChangeScenePlay()
	{
		SceneManager.LoadScene(1);
	}

	void ExitApp()
	{
		Application.Quit();
	}
}
