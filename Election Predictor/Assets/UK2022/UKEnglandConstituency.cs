using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UKEnglandConstituency : MonoBehaviour {

	public enum startingParty {
		Conservative, Labour, LibDem, UKIP, Green
	}

	public startingParty StartingParty;

	public enum englandRegion {
		EastEngland, EastMidlands, London, NorthEastEngland, NorthWestEngland, SouthEastEngland, SouthWestEngland, WestMidlands, YorkshireHumber
	}

	public englandRegion EnglandRegion;

	public string ConstituencyName;

	[Header("Turnout")]

	public int TurnoutNumber;
	public float TurnoutPercentage;

	[Header("Party Variables")]

	public float PrevConservativeShareOfVote;
	public float PrevLabourShareOfVote;
	public float PrevLibDemShareOfVote;
	public float PrevUKIPShareOfVote;
	public float PrevGreenShareOfVote;
	public float PrevYorkshirePartyShareOfVote;
	public float PrevIndependentShareOfVote;
	public float PrevIndependent2ShareOfVote;
	public float PrevOthersShareOfVote;

	float NewConservativeShareOfVote;
	float NewLabourShareOfVote;
	float NewLibDemShareOfVote;
	float NewUKIPShareOfVote;
	float NewGreenShareOfVote;
		
	SpriteRenderer renderer;

	void Start() {
		renderer = GetComponent<SpriteRenderer> ();

		if (StartingParty == startingParty.Conservative) {
			renderer.color = new Color32(52, 37, 240, 255);
		}
		if (StartingParty == startingParty.Labour) {
			renderer.color = new Color32(223, 38, 38, 255);
		}
		if (StartingParty == startingParty.LibDem) {
			renderer.color = new Color32(248, 160, 29, 255);
		}
		if (StartingParty == startingParty.UKIP) {
			renderer.color = new Color32(120, 36, 182, 255);
		}
		if (StartingParty == startingParty.Green) {
			renderer.color = new Color32(88, 194, 74, 255);
		}

	}

	public void UpdateConservativeEnglandFigures (float ConservativeSwing)
	{
		NewConservativeShareOfVote = PrevConservativeShareOfVote + ConservativeSwing;
		if (NewConservativeShareOfVote < 0) {
			NewConservativeShareOfVote = 0;
		}

		//Debug.Log ("Con: " + NewConservativeShareOfVote);
	}

	public void UpdateLabourEnglandFigures (float LabourSwing)
	{
		NewLabourShareOfVote = PrevLabourShareOfVote + LabourSwing;
		if (NewLabourShareOfVote < 0) {
			NewLabourShareOfVote = 0;
		}

		//Debug.Log ("Lab: " + NewLabourShareOfVote);
	}

	public void UpdateLibDemEnglandFigures (float LibDemSwing)
	{
		if (PrevLibDemShareOfVote != 0) {
			NewLibDemShareOfVote = PrevLibDemShareOfVote + LibDemSwing;
		}
		if (NewLibDemShareOfVote < 0) {
			NewLibDemShareOfVote = 0;
		}
			
		//Debug.Log ("Lib Dems: " + NewLibDemShareOfVote);
	}

	public void UpdateUKIPEnglandFigures (float UKIPSwing)
	{
		if (PrevUKIPShareOfVote != 0) {
			NewUKIPShareOfVote = PrevUKIPShareOfVote + UKIPSwing;
		}
		if (NewUKIPShareOfVote < 0) {
			NewUKIPShareOfVote = 0;
		}
			
		//Debug.Log ("UKIP: " + NewUKIPShareOfVote);
	}

	public void UpdateGreenEnglandFigures (float GreenSwing)
	{
		if (PrevGreenShareOfVote != 0) {
			NewGreenShareOfVote = PrevGreenShareOfVote + GreenSwing;
		}
		if (NewGreenShareOfVote < 0 ) {
			NewGreenShareOfVote = 0;
		}

		//Debug.Log ("Green: " + NewGreenShareOfVote);
	}

	public void UpdateColors () {
		if (NewConservativeShareOfVote > NewLabourShareOfVote && NewConservativeShareOfVote > NewLibDemShareOfVote && NewConservativeShareOfVote > NewUKIPShareOfVote && NewConservativeShareOfVote > NewGreenShareOfVote) {
			renderer.color = new Color32(52, 37, 240, 255);
		} else if(NewLabourShareOfVote > NewLibDemShareOfVote && NewLabourShareOfVote > NewConservativeShareOfVote && NewLabourShareOfVote > NewUKIPShareOfVote && NewLabourShareOfVote > NewGreenShareOfVote) {
			renderer.color = new Color32(223, 38, 38, 255);
		} else if(NewLibDemShareOfVote > NewUKIPShareOfVote && NewLibDemShareOfVote > NewConservativeShareOfVote && NewLibDemShareOfVote > NewLabourShareOfVote && NewLibDemShareOfVote > NewGreenShareOfVote) {
			renderer.color = new Color32(248, 160, 29, 255);
		} else if (NewUKIPShareOfVote > NewGreenShareOfVote && NewUKIPShareOfVote > NewConservativeShareOfVote && NewUKIPShareOfVote > NewLabourShareOfVote && NewUKIPShareOfVote > NewLibDemShareOfVote) {
			renderer.color = new Color32(120, 36, 182, 255);
		} else{
			renderer.color = new Color32(88, 194, 74, 255);
		}
	}
}
