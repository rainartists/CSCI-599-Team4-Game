﻿// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class CrystalCollision : MonoBehaviour
// {
//     private Crystal crystalStatus;
//     private HeroStatus attacker;
//     private IsometricCharacterRenderer attackStatus;

//     private short currAttackID;

//     void Start()
//     {
//         crystalStatus = gameObject.GetComponentInParent<Crystal>();
//     }


//     private void OnTriggerEnter2D(Collider2D collision)
//     {
//         //Debug.Log(collision.gameObject.name);

//         if (!crystalStatus.isAlly && collision.gameObject.name == "PlayerCollider")
//         {
//             attackStatus = collision.GetComponentInParent<HeroStatus>().transform.gameObject.GetComponentInChildren<IsometricCharacterRenderer>();
//             attacker = collision.GetComponentInParent<HeroStatus>();
//         }
//     }

//     private void OnTriggerExit2D(Collider2D collision)
//     {
//         attackStatus = null;
//         attacker = null;
//     }


//     private void FixedUpdate()
//     {
//         if (attackStatus != null && attackStatus.isPlayingAttack() && currAttackID != attackStatus.getAttackID())
//         {
//             crystalStatus.TakeDamage(attacker.BasicAttackPoints);
//             currAttackID = attackStatus.getAttackID();
//         }
//     }

// }