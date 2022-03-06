using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Windows.Speech;


public class SpeechRecognizer : MonoBehaviour {

    KeywordRecognizer KeywordRecognizerObj;
    public string[] Keywords_array;

    private Animator anim;
    public AudioSource[] ObjectSound;

	// Use this for initialization
	void Start () {

        KeywordRecognizerObj = new KeywordRecognizer(Keywords_array);
        KeywordRecognizerObj.OnPhraseRecognized += OnKeywordsRecognized;
        KeywordRecognizerObj.Start();

        anim = GetComponent<Animator>();
        ObjectSound = GetComponent<AudioSource[]>();
		
	}

    void OnKeywordsRecognized(PhraseRecognizedEventArgs args)
    {
        Debug.Log("keyword: " + args.text + " ; Confidence " + args.confidence);
        ActionPerformer(args.text);
    }

    void ActionPerformer(string command)
    {
        if (command.Contains("jump"))
        {
            anim.Play("jump", -1, 0f);
            ObjectSound[0].Play(0);
        }
        if (command.Contains("rage"))
        {
            anim.Play("rage", -1, 0f);
            ObjectSound[1].Play(0);
        }
        if (command.Contains("hit"))
        {

        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
