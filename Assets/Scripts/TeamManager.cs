using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class TeamManager : MonoBehaviour {

	public Button teamMember0;
	public Button teamMember1;
	public Button teamMember2;

	public List<TeamMember> teamMembers = new List<TeamMember>();

	private static TeamManager instance;
	public static TeamManager Instance {
		get {
			if(instance == null) {
				instance = GameObject.FindObjectOfType<TeamManager>();
			}
			return instance;
		}
	}

	public void Start(){
		TeamMember[] members= GameObject.FindObjectsOfType<TeamMember>();
		foreach(TeamMember member in members){
			teamMembers.Add(member);
		}

		teamMember0.image.sprite = teamMembers[0].icon;
		teamMember1.image.sprite = teamMembers[1].icon;
		teamMember2.image.sprite = teamMembers[2].icon;
	}
}
