using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolemController : MonoBehaviour {

	// Use this for initialization

	public Animator anim;

	public AudioSource rageaudio;
	public AudioSource jumpaudio;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		anim = GetComponent<Animator>();
		rageaudio= GameObject.Find("RageSound").GetComponent<AudioSource>();
		jumpaudio= GameObject.Find("JumpSound").GetComponent<AudioSource>();
	}

	public void GolemActions(string ActionCommands)
	{
		ActionCommands = ActionCommands.Trim();
        switch (ActionCommands)
		{
          case "jump":
		   anim.Play("jump",-1,0f);
		   jumpaudio.Play(11000);
		   break;
		  case "anger":
		   anim.Play("rage",-1,0f);
		   rageaudio.Play();
		   break;

		  default:
		   anim.Play("idle",-1,0f);
		   break; 

		}
        

	}
}
