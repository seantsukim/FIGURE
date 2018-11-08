using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "enemyInfo", menuName = "enemy")]
public class enemyInfo : ScriptableObject {
	public string enemyName; //name of enemy
	public int health; //how much health
}
