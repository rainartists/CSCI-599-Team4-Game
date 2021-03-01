﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalCollision : MonoBehaviour
{
    private Crystal crystalStatus;
    private IsometricCharacterRenderer attackStatus;

    private short currAttackID;

    void Start()
    {
        crystalStatus = gameObject.GetComponentInParent<Crystal>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);

        if (collision.gameObject.name == "PlayerCollider")
        {
            attackStatus = collision.GetComponentInParent<HeroStatus>().gameObject.GetComponentInChildren<IsometricCharacterRenderer>();
        }
    }

    private void FixedUpdate()
    {
        if (attackStatus != null && attackStatus.isPlayingAttack() && currAttackID != attackStatus.getAttackID())
        {
            crystalStatus.CmdTakeDamage(2);
            currAttackID = attackStatus.getAttackID();
        }
    }

}