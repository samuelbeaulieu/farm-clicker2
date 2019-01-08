using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetLocalizedText : MonoBehaviour {

	Text m_textfield;
	//the localization script
	Localization m_localizationScript;
	//the localization key to use (see Localization.cs)
	public string LocalizationKey;
	// Use this for initialization
	void Start () {
		//better if we passed the Localiztion script by reference instead of finding it by name
		m_localizationScript = GameObject.Find("Language").GetComponent<Localization>();
		//we want to add this textfield to the list all localized textfields
		m_localizationScript.RegisterTextField (gameObject);
		//we get the reference to the current gameobject Text component
		m_textfield = gameObject.GetComponent<Text>();
		//We want to make sure there is a localized text shown at first
		UpdateText ();
	}

	//Updates the text used in this textfield taking in account current localization (EN or FR, etc.)
	public void UpdateText()
	{
		//using the localization key, we fetch the good translated string for this textfield
		m_textfield.text = m_localizationScript.GetString(LocalizationKey);
	}
}
