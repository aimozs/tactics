using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour {

	private static UIManager instance;
	public static UIManager Instance {
		get {
			if(instance == null) {
				instance = GameObject.FindObjectOfType<UIManager>();
			}
			return instance;
		}
	}
}
