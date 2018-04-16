using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UKSwingCalculator : MonoBehaviour {

	[Header("England")]
	public float EngPrevConservativeShareOfVote;
	public float EngPrevLabourShareOfVote;
	public float EngPrevLibDemShareOfVote;
	public float EngPrevUKIPShareOfVote;
	public float EngPrevGreenShareOfVote;

	float EngNewConservativeShareOfVote;
	float EngNewLabourShareOfVote;
	float EngNewLibDemShareOfVote;
	float EngNewUKIPShareOfVote;
	float EngNewGreenShareOfVote;

	float EngConservativeSwing;
	float EngLabourSwing;
	float EngLibDemSwing;
	float EngUKIPSwing;
	float EngGreenSwing;

	[Header("Scotland")]
	public float ScotPrevConservativeShareOfVote;
	public float ScotPrevLabourShareOfVote;
	public float ScotPrevLibDemShareOfVote;
	public float ScotPrevUKIPShareOfVote;
	public float ScotPrevGreenShareOfVote;
	public float ScotPrevSNPShareOfVote;

	float ScotNewConservativeShareOfVote;
	float ScotNewLabourShareOfVote;
	float ScotNewLibDemShareOfVote;
	float ScotNewUKIPShareOfVote;
	float ScotNewGreenShareOfVote;
	float ScotNewSNPShareOfVote;

	float ScotConservativeSwing;
	float ScotLabourSwing;
	float ScotLibDemSwing;
	float ScotUKIPSwing;
	float ScotGreenSwing;
	float ScotSNPSwing;

	[Header("Wales")]
	public float WalesPrevConservativeShareOfVote;
	public float WalesPrevLabourShareOfVote;
	public float WalesPrevLibDemShareOfVote;
	public float WalesPrevUKIPShareOfVote;
	public float WalesPrevGreenShareOfVote;
	public float WalesPrevPlaidShareOfVote;

	float WalesNewConservativeShareOfVote;
	float WalesNewLabourShareOfVote;
	float WalesNewLibDemShareOfVote;
	float WalesNewUKIPShareOfVote;
	float WalesNewGreenShareOfVote;
	float WalesNewPlaidShareOfVote;

	float WalesConservativeSwing;
	float WalesLabourSwing;
	float WalesLibDemSwing;
	float WalesUKIPSwing;
	float WalesGreenSwing;
	float WalesPlaidSwing;

	[Header("UI Objects")]
	public InputField EngConservativeInput;
	public InputField EngLabourInput;
	public InputField EngLibDemInput;
	public InputField EngUKIPInput;
	public InputField EngGreenInput;


	public void UpdateSwings() {
		EngNewConservativeShareOfVote = int.Parse (EngConservativeInput.text);
		EngNewLabourShareOfVote = int.Parse (EngLabourInput.text);
		EngNewLibDemShareOfVote = int.Parse (EngLibDemInput.text);
		EngNewUKIPShareOfVote = int.Parse (EngUKIPInput.text);
		EngNewGreenShareOfVote = int.Parse (EngGreenInput.text);

		//England
		EngConservativeSwing = EngNewConservativeShareOfVote - EngPrevConservativeShareOfVote;
		EngLabourSwing = EngNewLabourShareOfVote - EngPrevLabourShareOfVote;
		EngLibDemSwing = EngNewLibDemShareOfVote - EngPrevLibDemShareOfVote;
		EngUKIPSwing = EngNewUKIPShareOfVote - EngPrevUKIPShareOfVote;
		EngGreenSwing = EngNewGreenShareOfVote - EngPrevGreenShareOfVote;

		//Scotland
		ScotConservativeSwing = ScotNewConservativeShareOfVote - ScotPrevConservativeShareOfVote;
		ScotLabourSwing = ScotNewLabourShareOfVote - ScotPrevLabourShareOfVote;
		ScotLibDemSwing = ScotNewLibDemShareOfVote - ScotPrevLibDemShareOfVote;
		ScotUKIPSwing = ScotNewUKIPShareOfVote - ScotPrevUKIPShareOfVote;
		ScotGreenSwing = ScotNewGreenShareOfVote - ScotPrevGreenShareOfVote;
		ScotSNPSwing = ScotNewSNPShareOfVote - ScotPrevSNPShareOfVote;

		//Wales
		WalesConservativeSwing = WalesNewConservativeShareOfVote - WalesPrevConservativeShareOfVote;
		WalesLabourSwing = WalesNewLabourShareOfVote - WalesPrevLabourShareOfVote;
		WalesLibDemSwing = WalesNewLibDemShareOfVote - WalesPrevLibDemShareOfVote;
		WalesUKIPSwing = WalesNewUKIPShareOfVote - WalesPrevUKIPShareOfVote;
		WalesGreenSwing = WalesNewGreenShareOfVote - WalesPrevGreenShareOfVote;
		WalesPlaidSwing = WalesNewPlaidShareOfVote - WalesPrevPlaidShareOfVote;

		gameObject.BroadcastMessage ("UpdateConservativeEnglandFigures", EngConservativeSwing);
		gameObject.BroadcastMessage ("UpdateLabourEnglandFigures", EngLabourSwing);
		gameObject.BroadcastMessage ("UpdateLibDemEnglandFigures", EngLibDemSwing);
		gameObject.BroadcastMessage ("UpdateUKIPEnglandFigures", EngUKIPSwing);
		gameObject.BroadcastMessage ("UpdateGreenEnglandFigures", EngGreenSwing);

		gameObject.BroadcastMessage ("UpdateColors");

	}

}
