using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canada2019Riding : MonoBehaviour {

    int RidingPopulation;

    float PrevLiberalShareOfVote;
    float PrevConservativeShareOfVote;
    float PrevNDPShareOfVote;
    float PrevGreenShareOfVote;
    float PrevBlocShareOfVote;

    float NewLiberalShareOfVote;
    float NewConservativeShareOfVote;
    float NewNDPShareOfVote;
    float NewGreenShareOfVote;
    float NewBlocShareOfVote;

    float LiberalSwing;
    float ConservativeSwing;
    float NDPSwing;
    float GreenSwing;
    float BlocSwing;

    void UpdateFigures ()
    {
        NewLiberalShareOfVote = PrevLiberalShareOfVote + LiberalSwing;
        NewConservativeShareOfVote = PrevConservativeShareOfVote + ConservativeSwing;
        NewNDPShareOfVote = PrevNDPShareOfVote + NDPSwing;
        NewGreenShareOfVote = PrevGreenShareOfVote + GreenSwing;
        NewBlocShareOfVote = PrevBlocShareOfVote + BlocSwing;
    }

}
