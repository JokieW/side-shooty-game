﻿using UnityEngine;
using System.Collections;

public class PowerUp : MonoBehaviour {

	public GameObject Player;
	public bool Heal;
	public int healAmount;
	public bool increaseSoul;
	public string increaseSoulname;
 	public bool hangTime;
	public bool Power2;
	public bool Power3;

	void Healrun ()
	{
		//healin
		Character PlayerHP = Player.GetComponent<Character> ();
		PlayerHP.CurHP += healAmount;
		if (PlayerHP.CurHP >= PlayerHP.MaxHP) 
		{
			PlayerHP.CurHP = PlayerHP.MaxHP;
				}

		}


	void increaseSoulrun ()
	{
		//raise soul to specified level
		Souls EquippedSoul = Player.GetComponent<Souls> ();
		EquippedSoul.BroadcastMessage(increaseSoulname);
		Destroy(gameObject);
		}
	void hangTimerun ()
	{
        var player = GameObject.FindGameObjectWithTag("Player");
        player.GetComponentInParent<Control>().hangtime = 0.05f;
		//grants power 1
		Destroy(gameObject);
	}
	void Power2run ()
	{
		//grants power 2
		Destroy(gameObject);
	}
	void Power3run ()
	{
		//grants power 3
		Destroy(gameObject);
	}

	void OnCollisionEnter (Collision collision)
	{
		if (collision.gameObject.name == "Player") 
		{
		
			if (Heal)
			{
				Healrun();
			}
			if (increaseSoul)
			{
				increaseSoulrun();
			}
			if (hangTime)
			{
				hangTimerun();
			}
			if (Power2)
			{
				Power2run();
			}
			if (Power3)
			{
				Power3run();
			}
            Destroy(gameObject);
        }
		}


}
