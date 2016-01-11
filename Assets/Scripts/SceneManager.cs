using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class SceneManager : MonoBehaviour {

	public Image background;
	public Button eLeft;
	public Button eCenter;
	public Button eRight;

	public List<Playground> playgrounds = new List<Playground>();

	private static SceneManager instance;
	public static SceneManager Instance {
		get {
			if(instance == null) {
				instance = GameObject.FindObjectOfType<SceneManager>();
			}
			return instance;
		}
	}

	public void Start(){
		Playground[] plays = GameObject.FindObjectsOfType<Playground>();
		foreach(Playground play in plays){
			playgrounds.Add(play);
		}

		background.sprite = playgrounds[0].background;
		eLeft.image.sprite = playgrounds[0].enemies[0].icon;
		eCenter.image.sprite = playgrounds[0].enemies[1].icon;
		eRight.image.sprite = playgrounds[0].enemies[2].icon;
	}
}
