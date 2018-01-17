﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public static class CombatCharacterFactory {
	public enum CombatCharacterPresets{// always store an element from this list instead of a CombatCharacter if a variable needs to be serialized
		PlayerCharBasic,
		PlayerCharTwo,
		BobbyBard,
		CharlieCleric,
		MabelMage,
		SusanShapeShifter,
		WalterWizard,
		PamelaPaladin
	}

	public static CombatCharacter MakeCharacter(CombatCharacterPresets characterType){
		CombatCharacter newCharacter = null;
		int characterMaxHealth = GetCharacterMaxhealth (characterType);
		int characterMaxEnergy = GetCharacterMaxEnergy (characterType);
		switch (characterType){
		case CombatCharacterPresets.PlayerCharBasic:
			newCharacter = new CombatCharacter (characterMaxHealth, characterMaxHealth, characterMaxEnergy, characterMaxEnergy, new SimpleAttack (20, 30, "melee", 0));
			break;
		
		case CombatCharacterPresets.PlayerCharTwo:
			newCharacter = new CombatCharacter (characterMaxHealth, characterMaxHealth, characterMaxEnergy, characterMaxEnergy, new SimpleAttack (30, 40, "melee", 0));
			break;
		case CombatCharacterPresets.BobbyBard:
			newCharacter = new CombatCharacter (characterMaxHealth, characterMaxHealth / 2, characterMaxEnergy, characterMaxEnergy, new SimpleAttack (20, 30, "melee", 0));
			break;
		default:
			newCharacter = new CombatCharacter(characterMaxHealth, characterMaxHealth, characterMaxEnergy, characterMaxEnergy, new SimpleAttack (20, 30, "melee", 0));
			break;
		}
		List<CombatAbility> abilities = GetCharacterAbilities (characterType);
		foreach (CombatAbility ability in abilities) {
			newCharacter.AddAbility (ability);
		}
		return newCharacter;
	}

	public static string GetCharacterName(CombatCharacterPresets characterType){
		switch (characterType) {
		case CombatCharacterPresets.PlayerCharBasic:
			return "Test Character One";
		case CombatCharacterPresets.PlayerCharTwo:
			return "Test Character Two";
		case CombatCharacterPresets.BobbyBard:
			return "Bobby The Bard";
		case CombatCharacterPresets.CharlieCleric:
			return "Charlie The Cleric";
		case CombatCharacterPresets.MabelMage:
			return "Mabel The Mage";
		case CombatCharacterPresets.PamelaPaladin:
			return "Pamela The Paladin";
		case CombatCharacterPresets.WalterWizard:
			return "Walter The Wizard";
		case CombatCharacterPresets.SusanShapeShifter:
			return "Susan The ShapeShifter";
		}
		return "Character name not defined";
	}

	public static int GetCharacterMaxhealth(CombatCharacterPresets characterType){
		switch (characterType) {
		case CombatCharacterPresets.PlayerCharBasic:
			return 100;
		case CombatCharacterPresets.PlayerCharTwo:
			return 120;
		case CombatCharacterPresets.BobbyBard:
			return 70;
		case CombatCharacterPresets.CharlieCleric:
			return 100;
		case CombatCharacterPresets.MabelMage:
			return 130;
		case CombatCharacterPresets.PamelaPaladin:
			return 180;
		case CombatCharacterPresets.WalterWizard:
			return 100;
		case CombatCharacterPresets.SusanShapeShifter:
			return 100;
		}
		return 1;
	}

	public static int GetCharacterMaxEnergy(CombatCharacterPresets characterType){
		switch (characterType) {
		case CombatCharacterPresets.PlayerCharBasic:
			return 100;
		case CombatCharacterPresets.PlayerCharTwo:
			return 120;
		case CombatCharacterPresets.BobbyBard:
			return 200;
		case CombatCharacterPresets.CharlieCleric:
			return 150;
		case CombatCharacterPresets.MabelMage:
			return 130;
		case CombatCharacterPresets.PamelaPaladin:
			return 60;
		case CombatCharacterPresets.WalterWizard:
			return 150;
		case CombatCharacterPresets.SusanShapeShifter:
			return 120;
		}
		return 1;
	}

	public static List<CombatAbility> GetCharacterAbilities (CombatCharacterPresets characterType){
		List<CombatAbility> abilities = new List<CombatAbility> ();
		switch (characterType) {
		case CombatCharacterPresets.PlayerCharBasic:
			abilities.Add (new SimpleAttack (50, 60, "melee", 30, "Slash"));
			break;
		case CombatCharacterPresets.PlayerCharTwo:
			abilities.Add (new SimpleAttack (60, 70, "melee", 30, "Big slash"));
			abilities.Add (new SimpleAttack (80, 90, "melee", 40, "Really big slash"));
			break;
		case CombatCharacterPresets.BobbyBard:
			//TODO add healing and damage resist abilities
			break;
		case CombatCharacterPresets.CharlieCleric:
			//TODO add high power healing abilities
			break;
		case CombatCharacterPresets.MabelMage:
			//TODO add melee and magic abilities
			break;
		case CombatCharacterPresets.PamelaPaladin:
			//TODO add melee abilities
			break;
		case CombatCharacterPresets.WalterWizard:
			//TODO add magic abilities
			break;
		case CombatCharacterPresets.SusanShapeShifter:
			//TODO add shapshifting abilities
			break;
		}
		return abilities;
	}

	//TODO add GetCharacterBasicAttack
}
