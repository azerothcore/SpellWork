﻿using System;

namespace SpellWork.Spell
{
    // ReSharper disable InconsistentNaming
    public enum LocalesDBC
    {
        enUS,
        koKR,
        frFR,
        deDE,
        zhCN,
        zhTW,
        esES,
        esMX,
        ruRU
    }

    /// <summary>
    ///
    /// </summary>
    public enum SpellFamilyNames
    {
        SPELLFAMILY_GENERIC     = 0,
        SPELLFAMILY_UNK1        = 1, // events, holidays
        // unused               = 2,
        SPELLFAMILY_MAGE        = 3,
        SPELLFAMILY_WARRIOR     = 4,
        SPELLFAMILY_WARLOCK     = 5,
        SPELLFAMILY_PRIEST      = 6,
        SPELLFAMILY_DRUID       = 7,
        SPELLFAMILY_ROGUE       = 8,
        SPELLFAMILY_HUNTER      = 9,
        SPELLFAMILY_PALADIN     = 10,
        SPELLFAMILY_SHAMAN      = 11,
        SPELLFAMILY_UNK2        = 12, // 2 spells (silence resistance)
        SPELLFAMILY_POTION      = 13,
        // unused               = 14,
        SPELLFAMILY_DEATHKNIGHT = 15,
        // unused               = 16,
        SPELLFAMILY_PET         = 17
    }

    /// <summary>
    ///
    /// </summary>
    public enum SpellSpecific
    {
        SPELL_SPECIFIC_NORMAL                   = 0,
        SPELL_SPECIFIC_SEAL                     = 1,
        SPELL_SPECIFIC_AURA                     = 3,
        SPELL_SPECIFIC_STING                    = 4,
        SPELL_SPECIFIC_CURSE                    = 5,
        SPELL_SPECIFIC_ASPECT                   = 6,
        SPELL_SPECIFIC_TRACKER                  = 7,
        SPELL_SPECIFIC_WARLOCK_ARMOR            = 8,
        SPELL_SPECIFIC_MAGE_ARMOR               = 9,
        SPELL_SPECIFIC_ELEMENTAL_SHIELD         = 10,
        SPELL_SPECIFIC_MAGE_POLYMORPH           = 11,
        SPELL_SPECIFIC_JUDGEMENT                = 13,
        SPELL_SPECIFIC_WARLOCK_CORRUPTION       = 17,
        SPELL_SPECIFIC_FOOD                     = 19,
        SPELL_SPECIFIC_DRINK                    = 20,
        SPELL_SPECIFIC_FOOD_AND_DRINK           = 21,
        SPELL_SPECIFIC_PRESENCE                 = 22,
        SPELL_SPECIFIC_CHARM                    = 23,
        SPELL_SPECIFIC_SCROLL                   = 24,
        SPELL_SPECIFIC_MAGE_ARCANE_BRILLANCE    = 25,
        SPELL_SPECIFIC_WARRIOR_ENRAGE           = 26,
        SPELL_SPECIFIC_PRIEST_DIVINE_SPIRIT     = 27,
        SPELL_SPECIFIC_HAND                     = 28,
        SPELL_SPECIFIC_PHASE                    = 29,
    }

    /// <summary>
    ///
    /// </summary>
    public enum SpellEffects
    {
        NO_SPELL_EFFECT                               = 0,
        SPELL_EFFECT_INSTAKILL                        = 1,
        SPELL_EFFECT_SCHOOL_DAMAGE                    = 2,
        SPELL_EFFECT_DUMMY                            = 3,
        SPELL_EFFECT_PORTAL_TELEPORT                  = 4,
        SPELL_EFFECT_TELEPORT_UNITS                   = 5,
        SPELL_EFFECT_APPLY_AURA                       = 6,
        SPELL_EFFECT_ENVIRONMENTAL_DAMAGE             = 7,
        SPELL_EFFECT_POWER_DRAIN                      = 8,
        SPELL_EFFECT_HEALTH_LEECH                     = 9,
        SPELL_EFFECT_HEAL                             = 10,
        SPELL_EFFECT_BIND                             = 11,
        SPELL_EFFECT_PORTAL                           = 12,
        SPELL_EFFECT_RITUAL_BASE                      = 13,
        SPELL_EFFECT_RITUAL_SPECIALIZE                = 14,
        SPELL_EFFECT_RITUAL_ACTIVATE_PORTAL           = 15,
        SPELL_EFFECT_QUEST_COMPLETE                   = 16,
        SPELL_EFFECT_WEAPON_DAMAGE_NOSCHOOL           = 17,
        SPELL_EFFECT_RESURRECT                        = 18,
        SPELL_EFFECT_ADD_EXTRA_ATTACKS                = 19,
        SPELL_EFFECT_DODGE                            = 20,
        SPELL_EFFECT_EVADE                            = 21,
        SPELL_EFFECT_PARRY                            = 22,
        SPELL_EFFECT_BLOCK                            = 23,
        SPELL_EFFECT_CREATE_ITEM                      = 24,
        SPELL_EFFECT_WEAPON                           = 25,
        SPELL_EFFECT_DEFENSE                          = 26,
        SPELL_EFFECT_PERSISTENT_AREA_AURA             = 27,
        SPELL_EFFECT_SUMMON                           = 28,
        SPELL_EFFECT_LEAP                             = 29,
        SPELL_EFFECT_ENERGIZE                         = 30,
        SPELL_EFFECT_WEAPON_PERCENT_DAMAGE            = 31,
        SPELL_EFFECT_TRIGGER_MISSILE                  = 32,
        SPELL_EFFECT_OPEN_LOCK                        = 33,
        SPELL_EFFECT_SUMMON_CHANGE_ITEM               = 34,
        SPELL_EFFECT_APPLY_AREA_AURA_PARTY            = 35,
        SPELL_EFFECT_LEARN_SPELL                      = 36,
        SPELL_EFFECT_SPELL_DEFENSE                    = 37,
        SPELL_EFFECT_DISPEL                           = 38,
        SPELL_EFFECT_LANGUAGE                         = 39,
        SPELL_EFFECT_DUAL_WIELD                       = 40,
        SPELL_EFFECT_JUMP                             = 41,
        SPELL_EFFECT_JUMP_DEST                        = 42,
        SPELL_EFFECT_TELEPORT_UNITS_FACE_CASTER       = 43,
        SPELL_EFFECT_SKILL_STEP                       = 44,
        SPELL_EFFECT_ADD_HONOR                        = 45,
        SPELL_EFFECT_SPAWN                            = 46,
        SPELL_EFFECT_TRADE_SKILL                      = 47,
        SPELL_EFFECT_STEALTH                          = 48,
        SPELL_EFFECT_DETECT                           = 49,
        SPELL_EFFECT_TRANS_DOOR                       = 50,
        SPELL_EFFECT_FORCE_CRITICAL_HIT               = 51,
        SPELL_EFFECT_GUARANTEE_HIT                    = 52,
        SPELL_EFFECT_ENCHANT_ITEM                     = 53,
        SPELL_EFFECT_ENCHANT_ITEM_TEMPORARY           = 54,
        SPELL_EFFECT_TAMECREATURE                     = 55,
        SPELL_EFFECT_SUMMON_PET                       = 56,
        SPELL_EFFECT_LEARN_PET_SPELL                  = 57,
        SPELL_EFFECT_WEAPON_DAMAGE                    = 58,
        SPELL_EFFECT_CREATE_RANDOM_ITEM               = 59,
        SPELL_EFFECT_PROFICIENCY                      = 60,
        SPELL_EFFECT_SEND_EVENT                       = 61,
        SPELL_EFFECT_POWER_BURN                       = 62,
        SPELL_EFFECT_THREAT                           = 63,
        SPELL_EFFECT_TRIGGER_SPELL                    = 64,
        SPELL_EFFECT_APPLY_AREA_AURA_RAID             = 65,
        SPELL_EFFECT_CREATE_MANA_GEM                  = 66,
        SPELL_EFFECT_HEAL_MAX_HEALTH                  = 67,
        SPELL_EFFECT_INTERRUPT_CAST                   = 68,
        SPELL_EFFECT_DISTRACT                         = 69,
        SPELL_EFFECT_PULL                             = 70,
        SPELL_EFFECT_PICKPOCKET                       = 71,
        SPELL_EFFECT_ADD_FARSIGHT                     = 72,
        SPELL_EFFECT_UNTRAIN_TALENTS                  = 73,
        SPELL_EFFECT_APPLY_GLYPH                      = 74,
        SPELL_EFFECT_HEAL_MECHANICAL                  = 75,
        SPELL_EFFECT_SUMMON_OBJECT_WILD               = 76,
        SPELL_EFFECT_SCRIPT_EFFECT                    = 77,
        SPELL_EFFECT_ATTACK                           = 78,
        SPELL_EFFECT_SANCTUARY                        = 79,
        SPELL_EFFECT_ADD_COMBO_POINTS                 = 80,
        SPELL_EFFECT_CREATE_HOUSE                     = 81,
        SPELL_EFFECT_BIND_SIGHT                       = 82,
        SPELL_EFFECT_DUEL                             = 83,
        SPELL_EFFECT_STUCK                            = 84,
        SPELL_EFFECT_SUMMON_PLAYER                    = 85,
        SPELL_EFFECT_ACTIVATE_OBJECT                  = 86,
        SPELL_EFFECT_GAMEOBJECT_DAMAGE                = 87,
        SPELL_EFFECT_GAMEOBJECT_REPAIR                = 88,
        SPELL_EFFECT_GAMEOBJECT_SET_DESTRUCTION_STATE = 89,
        SPELL_EFFECT_KILL_CREDIT                      = 90,
        SPELL_EFFECT_THREAT_ALL                       = 91,
        SPELL_EFFECT_ENCHANT_HELD_ITEM                = 92,
        SPELL_EFFECT_FORCE_DESELECT                   = 93,
        SPELL_EFFECT_SELF_RESURRECT                   = 94,
        SPELL_EFFECT_SKINNING                         = 95,
        SPELL_EFFECT_CHARGE                           = 96,
        SPELL_EFFECT_CAST_BUTTON                      = 97,
        SPELL_EFFECT_KNOCK_BACK                       = 98,
        SPELL_EFFECT_DISENCHANT                       = 99,
        SPELL_EFFECT_INEBRIATE                        = 100,
        SPELL_EFFECT_FEED_PET                         = 101,
        SPELL_EFFECT_DISMISS_PET                      = 102,
        SPELL_EFFECT_REPUTATION                       = 103,
        SPELL_EFFECT_SUMMON_OBJECT_SLOT1              = 104,
        SPELL_EFFECT_SUMMON_OBJECT_SLOT2              = 105,
        SPELL_EFFECT_SUMMON_OBJECT_SLOT3              = 106,
        SPELL_EFFECT_SUMMON_OBJECT_SLOT4              = 107,
        SPELL_EFFECT_DISPEL_MECHANIC                  = 108,
        SPELL_EFFECT_RESURRECT_PET                    = 109,
        SPELL_EFFECT_DESTROY_ALL_TOTEMS               = 110,
        SPELL_EFFECT_DURABILITY_DAMAGE                = 111,
        SPELL_EFFECT_112                              = 112,
        SPELL_EFFECT_RESURRECT_NEW                    = 113,
        SPELL_EFFECT_ATTACK_ME                        = 114,
        SPELL_EFFECT_DURABILITY_DAMAGE_PCT            = 115,
        SPELL_EFFECT_SKIN_PLAYER_CORPSE               = 116,
        SPELL_EFFECT_SPIRIT_HEAL                      = 117,
        SPELL_EFFECT_SKILL                            = 118,
        SPELL_EFFECT_APPLY_AREA_AURA_PET              = 119,
        SPELL_EFFECT_TELEPORT_GRAVEYARD               = 120,
        SPELL_EFFECT_NORMALIZED_WEAPON_DMG            = 121,
        SPELL_EFFECT_122                              = 122,
        SPELL_EFFECT_SEND_TAXI                        = 123,
        SPELL_EFFECT_PULL_TOWARDS                     = 124,
        SPELL_EFFECT_MODIFY_THREAT_PERCENT            = 125,
        SPELL_EFFECT_STEAL_BENEFICIAL_BUFF            = 126,
        SPELL_EFFECT_PROSPECTING                      = 127,
        SPELL_EFFECT_APPLY_AREA_AURA_FRIEND           = 128,
        SPELL_EFFECT_APPLY_AREA_AURA_ENEMY            = 129,
        SPELL_EFFECT_REDIRECT_THREAT                  = 130,
        SPELL_EFFECT_PLAY_SOUND                       = 131,
        SPELL_EFFECT_PLAY_MUSIC                       = 132,
        SPELL_EFFECT_UNLEARN_SPECIALIZATION           = 133,
        SPELL_EFFECT_KILL_CREDIT2                     = 134,
        SPELL_EFFECT_CALL_PET                         = 135,
        SPELL_EFFECT_HEAL_PCT                         = 136,
        SPELL_EFFECT_ENERGIZE_PCT                     = 137,
        SPELL_EFFECT_LEAP_BACK                        = 138,
        SPELL_EFFECT_CLEAR_QUEST                      = 139,
        SPELL_EFFECT_FORCE_CAST                       = 140,
        SPELL_EFFECT_FORCE_CAST_WITH_VALUE            = 141,
        SPELL_EFFECT_TRIGGER_SPELL_WITH_VALUE         = 142,
        SPELL_EFFECT_APPLY_AREA_AURA_OWNER            = 143,
        SPELL_EFFECT_KNOCK_BACK_DEST                  = 144,
        SPELL_EFFECT_PULL_TOWARDS_DEST                = 145,
        SPELL_EFFECT_ACTIVATE_RUNE                    = 146,
        SPELL_EFFECT_QUEST_FAIL                       = 147,
        SPELL_EFFECT_TRIGGER_MISSILE_SPELL_WITH_VALUE = 148,
        SPELL_EFFECT_CHARGE_DEST                      = 149,
        SPELL_EFFECT_QUEST_START                      = 150,
        SPELL_EFFECT_TRIGGER_SPELL_2                  = 151,
        SPELL_EFFECT_SUMMON_RAF_FRIEND                = 152,
        SPELL_EFFECT_CREATE_TAMED_PET                 = 153,
        SPELL_EFFECT_DISCOVER_TAXI                    = 154,
        SPELL_EFFECT_TITAN_GRIP                       = 155,
        SPELL_EFFECT_ENCHANT_ITEM_PRISMATIC           = 156,
        SPELL_EFFECT_CREATE_ITEM_2                    = 157,
        SPELL_EFFECT_MILLING                          = 158,
        SPELL_EFFECT_ALLOW_RENAME_PET                 = 159,
        SPELL_EFFECT_160                              = 160,
        SPELL_EFFECT_TALENT_SPEC_COUNT                = 161,
        SPELL_EFFECT_TALENT_SPEC_SELECT               = 162,
        SPELL_EFFECT_163                              = 163,
        SPELL_EFFECT_REMOVE_AURA                      = 164,
        TOTAL_SPELL_EFFECTS                           = 165
    }

    /// <summary>
    ///
    /// </summary>
    public enum AuraType
    {
        SPELL_AURA_NONE                                     = 0,
        SPELL_AURA_BIND_SIGHT                               = 1,
        SPELL_AURA_MOD_POSSESS                              = 2,
        SPELL_AURA_PERIODIC_DAMAGE                          = 3,
        SPELL_AURA_DUMMY                                    = 4,
        SPELL_AURA_MOD_CONFUSE                              = 5,
        SPELL_AURA_MOD_CHARM                                = 6,
        SPELL_AURA_MOD_FEAR                                 = 7,
        SPELL_AURA_PERIODIC_HEAL                            = 8,
        SPELL_AURA_MOD_ATTACKSPEED                          = 9,
        SPELL_AURA_MOD_THREAT                               = 10,
        SPELL_AURA_MOD_TAUNT                                = 11,
        SPELL_AURA_MOD_STUN                                 = 12,
        SPELL_AURA_MOD_DAMAGE_DONE                          = 13,
        SPELL_AURA_MOD_DAMAGE_TAKEN                         = 14,
        SPELL_AURA_DAMAGE_SHIELD                            = 15,
        SPELL_AURA_MOD_STEALTH                              = 16,
        SPELL_AURA_MOD_STEALTH_DETECT                       = 17,
        SPELL_AURA_MOD_INVISIBILITY                         = 18,
        SPELL_AURA_MOD_INVISIBILITY_DETECT                  = 19,
        SPELL_AURA_OBS_MOD_HEALTH                           = 20, // 20, 21 unofficial
        SPELL_AURA_OBS_MOD_POWER                            = 21,
        SPELL_AURA_MOD_RESISTANCE                           = 22,
        SPELL_AURA_PERIODIC_TRIGGER_SPELL                   = 23,
        SPELL_AURA_PERIODIC_ENERGIZE                        = 24,
        SPELL_AURA_MOD_PACIFY                               = 25,
        SPELL_AURA_MOD_ROOT                                 = 26,
        SPELL_AURA_MOD_SILENCE                              = 27,
        SPELL_AURA_REFLECT_SPELLS                           = 28,
        SPELL_AURA_MOD_STAT                                 = 29,
        SPELL_AURA_MOD_SKILL                                = 30,
        SPELL_AURA_MOD_INCREASE_SPEED                       = 31,
        SPELL_AURA_MOD_INCREASE_MOUNTED_SPEED               = 32,
        SPELL_AURA_MOD_DECREASE_SPEED                       = 33,
        SPELL_AURA_MOD_INCREASE_HEALTH                      = 34,
        SPELL_AURA_MOD_INCREASE_ENERGY                      = 35,
        SPELL_AURA_MOD_SHAPESHIFT                           = 36,
        SPELL_AURA_EFFECT_IMMUNITY                          = 37,
        SPELL_AURA_STATE_IMMUNITY                           = 38,
        SPELL_AURA_SCHOOL_IMMUNITY                          = 39,
        SPELL_AURA_DAMAGE_IMMUNITY                          = 40,
        SPELL_AURA_DISPEL_IMMUNITY                          = 41,
        SPELL_AURA_PROC_TRIGGER_SPELL                       = 42,
        SPELL_AURA_PROC_TRIGGER_DAMAGE                      = 43,
        SPELL_AURA_TRACK_CREATURES                          = 44,
        SPELL_AURA_TRACK_RESOURCES                          = 45,
        SPELL_AURA_46                                       = 46, // Ignore all Gear test spells
        SPELL_AURA_MOD_PARRY_PERCENT                        = 47,
        SPELL_AURA_48                                       = 48, // One periodic spell
        SPELL_AURA_MOD_DODGE_PERCENT                        = 49,
        SPELL_AURA_MOD_CRITICAL_HEALING_AMOUNT              = 50,
        SPELL_AURA_MOD_BLOCK_PERCENT                        = 51,
        SPELL_AURA_MOD_WEAPON_CRIT_PERCENT                  = 52,
        SPELL_AURA_PERIODIC_LEECH                           = 53,
        SPELL_AURA_MOD_HIT_CHANCE                           = 54,
        SPELL_AURA_MOD_SPELL_HIT_CHANCE                     = 55,
        SPELL_AURA_TRANSFORM                                = 56,
        SPELL_AURA_MOD_SPELL_CRIT_CHANCE                    = 57,
        SPELL_AURA_MOD_INCREASE_SWIM_SPEED                  = 58,
        SPELL_AURA_MOD_DAMAGE_DONE_CREATURE                 = 59,
        SPELL_AURA_MOD_PACIFY_SILENCE                       = 60,
        SPELL_AURA_MOD_SCALE                                = 61,
        SPELL_AURA_PERIODIC_HEALTH_FUNNEL                   = 62,
        SPELL_AURA_63                                       = 63, // old SPELL_AURA_PERIODIC_MANA_FUNNEL
        SPELL_AURA_PERIODIC_MANA_LEECH                      = 64,
        SPELL_AURA_MOD_CASTING_SPEED_NOT_STACK              = 65,
        SPELL_AURA_FEIGN_DEATH                              = 66,
        SPELL_AURA_MOD_DISARM                               = 67,
        SPELL_AURA_MOD_STALKED                              = 68,
        SPELL_AURA_SCHOOL_ABSORB                            = 69,
        SPELL_AURA_EXTRA_ATTACKS                            = 70,
        SPELL_AURA_MOD_SPELL_CRIT_CHANCE_SCHOOL             = 71,
        SPELL_AURA_MOD_POWER_COST_SCHOOL_PCT                = 72,
        SPELL_AURA_MOD_POWER_COST_SCHOOL                    = 73,
        SPELL_AURA_REFLECT_SPELLS_SCHOOL                    = 74,
        SPELL_AURA_MOD_LANGUAGE                             = 75,
        SPELL_AURA_FAR_SIGHT                                = 76,
        SPELL_AURA_MECHANIC_IMMUNITY                        = 77,
        SPELL_AURA_MOUNTED                                  = 78,
        SPELL_AURA_MOD_DAMAGE_PERCENT_DONE                  = 79,
        SPELL_AURA_MOD_PERCENT_STAT                         = 80,
        SPELL_AURA_SPLIT_DAMAGE_PCT                         = 81,
        SPELL_AURA_WATER_BREATHING                          = 82,
        SPELL_AURA_MOD_BASE_RESISTANCE                      = 83,
        SPELL_AURA_MOD_REGEN                                = 84,
        SPELL_AURA_MOD_POWER_REGEN                          = 85,
        SPELL_AURA_CHANNEL_DEATH_ITEM                       = 86,
        SPELL_AURA_MOD_DAMAGE_PERCENT_TAKEN                 = 87,
        SPELL_AURA_MOD_HEALTH_REGEN_PERCENT                 = 88,
        SPELL_AURA_PERIODIC_DAMAGE_PERCENT                  = 89,
        SPELL_AURA_90                                       = 90, // old SPELL_AURA_MOD_RESIST_CHANCE
        SPELL_AURA_MOD_DETECT_RANGE                         = 91,
        SPELL_AURA_PREVENTS_FLEEING                         = 92,
        SPELL_AURA_MOD_UNATTACKABLE                         = 93,
        SPELL_AURA_INTERRUPT_REGEN                          = 94,
        SPELL_AURA_GHOST                                    = 95,
        SPELL_AURA_SPELL_MAGNET                             = 96,
        SPELL_AURA_MANA_SHIELD                              = 97,
        SPELL_AURA_MOD_SKILL_TALENT                         = 98,
        SPELL_AURA_MOD_ATTACK_POWER                         = 99,
        SPELL_AURA_AURAS_VISIBLE                            = 100,
        SPELL_AURA_MOD_RESISTANCE_PCT                       = 101,
        SPELL_AURA_MOD_MELEE_ATTACK_POWER_VERSUS            = 102,
        SPELL_AURA_MOD_TOTAL_THREAT                         = 103,
        SPELL_AURA_WATER_WALK                               = 104,
        SPELL_AURA_FEATHER_FALL                             = 105,
        SPELL_AURA_HOVER                                    = 106,
        SPELL_AURA_ADD_FLAT_MODIFIER                        = 107,
        SPELL_AURA_ADD_PCT_MODIFIER                         = 108,
        SPELL_AURA_ADD_TARGET_TRIGGER                       = 109,
        SPELL_AURA_MOD_POWER_REGEN_PERCENT                  = 110,
        SPELL_AURA_ADD_CASTER_HIT_TRIGGER                   = 111,
        SPELL_AURA_OVERRIDE_CLASS_SCRIPTS                   = 112,
        SPELL_AURA_MOD_RANGED_DAMAGE_TAKEN                  = 113,
        SPELL_AURA_MOD_RANGED_DAMAGE_TAKEN_PCT              = 114,
        SPELL_AURA_MOD_HEALING                              = 115,
        SPELL_AURA_MOD_REGEN_DURING_COMBAT                  = 116,
        SPELL_AURA_MOD_MECHANIC_RESISTANCE                  = 117,
        SPELL_AURA_MOD_HEALING_PCT                          = 118,
        SPELL_AURA_119                                      = 119, // old SPELL_AURA_SHARE_PET_TRACKING
        SPELL_AURA_UNTRACKABLE                              = 120,
        SPELL_AURA_EMPATHY                                  = 121,
        SPELL_AURA_MOD_OFFHAND_DAMAGE_PCT                   = 122,
        SPELL_AURA_MOD_TARGET_RESISTANCE                    = 123,
        SPELL_AURA_MOD_RANGED_ATTACK_POWER                  = 124,
        SPELL_AURA_MOD_MELEE_DAMAGE_TAKEN                   = 125,
        SPELL_AURA_MOD_MELEE_DAMAGE_TAKEN_PCT               = 126,
        SPELL_AURA_RANGED_ATTACK_POWER_ATTACKER_BONUS       = 127,
        SPELL_AURA_MOD_POSSESS_PET                          = 128,
        SPELL_AURA_MOD_SPEED_ALWAYS                         = 129,
        SPELL_AURA_MOD_MOUNTED_SPEED_ALWAYS                 = 130,
        SPELL_AURA_MOD_RANGED_ATTACK_POWER_VERSUS           = 131,
        SPELL_AURA_MOD_INCREASE_ENERGY_PERCENT              = 132,
        SPELL_AURA_MOD_INCREASE_HEALTH_PERCENT              = 133,
        SPELL_AURA_MOD_MANA_REGEN_INTERRUPT                 = 134,
        SPELL_AURA_MOD_HEALING_DONE                         = 135,
        SPELL_AURA_MOD_HEALING_DONE_PERCENT                 = 136,
        SPELL_AURA_MOD_TOTAL_STAT_PERCENTAGE                = 137,
        SPELL_AURA_MOD_MELEE_HASTE                          = 138,
        SPELL_AURA_FORCE_REACTION                           = 139,
        SPELL_AURA_MOD_RANGED_HASTE                         = 140,
        SPELL_AURA_MOD_RANGED_AMMO_HASTE                    = 141,
        SPELL_AURA_MOD_BASE_RESISTANCE_PCT                  = 142,
        SPELL_AURA_MOD_RESISTANCE_EXCLUSIVE                 = 143,
        SPELL_AURA_SAFE_FALL                                = 144,
        SPELL_AURA_MOD_PET_TALENT_POINTS                    = 145,
        SPELL_AURA_ALLOW_TAME_PET_TYPE                      = 146,
        SPELL_AURA_MECHANIC_IMMUNITY_MASK                   = 147,
        SPELL_AURA_RETAIN_COMBO_POINTS                      = 148,
        SPELL_AURA_REDUCE_PUSHBACK                          = 149, // Reduce Pushback
        SPELL_AURA_MOD_SHIELD_BLOCKVALUE_PCT                = 150,
        SPELL_AURA_TRACK_STEALTHED                          = 151, // Track Stealthed
        SPELL_AURA_MOD_DETECTED_RANGE                       = 152, // Mod Detected Range
        SPELL_AURA_SPLIT_DAMAGE_FLAT                        = 153, // Split Damage Flat
        SPELL_AURA_MOD_STEALTH_LEVEL                        = 154, // Stealth Level Modifier
        SPELL_AURA_MOD_WATER_BREATHING                      = 155, // Mod Water Breathing
        SPELL_AURA_MOD_REPUTATION_GAIN                      = 156, // Mod Reputation Gain
        SPELL_AURA_PET_DAMAGE_MULTI                         = 157, // Mod Pet Damage
        SPELL_AURA_MOD_SHIELD_BLOCKVALUE                    = 158,
        SPELL_AURA_NO_PVP_CREDIT                            = 159,
        SPELL_AURA_MOD_AOE_AVOIDANCE                        = 160,
        SPELL_AURA_MOD_HEALTH_REGEN_IN_COMBAT               = 161,
        SPELL_AURA_POWER_BURN                               = 162,
        SPELL_AURA_MOD_CRIT_DAMAGE_BONUS                    = 163,
        SPELL_AURA_164                                      = 164,
        SPELL_AURA_MELEE_ATTACK_POWER_ATTACKER_BONUS        = 165,
        SPELL_AURA_MOD_ATTACK_POWER_PCT                     = 166,
        SPELL_AURA_MOD_RANGED_ATTACK_POWER_PCT              = 167,
        SPELL_AURA_MOD_DAMAGE_DONE_VERSUS                   = 168,
        SPELL_AURA_MOD_CRIT_PERCENT_VERSUS                  = 169,
        SPELL_AURA_DETECT_AMORE                             = 170,
        SPELL_AURA_MOD_SPEED_NOT_STACK                      = 171,
        SPELL_AURA_MOD_MOUNTED_SPEED_NOT_STACK              = 172,
        SPELL_AURA_173                                      = 173, // old SPELL_AURA_ALLOW_CHAMPION_SPELLS
        SPELL_AURA_MOD_SPELL_DAMAGE_OF_STAT_PERCENT         = 174, // by defeult intelect, dependent from SPELL_AURA_MOD_SPELL_HEALING_OF_STAT_PERCENT
        SPELL_AURA_MOD_SPELL_HEALING_OF_STAT_PERCENT        = 175,
        SPELL_AURA_SPIRIT_OF_REDEMPTION                     = 176,
        SPELL_AURA_AOE_CHARM                                = 177,
        SPELL_AURA_MOD_DEBUFF_RESISTANCE                    = 178,
        SPELL_AURA_MOD_ATTACKER_SPELL_CRIT_CHANCE           = 179,
        SPELL_AURA_MOD_FLAT_SPELL_DAMAGE_VERSUS             = 180,
        SPELL_AURA_181                                      = 181, // old SPELL_AURA_MOD_FLAT_SPELL_CRIT_DAMAGE_VERSUS - possible flat spell crit damage versus
        SPELL_AURA_MOD_RESISTANCE_OF_STAT_PERCENT           = 182,
        SPELL_AURA_MOD_CRITICAL_THREAT                      = 183,
        SPELL_AURA_MOD_ATTACKER_MELEE_HIT_CHANCE            = 184,
        SPELL_AURA_MOD_ATTACKER_RANGED_HIT_CHANCE           = 185,
        SPELL_AURA_MOD_ATTACKER_SPELL_HIT_CHANCE            = 186,
        SPELL_AURA_MOD_ATTACKER_MELEE_CRIT_CHANCE           = 187,
        SPELL_AURA_MOD_ATTACKER_RANGED_CRIT_CHANCE          = 188,
        SPELL_AURA_MOD_RATING                               = 189,
        SPELL_AURA_MOD_FACTION_REPUTATION_GAIN              = 190,
        SPELL_AURA_USE_NORMAL_MOVEMENT_SPEED                = 191,
        SPELL_AURA_MOD_MELEE_RANGED_HASTE                   = 192,
        SPELL_AURA_MELEE_SLOW                               = 193,
        SPELL_AURA_MOD_TARGET_ABSORB_SCHOOL                 = 194,
        SPELL_AURA_MOD_TARGET_ABILITY_ABSORB_SCHOOL         = 195,
        SPELL_AURA_MOD_COOLDOWN                             = 196, // only 24818 Noxious Breath
        SPELL_AURA_MOD_ATTACKER_SPELL_AND_WEAPON_CRIT_CHANCE= 197,
        SPELL_AURA_198                                      = 198, // old SPELL_AURA_MOD_ALL_WEAPON_SKILLS
        SPELL_AURA_MOD_INCREASES_SPELL_PCT_TO_HIT           = 199,
        SPELL_AURA_MOD_XP_PCT                               = 200,
        SPELL_AURA_FLY                                      = 201,
        SPELL_AURA_IGNORE_COMBAT_RESULT                     = 202,
        SPELL_AURA_MOD_ATTACKER_MELEE_CRIT_DAMAGE           = 203,
        SPELL_AURA_MOD_ATTACKER_RANGED_CRIT_DAMAGE          = 204,
        SPELL_AURA_MOD_SCHOOL_CRIT_DMG_TAKEN                = 205,
        SPELL_AURA_MOD_INCREASE_VEHICLE_FLIGHT_SPEED        = 206, // ? used in strange spells
        SPELL_AURA_MOD_INCREASE_MOUNTED_FLIGHT_SPEED        = 207,
        SPELL_AURA_MOD_INCREASE_FLIGHT_SPEED                = 208,
        SPELL_AURA_MOD_MOUNTED_FLIGHT_SPEED_ALWAYS          = 209,
        SPELL_AURA_MOD_VEHICLE_SPEED_ALWAYS                 = 210, // unused
        SPELL_AURA_MOD_FLIGHT_SPEED_NOT_STACK               = 211,
        SPELL_AURA_MOD_RANGED_ATTACK_POWER_OF_STAT_PERCENT  = 212,
        SPELL_AURA_MOD_RAGE_FROM_DAMAGE_DEALT               = 213,
        SPELL_AURA_214                                      = 214,
        SPELL_AURA_ARENA_PREPARATION                        = 215,
        SPELL_AURA_HASTE_SPELLS                             = 216,
        SPELL_AURA_MOD_MELEE_HASTE_2                        = 217,
        SPELL_AURA_HASTE_RANGED                             = 218,
        SPELL_AURA_MOD_MANA_REGEN_FROM_STAT                 = 219,
        SPELL_AURA_MOD_RATING_FROM_STAT                     = 220,
        SPELL_AURA_MOD_DETAUNT                              = 221,
        SPELL_AURA_222                                      = 222,
        SPELL_AURA_RAID_PROC_FROM_CHARGE                    = 223,
        SPELL_AURA_224                                      = 224,
        SPELL_AURA_RAID_PROC_FROM_CHARGE_WITH_VALUE         = 225,
        SPELL_AURA_PERIODIC_DUMMY                           = 226,
        SPELL_AURA_PERIODIC_TRIGGER_SPELL_WITH_VALUE        = 227,
        SPELL_AURA_DETECT_STEALTH                           = 228,
        SPELL_AURA_MOD_AOE_DAMAGE_AVOIDANCE                 = 229,
        SPELL_AURA_230                                      = 230,
        SPELL_AURA_PROC_TRIGGER_SPELL_WITH_VALUE            = 231,
        SPELL_AURA_MECHANIC_DURATION_MOD                    = 232,
        SPELL_AURA_CHANGE_MODEL_FOR_ALL_HUMANOIDS           = 233, // client-side only
        SPELL_AURA_MECHANIC_DURATION_MOD_NOT_STACK          = 234,
        SPELL_AURA_MOD_DISPEL_RESIST                        = 235,
        SPELL_AURA_CONTROL_VEHICLE                          = 236,
        SPELL_AURA_MOD_SPELL_DAMAGE_OF_ATTACK_POWER         = 237,
        SPELL_AURA_MOD_SPELL_HEALING_OF_ATTACK_POWER        = 238,
        SPELL_AURA_MOD_SCALE_2                              = 239,
        SPELL_AURA_MOD_EXPERTISE                            = 240,
        SPELL_AURA_FORCE_MOVE_FORWARD                       = 241,
        SPELL_AURA_MOD_SPELL_DAMAGE_FROM_HEALING            = 242,
        SPELL_AURA_MOD_FACTION                              = 243,
        SPELL_AURA_COMPREHEND_LANGUAGE                      = 244,
        SPELL_AURA_MOD_AURA_DURATION_BY_DISPEL              = 245,
        SPELL_AURA_MOD_AURA_DURATION_BY_DISPEL_NOT_STACK    = 246,
        SPELL_AURA_CLONE_CASTER                             = 247,
        SPELL_AURA_MOD_COMBAT_RESULT_CHANCE                 = 248,
        SPELL_AURA_CONVERT_RUNE                             = 249,
        SPELL_AURA_MOD_INCREASE_HEALTH_2                    = 250,
        SPELL_AURA_MOD_ENEMY_DODGE                          = 251,
        SPELL_AURA_MOD_SPEED_SLOW_ALL                       = 252,
        SPELL_AURA_MOD_BLOCK_CRIT_CHANCE                    = 253,
        SPELL_AURA_MOD_DISARM_OFFHAND                       = 254,
        SPELL_AURA_MOD_MECHANIC_DAMAGE_TAKEN_PERCENT        = 255,
        SPELL_AURA_NO_REAGENT_USE                           = 256,
        SPELL_AURA_MOD_TARGET_RESIST_BY_SPELL_CLASS         = 257,
        SPELL_AURA_258                                      = 258,
        SPELL_AURA_MOD_HOT_PCT                              = 259,
        SPELL_AURA_SCREEN_EFFECT                            = 260,
        SPELL_AURA_PHASE                                    = 261,
        SPELL_AURA_ABILITY_IGNORE_AURASTATE                 = 262,
        SPELL_AURA_ALLOW_ONLY_ABILITY                       = 263,
        SPELL_AURA_264                                      = 264,
        SPELL_AURA_265                                      = 265,
        SPELL_AURA_266                                      = 266,
        SPELL_AURA_MOD_IMMUNE_AURA_APPLY_SCHOOL             = 267,
        SPELL_AURA_MOD_ATTACK_POWER_OF_STAT_PERCENT         = 268,
        SPELL_AURA_MOD_IGNORE_TARGET_RESIST                 = 269,
        SPELL_AURA_MOD_ABILITY_IGNORE_TARGET_RESIST         = 270, // Possibly need swap vs 195 aura used only in 1 spell Chaos Bolt Passive
        SPELL_AURA_MOD_DAMAGE_FROM_CASTER                   = 271,
        SPELL_AURA_IGNORE_MELEE_RESET                       = 272,
        SPELL_AURA_X_RAY                                    = 273,
        SPELL_AURA_ABILITY_CONSUME_NO_AMMO                  = 274,
        SPELL_AURA_MOD_IGNORE_SHAPESHIFT                    = 275,
        SPELL_AURA_MOD_DAMAGE_DONE_FOR_MECHANIC             = 276, // Only "Test Mod Damage % Mechanic" spell, possible mod damage done
        SPELL_AURA_MOD_MAX_AFFECTED_TARGETS                 = 277,
        SPELL_AURA_MOD_DISARM_RANGED                        = 278,
        SPELL_AURA_INITIALIZE_IMAGES                        = 279,
        SPELL_AURA_MOD_ARMOR_PENETRATION_PCT                = 280,
        SPELL_AURA_MOD_HONOR_GAIN_PCT                       = 281,
        SPELL_AURA_MOD_BASE_HEALTH_PCT                      = 282,
        SPELL_AURA_MOD_HEALING_RECEIVED                     = 283, // Possibly only for some spell family class spells
        SPELL_AURA_LINKED                                   = 284,
        SPELL_AURA_MOD_ATTACK_POWER_OF_ARMOR                = 285,
        SPELL_AURA_ABILITY_PERIODIC_CRIT                    = 286,
        SPELL_AURA_DEFLECT_SPELLS                           = 287,
        SPELL_AURA_IGNORE_HIT_DIRECTION                     = 288,
        SPELL_AURA_PREVENT_DURABILITY_LOSS                  = 289, // Not used in 3.3.5a
        SPELL_AURA_MOD_CRIT_PCT                             = 290,
        SPELL_AURA_MOD_XP_QUEST_PCT                         = 291,
        SPELL_AURA_OPEN_STABLE                              = 292,
        SPELL_AURA_OVERRIDE_SPELLS                          = 293,
        SPELL_AURA_PREVENT_REGENERATE_POWER                 = 294,
        SPELL_AURA_295                                      = 295,
        SPELL_AURA_SET_VEHICLE_ID                           = 296,
        SPELL_AURA_BLOCK_SPELL_FAMILY                       = 297,
        SPELL_AURA_STRANGULATE                              = 298,
        SPELL_AURA_299                                      = 299,
        SPELL_AURA_SHARE_DAMAGE_PCT                         = 300,
        SPELL_AURA_SCHOOL_HEAL_ABSORB                       = 301,
        SPELL_AURA_302                                      = 302,
        SPELL_AURA_MOD_DAMAGE_DONE_VERSUS_AURASTATE         = 303,
        SPELL_AURA_MOD_FAKE_INEBRIATE                       = 304,
        SPELL_AURA_MOD_MINIMUM_SPEED                        = 305,
        SPELL_AURA_306                                      = 306,
        SPELL_AURA_HEAL_ABSORB_TEST                         = 307,
        SPELL_AURA_MOD_CRIT_CHANCE_FOR_CASTER               = 308,
        SPELL_AURA_309                                      = 309,
        SPELL_AURA_MOD_CREATURE_AOE_DAMAGE_AVOIDANCE        = 310,
        SPELL_AURA_311                                      = 311,
        SPELL_AURA_312                                      = 312,
        SPELL_AURA_313                                      = 313,
        SPELL_AURA_PREVENT_RESURRECTION                     = 314,
        SPELL_AURA_UNDERWATER_WALKING                       = 315,
        SPELL_AURA_PERIODIC_HASTE                           = 316,
        TOTAL_AURAS                                         = 317
    }

    /// <summary>
    /// Target
    /// </summary>
    public enum Targets
    {
        NO_TARGET                               = 0,
        TARGET_UNIT_CASTER                      = 1,
        TARGET_UNIT_NEARBY_ENEMY                = 2,
        TARGET_UNIT_NEARBY_PARTY                = 3,
        TARGET_UNIT_NEARBY_ALLY                 = 4,
        TARGET_UNIT_PET                         = 5,
        TARGET_UNIT_TARGET_ENEMY                = 6,
        TARGET_UNIT_SRC_AREA_ENTRY              = 7,
        TARGET_UNIT_DEST_AREA_ENTRY             = 8,
        TARGET_DEST_HOME                        = 9,
        TARGET_10                               = 10,
        TARGET_UNIT_SRC_AREA_UNK_11             = 11, // teleport target to caster
        TARGET_12                               = 12,
        TARGET_13                               = 13,
        TARGET_14                               = 14,
        TARGET_UNIT_SRC_AREA_ENEMY              = 15,
        TARGET_UNIT_DEST_AREA_ENEMY             = 16,
        TARGET_DEST_DB                          = 17,
        TARGET_DEST_CASTER                      = 18,
        TARGET_19                               = 19,
        TARGET_UNIT_CASTER_AREA_PARTY           = 20,
        TARGET_UNIT_TARGET_ALLY                 = 21,
        TARGET_SRC_CASTER                       = 22,
        TARGET_GAMEOBJECT_TARGET                = 23,
        TARGET_UNIT_CONE_ENEMY_24               = 24,
        TARGET_UNIT_TARGET_ANY                  = 25,
        TARGET_GAMEOBJECT_ITEM_TARGET           = 26,
        TARGET_UNIT_MASTER                      = 27,
        TARGET_DEST_DYNOBJ_ENEMY                = 28,
        TARGET_DEST_DYNOBJ_ALLY                 = 29,
        TARGET_UNIT_SRC_AREA_ALLY               = 30,
        TARGET_UNIT_DEST_AREA_ALLY              = 31,
        TARGET_DEST_CASTER_SUMMON               = 32, // front left, doesn't use radius
        TARGET_UNIT_SRC_AREA_PARTY              = 33,
        TARGET_UNIT_DEST_AREA_PARTY             = 34,
        TARGET_UNIT_TARGET_PARTY                = 35,
        TARGET_DEST_CASTER_UNK_36               = 36,
        TARGET_UNIT_LASTTARGET_AREA_PARTY       = 37,
        TARGET_UNIT_NEARBY_ENTRY                = 38,
        TARGET_DEST_CASTER_FISHING              = 39,
        TARGET_GAMEOBJECT_NEARBY_ENTRY          = 40,
        TARGET_DEST_CASTER_FRONT_RIGHT          = 41,
        TARGET_DEST_CASTER_BACK_RIGHT           = 42,
        TARGET_DEST_CASTER_BACK_LEFT            = 43,
        TARGET_DEST_CASTER_FRONT_LEFT           = 44,
        TARGET_UNIT_TARGET_CHAINHEAL_ALLY       = 45,
        TARGET_DEST_NEARBY_ENTRY                = 46,
        TARGET_DEST_CASTER_FRONT                = 47,
        TARGET_DEST_CASTER_BACK                 = 48,
        TARGET_DEST_CASTER_RIGHT                = 49,
        TARGET_DEST_CASTER_LEFT                 = 50,
        TARGET_GAMEOBJECT_SRC_AREA              = 51,
        TARGET_GAMEOBJECT_DEST_AREA             = 52,
        TARGET_DEST_TARGET_ENEMY                = 53,
        TARGET_UNIT_CONE_ENEMY_54               = 54,
        TARGET_DEST_CASTER_FRONT_LEAP           = 55, // for a leap spell
        TARGET_UNIT_CASTER_AREA_RAID            = 56,
        TARGET_UNIT_TARGET_RAID                 = 57,
        TARGET_UNIT_NEARBY_RAID                 = 58,
        TARGET_UNIT_CONE_ALLY                   = 59,
        TARGET_UNIT_CONE_ENTRY                  = 60,
        TARGET_UNIT_TARGET_AREA_RAID_CLASS      = 61,
        TARGET_UNK_62                           = 62,
        TARGET_DEST_TARGET_ANY                  = 63,
        TARGET_DEST_TARGET_FRONT                = 64,
        TARGET_DEST_TARGET_BACK                 = 65,
        TARGET_DEST_TARGET_RIGHT                = 66,
        TARGET_DEST_TARGET_LEFT                 = 67,
        TARGET_DEST_TARGET_FRONT_RIGHT          = 68,
        TARGET_DEST_TARGET_BACK_RIGHT           = 69,
        TARGET_DEST_TARGET_BACK_LEFT            = 70,
        TARGET_DEST_TARGET_FRONT_LEFT           = 71,
        TARGET_DEST_CASTER_RANDOM               = 72,
        TARGET_DEST_CASTER_RADIUS               = 73,
        TARGET_DEST_TARGET_RANDOM               = 74,
        TARGET_DEST_TARGET_RADIUS               = 75,
        TARGET_DEST_CHANNEL_TARGET              = 76,
        TARGET_UNIT_CHANNEL_TARGET              = 77,
        TARGET_DEST_DEST_FRONT                  = 78,
        TARGET_DEST_DEST_BACK                   = 79,
        TARGET_DEST_DEST_RIGHT                  = 80,
        TARGET_DEST_DEST_LEFT                   = 81,
        TARGET_DEST_DEST_FRONT_RIGHT            = 82,
        TARGET_DEST_DEST_BACK_RIGHT             = 83,
        TARGET_DEST_DEST_BACK_LEFT              = 84,
        TARGET_DEST_DEST_FRONT_LEFT             = 85,
        TARGET_DEST_DEST_RANDOM                 = 86,
        TARGET_DEST_DEST                        = 87,
        TARGET_DEST_DYNOBJ_NONE                 = 88,
        TARGET_DEST_TRAJ                        = 89,
        TARGET_UNIT_TARGET_MINIPET              = 90,
        TARGET_DEST_DEST_RADIUS                 = 91,
        TARGET_UNIT_SUMMONER                    = 92,
        TARGET_CORPSE_SRC_AREA_ENEMY            = 93, // NYI
        TARGET_UNIT_VEHICLE                     = 94,
        TARGET_UNIT_TARGET_PASSENGER            = 95,
        TARGET_UNIT_PASSENGER_0                 = 96,
        TARGET_UNIT_PASSENGER_1                 = 97,
        TARGET_UNIT_PASSENGER_2                 = 98,
        TARGET_UNIT_PASSENGER_3                 = 99,
        TARGET_UNIT_PASSENGER_4                 = 100,
        TARGET_UNIT_PASSENGER_5                 = 101,
        TARGET_UNIT_PASSENGER_6                 = 102,
        TARGET_UNIT_PASSENGER_7                 = 103,
        TARGET_UNIT_CONE_ENEMY_104              = 104,
        TARGET_UNIT_UNK_105                     = 105, // 1 spell
        TARGET_DEST_CHANNEL_CASTER              = 106,
        TARGET_UNK_DEST_AREA_UNK_107            = 107, // not enough info - only generic spells avalible
        TARGET_GAMEOBJECT_CONE                  = 108,
        TARGET_109                              = 109,
        TARGET_DEST_UNK_110                     = 110, // 1 spell
        TOTAL_SPELL_TARGETS,
    }

    ///<summary>
    ///Spell proc event related declarations (accessed using SpellMgr functions)
    ///</summary>
    [Flags]
    public enum ProcFlags
    {
        PROC_FLAG_KILLED                            = 0x00000001,    // 00 Killed by agressor - not sure about this flag
        PROC_FLAG_KILL                              = 0x00000002,    // 01 Kill target (in most cases need XP/Honor reward)

        PROC_FLAG_DONE_MELEE_AUTO_ATTACK            = 0x00000004,    // 02 Done melee auto attack
        PROC_FLAG_TAKEN_MELEE_AUTO_ATTACK           = 0x00000008,    // 03 Taken melee auto attack

        PROC_FLAG_DONE_SPELL_MELEE_DMG_CLASS        = 0x00000010,    // 04 Done attack by Spell that has dmg class melee
        PROC_FLAG_TAKEN_SPELL_MELEE_DMG_CLASS       = 0x00000020,    // 05 Taken attack by Spell that has dmg class melee

        PROC_FLAG_DONE_RANGED_AUTO_ATTACK           = 0x00000040,    // 06 Done ranged auto attack
        PROC_FLAG_TAKEN_RANGED_AUTO_ATTACK          = 0x00000080,    // 07 Taken ranged auto attack

        PROC_FLAG_DONE_SPELL_RANGED_DMG_CLASS       = 0x00000100,    // 08 Done attack by Spell that has dmg class ranged
        PROC_FLAG_TAKEN_SPELL_RANGED_DMG_CLASS      = 0x00000200,    // 09 Taken attack by Spell that has dmg class ranged

        PROC_FLAG_DONE_SPELL_NONE_DMG_CLASS_POS     = 0x00000400,    // 10 Done positive spell that has dmg class none
        PROC_FLAG_TAKEN_SPELL_NONE_DMG_CLASS_POS    = 0x00000800,    // 11 Taken positive spell that has dmg class none

        PROC_FLAG_DONE_SPELL_NONE_DMG_CLASS_NEG     = 0x00001000,    // 12 Done negative spell that has dmg class none
        PROC_FLAG_TAKEN_SPELL_NONE_DMG_CLASS_NEG    = 0x00002000,    // 13 Taken negative spell that has dmg class none

        PROC_FLAG_DONE_SPELL_MAGIC_DMG_CLASS_POS    = 0x00004000,    // 14 Done positive spell that has dmg class magic
        PROC_FLAG_TAKEN_SPELL_MAGIC_DMG_CLASS_POS   = 0x00008000,    // 15 Taken positive spell that has dmg class magic

        PROC_FLAG_DONE_SPELL_MAGIC_DMG_CLASS_NEG    = 0x00010000,    // 16 Done negative spell that has dmg class magic
        PROC_FLAG_TAKEN_SPELL_MAGIC_DMG_CLASS_NEG   = 0x00020000,    // 17 Taken negative spell that has dmg class magic

        PROC_FLAG_DONE_PERIODIC                     = 0x00040000,    // 18 Successful do periodic (damage / healing)
        PROC_FLAG_TAKEN_PERIODIC                    = 0x00080000,    // 19 Taken spell periodic (damage / healing)

        PROC_FLAG_TAKEN_DAMAGE                      = 0x00100000,    // 20 Taken any damage
        PROC_FLAG_DONE_TRAP_ACTIVATION              = 0x00200000,    // 21 On trap activation (possibly needs name change to ON_GAMEOBJECT_CAST or USE)

        PROC_FLAG_DONE_MAINHAND_ATTACK              = 0x00400000,    // 22 Done main-hand melee attacks (spell and autoattack)
        PROC_FLAG_DONE_OFFHAND_ATTACK               = 0x00800000,    // 23 Done off-hand melee attacks (spell and autoattack)

        PROC_FLAG_DEATH                             = 0x01000000     // 24 Died in any way
    }

    [Flags]
    public enum ProcFlagsEx
    {
        // If none can tigger on Hit/Crit only (passive spells MUST defined by SpellFamily flag)
        PROC_EX_NORMAL_HIT              = 0x0000001,                 // If set only from normal hit (only damage spells)
        PROC_EX_CRITICAL_HIT            = 0x0000002,
        PROC_EX_MISS                    = 0x0000004,
        PROC_EX_RESIST                  = 0x0000008,
        PROC_EX_DODGE                   = 0x0000010,
        PROC_EX_PARRY                   = 0x0000020,
        PROC_EX_BLOCK                   = 0x0000040,
        PROC_EX_EVADE                   = 0x0000080,
        PROC_EX_IMMUNE                  = 0x0000100,
        PROC_EX_DEFLECT                 = 0x0000200,
        PROC_EX_ABSORB                  = 0x0000400,
        PROC_EX_REFLECT                 = 0x0000800,
        PROC_EX_INTERRUPT               = 0x0001000,                 // Melee hit result can be Interrupt (not used)
        PROC_EX_FULL_BLOCK              = 0x0002000,                 // block al attack damage
        PROC_EX_RESERVED2               = 0x0004000,
        PROC_EX_NOT_ACTIVE_SPELL        = 0x0008000,                 // Spell mustn't do damage/heal to proc
        PROC_EX_EX_TRIGGER_ALWAYS       = 0x0010000,                 // If set trigger always no matter of hit result
        PROC_EX_EX_ONE_TIME_TRIGGER     = 0x0020000,                 // If set trigger always but only one time (not implemented yet)
        PROC_EX_ONLY_ACTIVE_SPELL       = 0x0040000,                 // Spell has to do damage/heal to proc
    }

    public enum SpellSchools
    {
        SPELL_SCHOOL_NORMAL = 0,
        SPELL_SCHOOL_HOLY   = 1,
        SPELL_SCHOOL_FIRE   = 2,
        SPELL_SCHOOL_NATURE = 3,
        SPELL_SCHOOL_FROST  = 4,
        SPELL_SCHOOL_SHADOW = 5,
        SPELL_SCHOOL_ARCANE = 6
    }

    [Flags]
    public enum SpellSchoolMask
    {
        SPELL_SCHOOL_MASK_NONE    = 0x00,                       // not exist
        SPELL_SCHOOL_MASK_NORMAL  = (1 << SpellSchools.SPELL_SCHOOL_NORMAL), // PHYSICAL (Armor)
        SPELL_SCHOOL_MASK_HOLY    = (1 << SpellSchools.SPELL_SCHOOL_HOLY),
        SPELL_SCHOOL_MASK_FIRE    = (1 << SpellSchools.SPELL_SCHOOL_FIRE),
        SPELL_SCHOOL_MASK_NATURE  = (1 << SpellSchools.SPELL_SCHOOL_NATURE),
        SPELL_SCHOOL_MASK_FROST   = (1 << SpellSchools.SPELL_SCHOOL_FROST),
        SPELL_SCHOOL_MASK_SHADOW  = (1 << SpellSchools.SPELL_SCHOOL_SHADOW),
        SPELL_SCHOOL_MASK_ARCANE  = (1 << SpellSchools.SPELL_SCHOOL_ARCANE),

        // unions

        // 124, not include normal and holy damage
        SPELL_SCHOOL_MASK_SPELL = (SPELL_SCHOOL_MASK_FIRE |
                                   SPELL_SCHOOL_MASK_NATURE | SPELL_SCHOOL_MASK_FROST |
                                   SPELL_SCHOOL_MASK_SHADOW | SPELL_SCHOOL_MASK_ARCANE),
        // 126
        SPELL_SCHOOL_MASK_MAGIC = (SPELL_SCHOOL_MASK_HOLY | SPELL_SCHOOL_MASK_SPELL),
        // 127
        SPELL_SCHOOL_MASK_ALL   = (SPELL_SCHOOL_MASK_NORMAL | SPELL_SCHOOL_MASK_MAGIC)
    }

    public enum Mechanics
    {
        MECHANIC_NONE               = 0,
        MECHANIC_CHARM              = 1,
        MECHANIC_DISORIENTED        = 2,
        MECHANIC_DISARM             = 3,
        MECHANIC_DISTRACT           = 4,
        MECHANIC_FEAR               = 5,
        MECHANIC_GRIP               = 6,
        MECHANIC_ROOT               = 7,
        MECHANIC_SLOW_ATTACK        = 8,
        MECHANIC_SILENCE            = 9,
        MECHANIC_SLEEP              = 10,
        MECHANIC_SNARE              = 11,
        MECHANIC_STUN               = 12,
        MECHANIC_FREEZE             = 13,
        MECHANIC_KNOCKOUT           = 14,
        MECHANIC_BLEED              = 15,
        MECHANIC_BANDAGE            = 16,
        MECHANIC_POLYMORPH          = 17,
        MECHANIC_BANISH             = 18,
        MECHANIC_SHIELD             = 19,
        MECHANIC_SHACKLE            = 20,
        MECHANIC_MOUNT              = 21,
        MECHANIC_INFECTED           = 22,
        MECHANIC_TURN               = 23,
        MECHANIC_HORROR             = 24,
        MECHANIC_INVULNERABILITY    = 25,
        MECHANIC_INTERRUPT          = 26,
        MECHANIC_DAZE               = 27,
        MECHANIC_DISCOVERY          = 28,
        MECHANIC_IMMUNE_SHIELD      = 29,  // Divine (Blessing) Shield/Protection and Ice Block
        MECHANIC_SAPPED             = 30,
        MECHANIC_ENRAGED            = 31
    }

    public enum SpellMissInfo
    {
        SPELL_MISS_NONE     = 0,
        SPELL_MISS_MISS     = 1,
        SPELL_MISS_RESIST   = 2,
        SPELL_MISS_DODGE    = 3,
        SPELL_MISS_PARRY    = 4,
        SPELL_MISS_BLOCK    = 5,
        SPELL_MISS_EVADE    = 6,
        SPELL_MISS_IMMUNE   = 7,
        SPELL_MISS_IMMUNE2  = 8, // one of these 2 is MISS_TEMPIMMUNE
        SPELL_MISS_DEFLECT  = 9,
        SPELL_MISS_ABSORB   = 10,
        SPELL_MISS_REFLECT  = 11
    }

    [Flags]
    public enum SpellHitType
    {
        SPELL_HIT_TYPE_UNK1 = 0x00001,
        SPELL_HIT_TYPE_CRIT = 0x00002,
        SPELL_HIT_TYPE_UNK3 = 0x00004,
        SPELL_HIT_TYPE_UNK4 = 0x00008,
        SPELL_HIT_TYPE_UNK5 = 0x00010,                          // replace caster?
        SPELL_HIT_TYPE_UNK6 = 0x00020
    }

    public enum SpellDmgClass
    {
        SPELL_DAMAGE_CLASS_NONE   = 0,
        SPELL_DAMAGE_CLASS_MAGIC  = 1,
        SPELL_DAMAGE_CLASS_MELEE  = 2,
        SPELL_DAMAGE_CLASS_RANGED = 3
    }

    public enum SpellPreventionType
    {
        SPELL_PREVENTION_TYPE_NONE    = 0,
        SPELL_PREVENTION_TYPE_SILENCE = 1,
        SPELL_PREVENTION_TYPE_PACIFY  = 2
    }

    [Flags]
    public enum ShapeshiftFormMask : uint
    {
        FORM_ALL                = 0xFFFFFFFF,
        FORM_NONE               = 0x00000000,
        FORM_CAT                = 0x00000001,   // 1
        FORM_TREE               = 0x00000002,   // 2
        FORM_TRAVEL             = 0x00000004,   // 3
        FORM_AQUA               = 0x00000008,   // 4
        FORM_BEAR               = 0x00000010,   // 5
        FORM_AMBIENT            = 0x00000020,   // 6
        FORM_GHOUL              = 0x00000040,   // 7
        FORM_DIREBEAR           = 0x00000080,   // 8
        FORM_STEVES_GHOUL       = 0x00000100,   // 9
        FORM_THARONJA_SKELETON  = 0x00000200,   // 10
        FORM_TEST_OF_STRENGTH   = 0x00000400,   // 11
        FORM_BLB_PLAYER         = 0x00000800,   // 12
        FORM_SHADOW_DANCE       = 0x00001000,   // 13
        FORM_CREATUREBEAR       = 0x00002000,   // 14
        FORM_CREATURECAT        = 0x00004000,   // 15
        FORM_GHOSTWOLF          = 0x00008000,   // 16
        FORM_BATTLESTANCE       = 0x00010000,   // 17
        FORM_DEFENSIVESTANCE    = 0x00020000,   // 18
        FORM_BERSERKERSTANCE    = 0x00040000,   // 19
        FORM_TEST               = 0x00080000,   // 20
        FORM_ZOMBIE             = 0x00100000,   // 21
        FORM_METAMORPHOSIS      = 0x00200000,   // 22
        FORM_UNK1               = 0x00400000,   // 23
        FORM_UNK2               = 0x00800000,   // 24
        FORM_UNDEAD             = 0x01000000,   // 25
        FORM_MASTER_ANGLER      = 0x02000000,   // 26
        FORM_FLIGHT_EPIC        = 0x04000000,   // 27
        FORM_SHADOW             = 0x08000000,   // 28
        FORM_FLIGHT             = 0x10000000,   // 29
        FORM_STEALTH            = 0x20000000,   // 30
        FORM_MOONKIN            = 0x40000000,   // 31
        FORM_SPIRITOFREDEMPTION = 0x80000000,   // 32
    }

    public enum DispelType
    {
        DISPEL_NONE         = 0,
        DISPEL_MAGIC        = 1,
        DISPEL_CURSE        = 2,
        DISPEL_DISEASE      = 3,
        DISPEL_POISON       = 4,
        DISPEL_STEALTH      = 5,
        DISPEL_INVISIBILITY = 6,
        DISPEL_ALL          = 7,
        DISPEL_SPE_NPC_ONLY = 8,
        DISPEL_ENRAGE       = 9,
        DISPEL_ZG_TICKET    = 10,
        DESPEL_OLD_UNUSED   = 11
    }

    public enum SpellModOp
    {
        SPELLMOD_DAMAGE                 = 0,
        SPELLMOD_DURATION               = 1,
        SPELLMOD_THREAT                 = 2,
        SPELLMOD_EFFECT1                = 3,
        SPELLMOD_CHARGES                = 4,
        SPELLMOD_RANGE                  = 5,
        SPELLMOD_RADIUS                 = 6,
        SPELLMOD_CRITICAL_CHANCE        = 7,
        SPELLMOD_ALL_EFFECTS            = 8,
        SPELLMOD_NOT_LOSE_CASTING_TIME  = 9,
        SPELLMOD_CASTING_TIME           = 10,
        SPELLMOD_COOLDOWN               = 11,
        SPELLMOD_EFFECT2                = 12,
        SPELLMOD_IGNORE_ARMOR           = 13,
        SPELLMOD_COST                   = 14,
        SPELLMOD_CRIT_DAMAGE_BONUS      = 15,
        SPELLMOD_RESIST_MISS_CHANCE     = 16,
        SPELLMOD_JUMP_TARGETS           = 17,
        SPELLMOD_CHANCE_OF_SUCCESS      = 18,
        SPELLMOD_ACTIVATION_TIME        = 19,
        SPELLMOD_DAMAGE_MULTIPLIER      = 20,
        SPELLMOD_GLOBAL_COOLDOWN        = 21,
        SPELLMOD_DOT                    = 22,
        SPELLMOD_EFFECT3                = 23,
        SPELLMOD_BONUS_MULTIPLIER       = 24,
        // spellmod 25
        SPELLMOD_PROC_PER_MINUTE        = 26,
        SPELLMOD_VALUE_MULTIPLIER       = 27,
        SPELLMOD_RESIST_DISPEL_CHANCE   = 28,
        SPELLMOD_CRIT_DAMAGE_BONUS_2    = 29, //one not used spell
        SPELLMOD_SPELL_COST_REFUND_ON_FAIL = 30
    }

    [Flags]
    public enum SpellCastTargetFlags
    {
        TARGET_FLAG_SELF            = 0x00000000,
        TARGET_FLAG_UNUSED_1        = 0x00000001,               // not used
        TARGET_FLAG_UNIT            = 0x00000002,               // pguid
        TARGET_FLAG_UNIT_RAID       = 0x00000004,               // not sent, used to validate target (if raid member)
        TARGET_FLAG_UNIT_PARTY      = 0x00000008,               // not sent, used to validate target (if party member)
        TARGET_FLAG_ITEM            = 0x00000010,               // pguid
        TARGET_FLAG_SOURCE_LOCATION = 0x00000020,               // pguid, 3 float
        TARGET_FLAG_DEST_LOCATION   = 0x00000040,               // pguid, 3 float
        TARGET_FLAG_UNIT_ENEMY      = 0x00000080,               // not sent, used to validate target (if enemy)
        TARGET_FLAG_UNIT_ALLY       = 0x00000100,               // not sent, used to validate target (if ally)
        TARGET_FLAG_CORPSE_ENEMY    = 0x00000200,               // pguid
        TARGET_FLAG_UNIT_DEAD       = 0x00000400,               // not sent, used to validate target (if dead creature)
        TARGET_FLAG_GAMEOBJECT      = 0x00000800,               // pguid, used with TARGET_GAMEOBJECT
        TARGET_FLAG_TRADE_ITEM      = 0x00001000,               // pguid
        TARGET_FLAG_STRING          = 0x00002000,               // string
        TARGET_FLAG_GAMEOBJECT_ITEM = 0x00004000,               // not sent, used with TARGET_GAMEOBJECT_ITEM
        TARGET_FLAG_CORPSE_ALLY     = 0x00008000,               // pguid
        TARGET_FLAG_UNIT_MINIPET    = 0x00010000,               // pguid, used to validate target (if non combat pet)
        TARGET_FLAG_GLYPH_SLOT      = 0x00020000,               // used in glyph spells
        TARGET_FLAG_UNK19           = 0x00040000,               // sometimes appears with DEST_TARGET spells (may appear or not for a given spell)
        TARGET_FLAG_UNUSED20        = 0x00080000,               // uint32 counter, loop { vec3 - screen position (?), guid }, not used so far
        TARGET_FLAG_UNIT_PASSENGER  = 0x00100000,               // guessed, used to validate target (if vehicle passenger)
    }

    public enum Powers : uint
    {
        POWER_MANA          = 0,
        POWER_RAGE          = 1,
        POWER_FOCUS         = 2,
        POWER_ENERGY        = 3,
        POWER_HAPPINESS     = 4,
        POWER_RUNE          = 5,
        POWER_RUNIC_POWER   = 6,
        POWER_HEALTH        = 0xFFFFFFFE,    // (-2 as signed value)
    }

    public enum AuraState
    {   // (C) used in caster aura state     (T) used in target aura state
        // (c) used in caster aura state-not (t) used in target aura state-not
        AURA_STATE_NONE                     = 0,
        AURA_STATE_DEFENSE                  = 1,            // C   |
        AURA_STATE_HEALTHLESS_20_PERCENT    = 2,            // CcT |
        AURA_STATE_BERSERKING               = 3,            // C T |
        AURA_STATE_FROZEN                   = 4,            //  c t| frozen target
        AURA_STATE_JUDGEMENT                = 5,            // C   |
        AURA_STATE_UNKNOWN6                 = 6,            //     | not used
        AURA_STATE_HUNTER_PARRY             = 7,            // C   |
        //AURA_STATE_ROGUE_ATTACK_FROM_STEALTH    = 7,      // C   | FIX ME: not implemented yet!
        //AURA_STATE_UNKNOWN7                     = 7,      //  c  | random/focused bursts spells (?)
        AURA_STATE_UNKNOWN8                 = 8,            //     | not used
        AURA_STATE_UNKNOWN9                 = 9,            //     | not used
        AURA_STATE_WARRIOR_VICTORY_RUSH     = 10,           // C   | warrior victory rush
        AURA_STATE_UNKNOWN11                = 11,           //    t|
        AURA_STATE_FAERIE_FIRE              = 12,           //  c t| prevent invisibility
        AURA_STATE_HEALTHLESS_35_PERCENT    = 13,           // C T |
        AURA_STATE_CONFLAGRATE              = 14,           //   T | per-caster
        AURA_STATE_SWIFTMEND                = 15,           //   T |
        AURA_STATE_DEADLY_POISON            = 16,           //   T |
        AURA_STATE_ENRAGE                   = 17,           // C   |
        AURA_STATE_BLEEDING                 = 18,           // C  t|
        AURA_STATE_UNKNOWN19                = 19,           //     | not used
        AURA_STATE_UNKNOWN20                = 20,           //  c  | only (45317 Suicide)
        AURA_STATE_UNKNOWN21                = 21,           //     | not used
        AURA_STATE_UNKNOWN22                = 22,           // C  t| not implemented yet (Requires Evasive Charges to use)
        AURA_STATE_HEALTH_ABOVE_75_PERCENT  = 23            // C   |
    }

    [Flags]
    enum InventoryTypeMask
    {
        ALL             = -1,
        NON_EQUIP       = 1 << 0,
        HEAD            = 1 << 1,
        NECK            = 1 << 2,
        SHOULDERS       = 1 << 3,
        BODY            = 1 << 4,
        CHEST           = 1 << 5,
        WAIST           = 1 << 6,
        LEGS            = 1 << 7,
        FEET            = 1 << 8,
        WRISTS          = 1 << 9,
        HANDS           = 1 << 10,
        FINGER          = 1 << 11,
        TRINKET         = 1 << 12,
        WEAPON          = 1 << 13,
        SHIELD          = 1 << 14,
        RANGED          = 1 << 15,
        CLOAK           = 1 << 16,
        WEAPON_2H       = 1 << 17,
        BAG             = 1 << 18,
        TABARD          = 1 << 19,
        ROBE            = 1 << 20,
        WEAPONMAINHAND  = 1 << 21,
        WEAPONOFFHAND   = 1 << 22,
        HOLDABLE        = 1 << 23,
        AMMO            = 1 << 24,
        THROWN          = 1 << 25,
        RANGEDRIGHT     = 1 << 26,
        QUIVER          = 1 << 27,
        RELIC           = 1 << 28,
    }

    public enum ItemClass
    {
        CONSUMABLE  = 0,
        CONTAINER   = 1,
        WEAPON      = 2,
        GEM         = 3,
        ARMOR       = 4,
        REAGENT     = 5,
        PROJECTILE  = 6,
        TRADE_GOODS = 7,
        GENERIC     = 8,
        RECIPE      = 9,
        MONEY       = 10,
        QUIVER      = 11,
        QUEST       = 12,
        KEY         = 13,
        PERMANENT   = 14,
        MISC        = 15,
        GLYPH       = 16,
        MAX
    }

    [Flags]
    public enum ItemSubClassWeaponMask
    {
        ALL             = -1,
        AXE             = 1 << 0,
        AXE2            = 1 << 1,
        BOW             = 1 << 2,
        GUN             = 1 << 3,
        MACE            = 1 << 4,
        MACE2           = 1 << 5,
        POLEARM         = 1 << 6,
        SWORD           = 1 << 7,
        SWORD2          = 1 << 8,
        OBSOLETE        = 1 << 9,
        STAFF           = 1 << 10,
        EXOTIC          = 1 << 11,
        EXOTIC2         = 1 << 12,
        FIST            = 1 << 13,
        MISC            = 1 << 14,
        DAGGER          = 1 << 15,
        THROWN          = 1 << 16,
        SPEAR           = 1 << 17,
        CROSSBOW        = 1 << 18,
        WAND            = 1 << 19,
        FISHING_POLE    = 1 << 20
    }

    [Flags]
    public enum ItemSubClassArmorMask
    {
        ALL     = -1,
        MISC    = 1 << 0,
        CLOTH   = 1 << 1,
        LEATHER = 1 << 2,
        MAIL    = 1 << 3,
        PLATE   = 1 << 4,
        BUCKLER = 1 << 5,
        SHIELD  = 1 << 6,
        LIBRAM  = 1 << 7,
        IDOL    = 1 << 8,
        TOTEM   = 1 << 9,
        SIGIL   = 1 << 10
    }

    [Flags]
    public enum ItemSubClassMiscMask
    {
        ALL     = -1,
        JUNK    = 1 << 0,
        REAGENT = 1 << 1,
        PET     = 1 << 2,
        HOLIDAY = 1 << 3,
        OTHER   = 1 << 4,
        MOUNT   = 1 << 5,
    }

    [Flags]
    public enum CreatureTypeMask
    {
        ALL             = -1,
        NONE            = 0,
        BEAST           = 1 << 0,
        DRAGONKIN       = 1 << 1,
        DEMON           = 1 << 2,
        ELEMENTAL       = 1 << 3,
        GIANT           = 1 << 4,
        UNDEAD          = 1 << 5,
        HUMANOID        = 1 << 6,
        CRITTER         = 1 << 7,
        MECHANICAL      = 1 << 8,
        NOT_SPECIFIED   = 1 << 9,
        TOTEM           = 1 << 10,
        NON_COMBAT_PET  = 1 << 11,
        GAS_CLOUD       = 1 << 12
    }

    [Flags]
    public enum SpellAtribute : uint
    {
        SPELL_ATTR0_ALL                              = 0xFFFFFFFF,
        SPELL_ATTR0_NONE                             = 0x00000000,
        SPELL_ATTR0_PROC_FAILURE_BURNS_CHARGE        = 0x00000001, // TITLE Unknown attribute 0@Attr0
        SPELL_ATTR0_USES_RANGED_SLOT                 = 0x00000002, // TITLE Treat as ranged attack DESCRIPTION Use ammo, ranged attack range modifiers, ranged haste, etc.
        SPELL_ATTR0_ON_NEXT_SWING_NO_DAMAGE          = 0x00000004, // TITLE On next melee (type 1) DESCRIPTION Both "on next swing" attributes have identical handling in server & client
        SPELL_ATTR0_DO_NOT_LOG_IMMUNE_MISSES         = 0x00000008, // TITLE Replenishment (client only)
        SPELL_ATTR0_IS_ABILITY                       = 0x00000010, // TITLE Treat as ability DESCRIPTION Cannot be reflected, not affected by cast speed modifiers, etc.
        SPELL_ATTR0_IS_TRADESKILL                    = 0x00000020, // TITLE Trade skill recipe DESCRIPTION Displayed in recipe list, not affected by cast speed modifiers
        SPELL_ATTR0_PASSIVE                          = 0x00000040, // TITLE Passive spell DESCRIPTION Spell is automatically cast on self by core
        SPELL_ATTR0_DO_NOT_DISPLAY                   = 0x00000080, // TITLE Hidden in UI (client only) DESCRIPTION Not visible in spellbook or aura bar (Spellbook, Aura Icon, Combat Log)
        SPELL_ATTR0_DO_NOT_LOG                       = 0x00000100, // TITLE Hidden in combat log (client only) DESCRIPTION Spell will not appear in combat logs
        SPELL_ATTR0_HELD_ITEM_ONLY                   = 0x00000200, // TITLE Auto-target mainhand item (client only) DESCRIPTION Client will automatically select main-hand item as cast target
        SPELL_ATTR0_ON_NEXT_SWING                    = 0x00000400, // TITLE On next melee (type 2) DESCRIPTION Both "on next swing" attributes have identical handling in server & client
        SPELL_ATTR0_WEARER_CASTS_PROC_TRIGGER        = 0x00000800, // TITLE Unknown attribute 11@Attr0
        SPELL_ATTR0_SERVER_ONLY                      = 0x00001000, // TITLE Only usable during daytime (unused)
        SPELL_ATTR0_ALLOW_ITEM_SPELL_IN_PVP          = 0x00002000, // TITLE Only usable during nighttime (unused)
        SPELL_ATTR0_ONLY_INDOORS                     = 0x00004000, // TITLE Only usable indoors
        SPELL_ATTR0_ONLY_OUTDOORS                    = 0x00008000, // TITLE Only usable outdoors
        SPELL_ATTR0_NOT_SHAPESHIFTED                 = 0x00010000, // TITLE Not usable while shapeshifted
        SPELL_ATTR0_ONLY_STEALTHED                   = 0x00020000, // TITLE Only usable in stealth
        SPELL_ATTR0_DO_NOT_SHEATH                    = 0x00040000, // TITLE Don't shealthe weapons (client only)
        SPELL_ATTR0_SCALES_WITH_CREATURE_LEVEL       = 0x00080000, // TITLE Scale with caster level DESCRIPTION For non-player casts, scale impact and power cost with caster's level
        SPELL_ATTR0_CANCELS_AUTO_ATTACK_COMBAT       = 0x00100000, // TITLE Stop attacking after cast DESCRIPTION After casting this, the current auto-attack will be interrupted
        SPELL_ATTR0_NO_ACTIVE_DEFENSE                = 0x00200000, // TITLE Prevent physical avoidance DESCRIPTION Spell cannot be dodged, parried or blocked
        SPELL_ATTR0_TRACK_TARGET_IN_CAST_PLAYER_ONLY = 0x00400000, // TITLE Automatically face target during cast (client only)
        SPELL_ATTR0_ALLOW_CAST_WHILE_DEAD            = 0x00800000, // TITLE Can be cast while dead DESCRIPTION Spells without this flag cannot be cast by dead units in non-triggered contexts
        SPELL_ATTR0_ALLOW_WHILE_MOUNTED              = 0x01000000, // TITLE Can be cast while mounted
        SPELL_ATTR0_COOLDOWN_ON_EVENT                = 0x02000000, // TITLE Cooldown starts on expiry DESCRIPTION Spell is unusable while already active, and cooldown does not begin until the effects have worn off
        SPELL_ATTR0_AURA_IS_DEBUFF                   = 0x04000000, // TITLE Is negative spell DESCRIPTION Forces the spell to be treated as a negative spell
        SPELL_ATTR0_ALLOW_WHILE_SITTING              = 0x08000000, // TITLE Can be cast while sitting
        SPELL_ATTR0_NOT_IN_COMBAT_ONLY_PEACEFUL      = 0x10000000, // TITLE Cannot be used in combat
        SPELL_ATTR0_NO_IMMUNITIES                    = 0x20000000, // TITLE Pierce invulnerability DESCRIPTION Allows spell to pierce invulnerability, unless the invulnerability spell also has this attribute
        SPELL_ATTR0_HEARTBEAT_RESIST                 = 0x40000000, // TITLE Periodic resistance checks DESCRIPTION Periodically re-rolls against resistance to potentially expire aura early
        SPELL_ATTR0_NO_AURA_CANCEL                   = 0x80000000  // TITLE Aura cannot be cancelled DESCRIPTION Prevents the player from voluntarily canceling a positive aura
    }

    [Flags]
    public enum SpellAtributeEx : uint
    {
        SPELL_ATTR1_ALL                                      = 0xFFFFFFFF,
        SPELL_ATTR1_NONE                                     = 0x00000000,
        SPELL_ATTR1_DISMISS_PET_FIRST                        = 0x00000001, // TITLE Dismiss Pet on cast DESCRIPTION Without this attribute, summoning spells will fail if caster already has a pet
        SPELL_ATTR1_USE_ALL_MANA                             = 0x00000002, // TITLE Drain all power DESCRIPTION Ignores listed power cost and drains entire pool instead
        SPELL_ATTR1_IS_CHANNELED                             = 0x00000004, // TITLE Channeled (type 1) DESCRIPTION Both "channeled" attributes have identical handling in server & client
        SPELL_ATTR1_NO_REDIRECTION                           = 0x00000008, // TITLE Ignore redirection effects DESCRIPTION Spell will not be attracted by SPELL_MAGNET auras (Grounding Totem)
        SPELL_ATTR1_NO_SKILL_INCREASE                        = 0x00000010, // TITLE Unknown attribute 4@Attr1 DESCRIPTION stealth and whirlwind
        SPELL_ATTR1_ALLOW_WHILE_STEALTHED                    = 0x00000020, // TITLE Does not break stealth
        SPELL_ATTR1_IS_SELF_CHANNELED                        = 0x00000040, // TITLE Channeled (type 2) DESCRIPTION Both "channeled" attributes have identical handling in server & client
        SPELL_ATTR1_NO_REFLECTION                            = 0x00000080, // TITLE Ignore reflection effects DESCRIPTION Spell will pierce through Spell Reflection and similar
        SPELL_ATTR1_ONLY_PEACEFUL_TARGETS                    = 0x00000100, // TITLE Target cannot be in combat
        SPELL_ATTR1_INITIATE_COMBAT                          = 0x00000200, // TITLE Enables Auto-Attack (client only) DESCRIPTION Caster will begin auto-attacking the target on cast
        SPELL_ATTR1_NO_THREAT                                = 0x00000400, // TITLE Does not generate threat DESCRIPTION Also does not cause target to engage
        SPELL_ATTR1_AURA_UNIQUE                              = 0x00000800, // TITLE Aura will not refresh its duration when recast
        SPELL_ATTR1_FAILURE_BREAKS_STEALTH                   = 0x00001000, // TITLE Pickpocket (client only)
        SPELL_ATTR1_TOGGLE_FAR_SIGHT                         = 0x00002000, // TITLE Farsight aura (client only)
        SPELL_ATTR1_TRACK_TARGET_IN_CHANNEL                  = 0x00004000, // TITLE Track target while channeling DESCRIPTION While channeling, adjust facing to face target
        SPELL_ATTR1_IMMUNITY_PURGES_EFFECT                   = 0x00008000, // TITLE Immunity cancels preapplied auras DESCRIPTION For immunity spells, cancel all auras that this spell would make you immune to when the spell is applied
        SPELL_ATTR1_IMMUNITY_TO_HOSTILE_AND_FRIENDLY_EFFECTS = 0x00010000, // TITLE Unaffected by school immunities DESCRIPTION Will not pierce Divine Shield, Ice Block and other full invulnerabilities
        SPELL_ATTR1_NO_AUTOCAST_AI                           = 0x00020000, // TITLE Cannot be autocast by pet DESCRIPTION (AI)
        SPELL_ATTR1_PREVENTS_ANIM                            = 0x00040000, // TITLE NYI, auras apply UNIT_FLAG_PREVENT_EMOTES_FROM_CHAT_TEXT
        SPELL_ATTR1_EXCLUDE_CASTER                           = 0x00080000, // TITLE Cannot be self-cast
        SPELL_ATTR1_FINISHING_MOVE_DAMAGE                    = 0x00100000, // TITLE Requires combo points (type 1)
        SPELL_ATTR1_THREAT_ONLY_ON_MISS                      = 0x00200000, // TITLE Unknown attribute 21@Attr1
        SPELL_ATTR1_FINISHING_MOVE_DURATION                  = 0x00400000, // TITLE Requires combo points (type 2)
        SPELL_ATTR1_IGNORE_OWNERS_DEATH                      = 0x00800000, // TITLE Unknwon attribute 23@Attr1
        SPELL_ATTR1_SPECIAL_SKILLUP                          = 0x01000000, // TITLE Fishing (client only)
        SPELL_ATTR1_AURA_STAYS_AFTER_COMBAT                  = 0x02000000, // TITLE Unknown attribute 25@Attr1
        SPELL_ATTR1_REQUIRE_ALL_TARGETS                      = 0x04000000, // TITLE Unknown attribute 26@Attr1 DESCRIPTION Related to [target=focus] and [target=mouseover] macros?
        SPELL_ATTR1_DISCOUNT_POWER_ON_MISS                   = 0x08000000, // TITLE Unknown attribute 27@Attr1 DESCRIPTION Melee spell?
        SPELL_ATTR1_NO_AURA_ICON                             = 0x10000000, // TITLE Hide in aura bar (client only)
        SPELL_ATTR1_NAME_IN_CHANNEL_BAR                      = 0x20000000, // TITLE Show spell name during channel (client only)
        SPELL_ATTR1_COMBO_ON_BLOCK                           = 0x40000000, // TITLE Enable at dodge DESCRIPTION (Mainline: Dispel All Stacks)
        SPELL_ATTR1_CAST_WHEN_LEARNED                        = 0x80000000  // TITLE Unknown attribute 31@Attr1
    }

    [Flags]
    public enum SpellAtributeEx2 : uint
    {
        SPELL_ATTR2_ALL                                  = 0xFFFFFFFF,
        SPELL_ATTR2_NONE                                 = 0x00000000,
        SPELL_ATTR2_ALLOW_DEAD_TARGET                    = 0x00000001, // TITLE Can target dead players or corpses
        SPELL_ATTR2_NO_SHAPESHIFT_UI                     = 0x00000002, // TITLE Unknown attribute 1@Attr2 DESCRIPTION vanish, shadowform, Ghost Wolf and other
        SPELL_ATTR2_IGNORE_LINE_OF_SIGHT                 = 0x00000004, // TITLE Ignore Line of Sight
        SPELL_ATTR2_ALLOW_LOW_LEVEL_BUFF                 = 0x00000008, // TITLE Ignore aura scaling
        SPELL_ATTR2_USE_SHAPESHIFT_BAR                   = 0x00000010, // TITLE Show in stance bar (client only)
        SPELL_ATTR2_AUTO_REPEAT                          = 0x00000020, // TITLE Ranged auto-attack spell
        SPELL_ATTR2_CANNOT_CAST_ON_TAPPED                = 0x00000040, // TITLE Cannot target others' tapped units DESCRIPTION Can only target untapped units, or those tapped by caster
        SPELL_ATTR2_DO_NOT_REPORT_SPELL_FAILURE          = 0x00000080, // TITLE Unknown attribute 7@Attr2
        SPELL_ATTR2_INCLUDE_IN_ADVANCED_COMBAT_LOG       = 0x00000100, // TITLE Unknown attribute 8@Attr2 DESCRIPTION not set in 3.0.3
        SPELL_ATTR2_ALWAYS_CAST_AS_UNIT                  = 0x00000200, // TITLE Unknown attribute 9@Attr2
        SPELL_ATTR2_SPECIAL_TAMING_FLAG                  = 0x00000400, // TITLE Unknown attribute 10@Attr2 DESCRIPTION Related to taming?
        SPELL_ATTR2_NO_TARGET_PER_SECOND_COST            = 0x00000800, // TITLE Health Funnel
        SPELL_ATTR2_CHAIN_FROM_CASTER                    = 0x00001000, // TITLE Unknown attribute 12@Attr2 DESCRIPTION Cleave, Heart Strike, Maul, Sunder Armor, Swipe
        SPELL_ATTR2_ENCHANT_OWN_ITEM_ONLY                = 0x00002000, // TITLE Enchant persists when entering arena
        SPELL_ATTR2_ALLOW_WHILE_INVISIBLE                = 0x00004000, // TITLE Unknown attribute 14@Attr2
        SPELL_ATTR2_DO_NOT_CONSUME_IF_GAINED_DURING_CAST = 0x00008000, // TITLE Unknown attribute 15@Attr2 DESCRIPTION not set in 3.0.3
        SPELL_ATTR2_NO_ACTIVE_PETS                       = 0x00010000, // TITLE Tame Beast
        SPELL_ATTR2_DO_NOT_RESET_COMBAT_TIMERS           = 0x00020000, // TITLE Don't reset swing timer DESCRIPTION Does not reset melee/ranged autoattack timer on cast
        SPELL_ATTR2_NO_JUMP_WHILE_CAST_PENDING           = 0x00040000, // TITLE Requires dead pet
        SPELL_ATTR2_ALLOW_WHILE_NOT_SHAPESHIFTED         = 0x00080000, // TITLE Also allow outside shapeshift (caster form) DESCRIPTION Even if Stances are nonzero, allow spell to be cast outside of shapeshift (though not in a different shapeshift)
        SPELL_ATTR2_INITIATE_COMBAT_POST_CAST            = 0x00100000, // TITLE (Enables Auto-Attack)
        SPELL_ATTR2_FAIL_ON_ALL_TARGETS_IMMUNE           = 0x00200000, // TITLE Damage reduction ability DESCRIPTION Causes BG flags to be dropped if combined with ATTR1_DISPEL_AURAS_ON_IMMUNITY
        SPELL_ATTR2_NO_INITIAL_THREAD                    = 0x00400000, // TITLE Unknown attribute 22@Attr2 DESCRIPTION Ambush, Backstab, Cheap Shot, Death Grip, Garrote, Judgements, Mutilate, Pounce, Ravage, Shiv, Shred
        SPELL_ATTR2_PROC_COOLDOWN_ON_FAILURE             = 0x00800000, // TITLE Arcane Concentration
        SPELL_ATTR2_ITEM_CAST_WITH_OWNER_SKILL           = 0x01000000, // TITLE Unknown attribute 24@Attr2
        SPELL_ATTR2_DONT_BLOCK_MANA_REGEN                = 0x02000000, // TITLE Unknown attribute 25@Attr2
        SPELL_ATTR2_NO_SCHOOL_IMMUNITIES                 = 0x04000000, // TITLE Pierce aura application immunities DESCRIPTION Allow aura to be applied despite target being immune to new aura applications
        SPELL_ATTR2_IGNORE_WEAPONSKILL                   = 0x08000000, // TITLE Unknown attribute 27@Attr2
        SPELL_ATTR2_NOT_AN_ACTION                        = 0x10000000, // TITLE Unknown attribute 28@Attr2
        SPELL_ATTR2_CANT_CRIT                            = 0x20000000, // TITLE Cannot critically strike
        SPELL_ATTR2_ACTIVE_THREAT                        = 0x40000000, // TITLE Allow triggered spell to trigger (type 1) DESCRIPTION Without this attribute, any triggered spell will be unable to trigger other auras' procs
        SPELL_ATTR2_RETAIN_ITEM_CAST                     = 0x80000000  // TITLE Food buff (client only)
    }

    [Flags]
    public enum SpellAtributeEx3 : uint
    {
        SPELL_ATTR3_ALL                                   = 0xFFFFFFFF,
        SPELL_ATTR3_NONE                                  = 0x00000000,
        SPELL_ATTR3_PVP_ENABLING                          = 0x00000001, // TITLE Unknown attribute 0@Attr3
        SPELL_ATTR3_NO_PROC_EQUIP_REQUIREMENT             = 0x00000002, // TITLE 1 Ignores subclass mask check when checking proc
        SPELL_ATTR3_NO_CASTING_BAR_TEXT                   = 0x00000004, // TITLE Unknown attribute 2@Attr3
        SPELL_ATTR3_COMPLETELY_BLOCKED                    = 0x00000008, // TITLE Blockable spell
        SPELL_ATTR3_NO_RES_TIMER                          = 0x00000010, // TITLE Ignore resurrection timer
        SPELL_ATTR3_NO_DURABILITY_LOSS                    = 0x00000020, // TITLE Unknown attribute 5@Attr3
        SPELL_ATTR3_NO_AVOIDANCE                          = 0x00000040, // TITLE Unknown attribute 6@Attr3
        SPELL_ATTR3_DOT_STACKING_RULE                     = 0x00000080, // TITLE Stack separately for each caster
        SPELL_ATTR3_ONLY_ON_PLAYER                        = 0x00000100, // TITLE Can only target players
        SPELL_ATTR3_NOT_A_PROC                            = 0x00000200, // TITLE Allow triggered spell to trigger (type 2) DESCRIPTION Without this attribute, any triggered spell will be unable to trigger other auras' procs
        SPELL_ATTR3_REQUIRES_MAIN_HAND_WEAPON             = 0x00000400, // TITLE Require main hand weapon
        SPELL_ATTR3_ONLY_BATTLEGROUNDS                    = 0x00000800, // TITLE Can only be cast in battleground
        SPELL_ATTR3_ONLY_ON_GHOSTS                        = 0x00001000, // TITLE Can only target ghost players
        SPELL_ATTR3_HIDE_CHANNEL_BAR                      = 0x00002000, // TITLE Do not display channel bar (client only)
        SPELL_ATTR3_HIDE_IN_RAID_FILTER                   = 0x00004000, // TITLE Honorless Target
        SPELL_ATTR3_NORMAL_RANGED_ATTACK                  = 0x00008000, // TITLE Unknown attribute 15@Attr3 DESCRIPTION Auto Shoot, Shoot, Throw - ranged normal attack attribute?
        SPELL_ATTR3_SUPRESS_CASTER_PROCS                  = 0x00010000, // TITLE Cannot trigger procs
        SPELL_ATTR3_SUPRESS_TARGET_PROCS                  = 0x00020000, // TITLE No initial aggro
        SPELL_ATTR3_ALWAYS_HIT                            = 0x00040000, // TITLE Ignore hit result DESCRIPTION Spell cannot miss, or be dodged/parried/blocked
        SPELL_ATTR3_INSTANT_TARGET_PROCS                  = 0x00080000, // TITLE Cannot trigger spells during aura proc
        SPELL_ATTR3_ALLOW_AURA_WHILE_DEAD                 = 0x00100000, // TITLE Persists through death
        SPELL_ATTR3_ONLY_PROC_OUTDOORS                    = 0x00200000, // TITLE Unknown attribute 21@Attr3
        SPELL_ATTR3_CASTING_CANCELS_AUTOREPEAT            = 0x00400000, // TITLE Requires equipped Wand (Mainline: Do Not Trigger Target Stand)
        SPELL_ATTR3_NO_DAMAGE_HISTORY                     = 0x00800000, // TITLE Unknown attribute 23@Attr3
        SPELL_ATTR3_REQUIRES_OFF_HAND_WEAPON              = 0x01000000, // TITLE Requires offhand weapon
        SPELL_ATTR3_TREAT_AS_PERIODIC                     = 0x02000000, // TITLE Treat as periodic effect
        SPELL_ATTR3_CAN_PROC_FROM_PROCS                   = 0x04000000, // TITLE Can trigger from triggered spells
        SPELL_ATTR3_ONLY_PROC_ON_CASTER                   = 0x08000000, // TITLE Drain Soul
        SPELL_ATTR3_IGNORE_CASTER_AND_TARGET_RESTRICTIONS = 0x10000000, // TITLE Unknown attribute 28@Attr3
        SPELL_ATTR3_IGNORE_CASTER_MODIFIERS               = 0x20000000, // TITLE Damage dealt is unaffected by modifiers
        SPELL_ATTR3_DO_NOT_DISPLAY_RANGE                  = 0x40000000, // TITLE Do not show range in tooltip (client only)
        SPELL_ATTR3_NOT_ON_AOE_IMMUNE                     = 0x80000000  // TITLE Unknown attribute 31@Attr3
    }

    [Flags]
    public enum SpellAtributeEx4 : uint
    {
        SPELL_ATTR4_ALL                                = 0xFFFFFFFF,
        SPELL_ATTR4_NONE                               = 0x00000000,
        SPELL_ATTR4_NO_CAST_LOG                        = 0x00000001, // TITLE Cannot be resisted
        SPELL_ATTR4_CLASS_TRIGGER_ONLY_ON_TARGET       = 0x00000002, // TITLE Only proc on self-cast
        SPELL_ATTR4_AURA_EXPIRES_OFFLINE               = 0x00000004, // TITLE Buff expires while offline DESCRIPTION Debuffs (except Resurrection Sickness) will automatically do this
        SPELL_ATTR4_NO_HELPFUL_THREAT                  = 0x00000008, // TITLE Unknown attribute 3@Attr4
        SPELL_ATTR4_NO_HARMFUL_THREAT                  = 0x00000010, // TITLE Treat as delayed spell DESCRIPTION This will no longer cause guards to attack on use??
        SPELL_ATTR4_ALLOW_CLIENT_TARGETING             = 0x00000020, // TITLE Unknown attribute 5@Attr4
        SPELL_ATTR4_CANNOT_BE_STOLEN                   = 0x00000040, // TITLE Aura cannot be stolen
        SPELL_ATTR4_ALLOW_CAST_WHILE_CASTING           = 0x00000080, // TITLE Can be cast while casting DESCRIPTION Ignores already in-progress cast and still casts
        SPELL_ATTR4_IGNORE_DAMAGE_TAKEN_MODIFIERS      = 0x00000100, // TITLE Deals fixed damage
        SPELL_ATTR4_COMBAT_FEEDBACK_WHEN_USABLE        = 0x00000200, // TITLE Spell is initially disabled (client only)
        SPELL_ATTR4_WEAPON_SPEED_COST_SCALING          = 0x00000400, // TITLE Attack speed modifies cost DESCRIPTION Adds 10 to power cost for each 1s of weapon speed
        SPELL_ATTR4_NO_PARTIAL_IMMUNITY                = 0x00000800, // TITLE Unknown attribute 11@Attr4
        SPELL_ATTR4_AURA_IS_BUFF                       = 0x00001000, // TITLE Unknown attribute 12@Attr4
        SPELL_ATTR4_DO_NOT_LOG_CASTER                  = 0x00002000, // TITLE Unknown attribute 13@Attr4
        SPELL_ATTR4_REACTIVE_DAMAGE_PROC               = 0x00004000, // TITLE Damage does not break auras
        SPELL_ATTR4_NOT_IN_SPELLBOOK                   = 0x00008000, // TITLE Unknown attribute 15@Attr4
        SPELL_ATTR4_NOT_IN_ARENA_OR_RATED_BATTLEGROUND = 0x00010000, // TITLE Not usable in arena DESCRIPTION Makes spell unusable despite CD <= 10min
        SPELL_ATTR4_IGNORE_DEFAULT_ARENA_RESTRICTIONS  = 0x00020000, // TITLE Usable in arena DESCRIPTION Makes spell usable despite CD > 10min
        SPELL_ATTR4_BOUNCY_CHAIN_MISSILES              = 0x00040000, // TITLE Chain area targets DESCRIPTION [NYI] Hits area targets over time instead of all at once
        SPELL_ATTR4_ALLOW_PROC_WHILE_SITTING           = 0x00080000, // TITLE Unknown attribute 19@Attr4 DESCRIPTION proc dalayed, after damage or don't proc on absorb?
        SPELL_ATTR4_AURA_NEVER_BOUNCES                 = 0x00100000, // TITLE Allow self-cast to override stronger aura (client only)
        SPELL_ATTR4_ALLOW_ENETRING_ARENA               = 0x00200000, // TITLE Keep when entering arena
        SPELL_ATTR4_PROC_SUPPRESS_SWING_ANIM           = 0x00400000, // TITLE Unknown attribute 22@Attr4 DESCRIPTION Seal of Command (42058,57770) and Gymer's Smash 55426
        SPELL_ATTR4_SUPRESS_WEAPON_PROCS               = 0x00800000, // TITLE Cannot trigger item spells
        SPELL_ATTR4_AUTO_RANGED_COMBAT                 = 0x01000000, // TITLE Unknown attribute 24@Attr4 DESCRIPTION Shoot-type spell?
        SPELL_ATTR4_OWNER_POWER_SCALING                = 0x02000000, // TITLE Pet Scaling aura
        SPELL_ATTR4_ONLY_FLYING_AREAS                  = 0x04000000, // TITLE Only in Outland/Northrend
        SPELL_ATTR4_FORCE_DISPLAY_CASTBAR              = 0x08000000, // TITLE Inherit critical chance from triggering aura
        SPELL_ATTR4_IGNORE_COMBAT_TIMERS               = 0x10000000, // TITLE Unknown attribute 28@Attr4 DESCRIPTION Aimed Shot
        SPELL_ATTR4_AURA_BOUNCE_FAILS_SPELL            = 0x20000000, // TITLE Unknown attribute 29@Attr4
        SPELL_ATTR4_OBSOLETE                           = 0x40000000, // TITLE Unknown attribute 30@Attr4
        SPELL_ATTR4_USE_FACING_FROM_SPELL              = 0x80000000  // TITLE Unknown attribute 31@Attr4 DESCRIPTION Polymorph (chicken) 228 and Sonic Boom (38052,38488)
    }

    [Flags]
    public enum SpellAtributeEx5 : uint
    {
        SPELL_ATTR5_ALL                                            = 0xFFFFFFFF,
        SPELL_ATTR5_NONE                                           = 0x00000000,
        SPELL_ATTR5_ALLOW_ACTION_DURING_CHANNEL                    = 0x00000001, // TITLE Can be channeled while moving
        SPELL_ATTR5_NO_REAGENT_COST_WITH_AURA                      = 0x00000002, // TITLE No reagents during arena preparation
        SPELL_ATTR5_REMOVE_ENTERING_ARENA                          = 0x00000004, // TITLE Remove when entering arena DESCRIPTION Force this aura to be removed on entering arena, regardless of other properties
        SPELL_ATTR5_ALLOW_WHILE_STUNNED                            = 0x00000008, // TITLE Usable while stunned
        SPELL_ATTR5_TRIGGERS_CHANNELING                            = 0x00000010, // TITLE Unknown attribute 4@Attr5
        SPELL_ATTR5_LIMIT_N                                        = 0x00000020, // TITLE Single-target aura DESCRIPTION Remove previous application to another unit if applied
        SPELL_ATTR5_IGNORE_AREA_EFFECT_PVP_CHECK                   = 0x00000040, // TITLE Unknown attribute 6@Attr5
        SPELL_ATTR5_NOT_ON_PLAYER                                  = 0x00000080, // TITLE Unknown attribute 7@Attr5
        SPELL_ATTR5_NOT_ON_PLAYER_CONTROLLED_NPC                   = 0x00000100, // TITLE Cannot target player controlled units but can target players
        SPELL_ATTR5_EXTRA_INITIAL_PERIOD                           = 0x00000200, // TITLE Immediately do periodic tick on apply
        SPELL_ATTR5_DO_NOT_DISPLAY_DURATION                        = 0x00000400, // TITLE Do not send aura duration to client
        SPELL_ATTR5_IMPLIED_TARGETING                              = 0x00000800, // TITLE Auto-target target of target (client only)
        SPELL_ATTR5_MELEE_CHAIN_TARGETING                          = 0x00001000, // TITLE Unknown attribute 12@Attr5 DESCRIPTION Cleave related?
        SPELL_ATTR5_SPELL_HASTE_AFFECTS_PERIODIC                   = 0x00002000, // TITLE Duration scales with Haste Rating
        SPELL_ATTR5_NOT_AVALIABLE_WHILE_CHARMED                    = 0x00004000, // TITLE Charmed units cannot cast this spell
        SPELL_ATTR5_TREAT_AS_AREA_EFFECT                           = 0x00008000, // TITLE Unknown attribute 15@Attr5 DESCRIPTION Related to multi-target spells?
        SPELL_ATTR5_AURA_AFFECTS_NOT_JUST_REQ_EQUIPED_ITEM         = 0x00010000, // TITLE DESCRIPTION this allows spells with EquippedItemClass to affect spells from other items if the required item is equipped
        SPELL_ATTR5_ALLOW_WHILE_FLEEING                            = 0x00020000, // TITLE Usable while feared
        SPELL_ATTR5_ALLOW_WHILE_CONFUSED                           = 0x00040000, // TITLE Usable while confused
        SPELL_ATTR5_AI_DOESNT_FACE_TARGET                          = 0x00080000, // TITLE Do not auto-turn while casting
        SPELL_ATTR5_DO_NOT_ATTEMPT_A_PET_RESUMMON_WHEN_DISMOUNTING = 0x00100000, // TITLE Unknown attribute 20@Attr5
        SPELL_ATTR5_IGNORE_TARGET_REQUIREMENTS                     = 0x00200000, // TITLE Unknown attribute 21@Attr5
        SPELL_ATTR5_NOT_ON_TRIVIAL                                 = 0x00400000, // TITLE Unknown attribute 22@Attr5
        SPELL_ATTR5_NO_PARTIAL_RESISTS                             = 0x00800000, // TITLE Unknown attribute 23@Attr5
        SPELL_ATTR5_IGNORE_CASTER_REQUIREMENETS                    = 0x01000000, // TITLE Unknown attribute 24@Attr5
        SPELL_ATTR5_ALWAYS_LINE_OF_SIGHT                           = 0x02000000, // TITLE Unknown attribute 25@Attr5
        SPELL_ATTR5_ALWAYS_AOE_LINE_OF_SIGHT                       = 0x04000000, // TITLE Ignore line of sight checks
        SPELL_ATTR5_NO_CASTER_AURA_ICON                            = 0x08000000, // TITLE Don't show aura if self-cast (client only)
        SPELL_ATTR5_NO_TARGET_AURA_ICON                            = 0x10000000, // TITLE Don't show aura unless self-cast (client only)
        SPELL_ATTR5_AURA_UNIQUE_PER_CASTER                         = 0x20000000, // TITLE Unknown attribute 29@Attr5
        SPELL_ATTR5_ALWAYS_SHOW_GROUND_TEXTURE                     = 0x40000000, // TITLE Unknown attribute 30@Attr5
        SPELL_ATTR5_ADD_MELEE_HIT_RATING                           = 0x80000000  // TITLE Unknown attribute 31@Attr5 DESCRIPTION Forces nearby enemies to attack caster?
    }

    [Flags]
    public enum SpellAtributeEx6 : uint
    {
        SPELL_ATTR6_ALL                                        = 0xFFFFFFFF,
        SPELL_ATTR6_NONE                                       = 0x00000000,
        SPELL_ATTR6_NO_COOLDOWN_ON_TOOLTIP                     = 0x00000001, // TITLE Don't display cooldown (client only)
        SPELL_ATTR6_DO_NOT_RESET_COOLDOWN_IN_ARENA             = 0x00000002, // TITLE Only usable in arena
        SPELL_ATTR6_NOT_AN_ATTACK                              = 0x00000004, // TITLE Ignore all preventing caster auras
        SPELL_ATTR6_CAN_ASSIST_IMMUNE_PC                       = 0x00000008, // TITLE Ignore immunity flags when assisting
        SPELL_ATTR6_IGNORE_FOR_MOD_TIME_RATE                   = 0x00000010, // TITLE Unknown attribute 4@Attr6
        SPELL_ATTR6_DO_NOT_CONSUME_RESOURCES                   = 0x00000020, // TITLE Don't consume proc charges
        SPELL_ATTR6_FLOATING_COMBAT_TEXT_ON_CAST               = 0x00000040, // TITLE Generate spell_cast event instead of aura_start (client only)
        SPELL_ATTR6_AURA_IS_WEAPON_PROC                        = 0x00000080, // TITLE Unknown attribute 7@Attr6
        SPELL_ATTR6_DO_NOT_CHAIN_TO_CROWD_CONTROLLED_TARGETS   = 0x00000100, // TITLE Do not implicitly target in CC DESCRIPTION Implicit targeting (chaining and area targeting) will not impact crowd controlled targets
        SPELL_ATTR6_ALLOW_ON_CHARMED_TARGETS                   = 0x00000200, // TITLE Unknown attribute 9@Attr6
        SPELL_ATTR6_NO_AURA_LOG                                = 0x00000400, // TITLE Can target possessed friends DESCRIPTION [NYI]
        SPELL_ATTR6_NOT_IN_RAID_INSTANCES                      = 0x00000800, // TITLE Unusable in raid instances
        SPELL_ATTR6_ALLOW_WHILE_RIDING_VEHICLE                 = 0x00001000, // TITLE Castable while caster is on vehicle
        SPELL_ATTR6_IGNORE_PHASE_SHIFT                         = 0x00002000, // TITLE Can target invisible units
        SPELL_ATTR6_AI_PRIMARY_RANGED_ATTACK                   = 0x00004000, // TITLE Unknown attribute 14@Attr6
        SPELL_ATTR6_NO_PUSHBACK                                = 0x00008000, // TITLE Unknown attribute 15@Attr6 DESCRIPTION only 54368, 67892
        SPELL_ATTR6_NO_JUMP_PATHING                            = 0x00010000, // TITLE Unknown attribute 16@Attr6
        SPELL_ATTR6_ALLOW_EQUIP_WHILE_CASTING                  = 0x00020000, // TITLE Unknown attribute 17@Attr6 DESCRIPTION Mount related?
        SPELL_ATTR6_ORIGINATE_FROM_CONTROLLER                  = 0x00040000, // TITLE Spell is cast by charmer DESCRIPTION Client will prevent casting if not possessed, charmer will be caster for all intents and purposes
        SPELL_ATTR6_DELAY_COMBAT_TIMER_DURING_CAST             = 0x00080000, // TITLE Unknown attribute 19@Attr6 DESCRIPTION only 47488, 50782
        SPELL_ATTR6_AURA_ICON_ONLY_FOR_CASTER                  = 0x00100000, // TITLE Only visible to caster (client only) (LIMIT 10)
        SPELL_ATTR6_SHOW_MECHANIC_AS_COMBAT_TEXT               = 0x00200000, // TITLE Client UI target effects (client only)
        SPELL_ATTR6_ABSORB_CANNOT_BE_IGNORED                   = 0x00400000, // TITLE Unknown attribute 22@Attr6 DESCRIPTION only 72054
        SPELL_ATTR6_TAPS_IMMEDIATELY                           = 0x00800000, // TITLE Unknown attribute 23@Attr6
        SPELL_ATTR6_CAN_TARGET_UNTARGETABLE                    = 0x01000000, // TITLE Can target untargetable units
        SPELL_ATTR6_DOESNT_RESET_SWING_TIMER_IF_INSTANT        = 0x02000000, // TITLE Do not reset swing timer if cast time is instant
        SPELL_ATTR6_VEHICLE_IMMUNITY_CATEGORY                  = 0x04000000, // TITLE Unknown attribute 26@Attr6 DESCRIPTION Player castable buff?
        SPELL_ATTR6_IGNORE_HEALTH_MODIFIERS                    = 0x08000000, // TITLE Limit applicable %healing modifiers DESCRIPTION This prevents certain healing modifiers from applying - see implementation if you really care about details
        SPELL_ATTR6_DO_NOT_SELECT_TARGET_WITH_INITIATES_COMBAT = 0x10000000, // TITLE Unknown attribute 28@Attr6 DESCRIPTION Death grip?
        SPELL_ATTR6_IGNORE_CASTER_DAMAGE_MODIFIERS             = 0x20000000, // TITLE Limit applicable %damage modifiers DESCRIPTION This prevents certain damage modifiers from applying - see implementation if you really care about details
        SPELL_ATTR6_DISABLE_TIED_EFFECT_POINTS                 = 0x40000000, // TITLE Unknown attribute 30@Attr6
        SPELL_ATTR6_NO_CATEGORY_COOLDOWN_MODS                  = 0x80000000  // TITLE Ignore cooldown modifiers for category cooldown
    }

    [Flags]
    public enum SpellAtributeEx7 : uint
    {
        SPELL_ATTR7_ALL                                           = 0xFFFFFFFF,
        SPELL_ATTR7_NONE                                          = 0x00000000,
        SPELL_ATTR7_ALLOW_SPELL_REFLECTION                        = 0x00000001, // TITLE Unknown attribute 0@Attr7 DESCRIPTION Shaman's new spells (Call of the ...), Feign Death.
        SPELL_ATTR7_NO_TARGET_DURATION_MOD                        = 0x00000002, // TITLE Ignore duration modifiers
        SPELL_ATTR7_DISABLE_AURA_WHILE_DEAD                       = 0x00000004, // TITLE Reactivate at resurrect (client only)
        SPELL_ATTR7_DEBUG_SPELL                                   = 0x00000008, // TITLE Is cheat spell DESCRIPTION Cannot cast if caster doesn't have UnitFlag2 & UNIT_FLAG2_ALLOW_CHEAT_SPELLS
        SPELL_ATTR7_TREAT_AS_RAID_BUFF                            = 0x00000010, // TITLE Unknown attribute 4@Attr7 DESCRIPTION Soulstone related?
        SPELL_ATTR7_CAN_BE_MULTI_CAST                             = 0x00000020, // TITLE Summons player-owned totem
        SPELL_ATTR7_DONT_CAUSE_SPELL_PUSHBACK                     = 0x00000040, // TITLE Damage dealt by this does not cause spell pushback
        SPELL_ATTR7_PREPARE_FOR_VEHICLE_CONTROL_END               = 0x00000080, // TITLE Unknown attribute 7@Attr7 DESCRIPTION 66218 (Launch) spell.
        SPELL_ATTR7_HORDE_SPECIFIC_SPELL                          = 0x00000100, // TITLE Horde only
        SPELL_ATTR7_ALLIANCE_SPECIFIC_SPELL                       = 0x00000200, // TITLE Alliance only
        SPELL_ATTR7_DISPEL_REMOVES_CHARGES                        = 0x00000400, // TITLE Dispel/Spellsteal remove individual charges
        SPELL_ATTR7_CAN_CAUSE_INTERRUPT                           = 0x00000800, // TITLE Only interrupt non-player casting
        SPELL_ATTR7_CAN_CAUSE_SILENCE                             = 0x00001000, // TITLE Unknown attribute 12@Attr7 DESCRIPTION Not set in 3.2.2a.
        SPELL_ATTR7_NO_UI_NOT_INTERRUPTIBLE                       = 0x00002000, // TITLE Unknown attribute 13@Attr7 DESCRIPTION Not set in 3.2.2a.
        SPELL_ATTR7_RECAST_ON_RESUMMON                            = 0x00004000, // TITLE Unknown attribute 14@Attr7 DESCRIPTION Only 52150 (Raise Dead - Pet) spell.
        SPELL_ATTR7_RESET_SWING_TIMER_AT_SPELL_START              = 0x00008000, // TITLE Unknown attribute 15@Attr7 DESCRIPTION Exorcism - guaranteed crit vs families?
        SPELL_ATTR7_ONLY_IN_SPELLBOOK_UNTIL_LEARNED               = 0x00010000, // TITLE Can restore secondary power DESCRIPTION Only spells with this attribute can replenish a non-active power type
        SPELL_ATTR7_DO_NOT_LOG_PVP_KILL                           = 0x00020000, // TITLE Unknown attribute 17@Attr7 DESCRIPTION Only 27965 (Suicide) spell.
        SPELL_ATTR7_ATTACK_ON_CHARGE_TO_UNIT                      = 0x00040000, // TITLE Has charge effect
        SPELL_ATTR7_REPORT_SPELL_FAILURE_TO_UNIT_TARGET           = 0x00080000, // TITLE Is zone teleport
        SPELL_ATTR7_NO_CLIENT_FAIL_WHILE_STUNNED_FLEEING_CONFUSED = 0x00100000, // TITLE Unknown attribute 20@Attr7 DESCRIPTION Invulnerability related?
        SPELL_ATTR7_RETAIN_COOLDOWN_THROUGH_LOAD                  = 0x00200000, // TITLE Unknown attribute 21@Attr7
        SPELL_ATTR7_IGNORES_COLD_WEATHER_FLYING_REQUIREMENT       = 0x00400000, // TITLE Ignore cold weather flying restriction DESCRIPTION Set for loaner mounts, allows them to be used despite lacking required flight skill
        SPELL_ATTR7_NO_ATTACK_DODGE                               = 0x00800000, // TITLE Unknown attribute 23@Attr7 DESCRIPTION Motivate, Mutilate, Shattering Throw
        SPELL_ATTR7_NO_ATTACK_PARRY                               = 0x01000000, // TITLE Unknown attribute 24@Attr7 DESCRIPTION Motivate, Mutilate, Perform Speech, Shattering Throw
        SPELL_ATTR7_NO_ATTACK_MISS                                = 0x02000000, // TITLE Unknown attribute 25@Attr7
        SPELL_ATTR7_TREAT_AS_NPC_AOE                              = 0x04000000, // TITLE Unknown attribute 26@Attr7
        SPELL_ATTR7_BYPASS_NO_RESSURECTION_AURA                   = 0x08000000, // TITLE Unknown attribute 27@Attr7
        SPELL_ATTR7_DO_NOT_COUNT_FOR_PVP_SCOREBOARD               = 0x10000000, // TITLE Consolidate in raid buff frame (client only)
        SPELL_ATTR7_REFLECTION_ONLY_DEFENDS                       = 0x20000000, // TITLE Unknown attribute 29@Attr7 DESCRIPTION only 69028, 71237
        SPELL_ATTR7_CAN_PROC_FROM_SUPPRESSED_TARGET_PROCS         = 0x40000000, // TITLE Unknown attribute 30@Attr7 DESCRIPTION Burning Determination, Divine Sacrifice, Earth Shield, Prayer of Mending
        SPELL_ATTR7_ALWAYS_CAST_LOG                               = 0x80000000  // TITLE Client indicator (client only)
    }

    [Flags]
    public enum CombatRating
    {
        CR_WEAPON_SKILL             = 1 << 0x00,
        CR_DEFENSE_SKILL            = 1 << 0x01,
        CR_DODGE                    = 1 << 0x02,
        CR_PARRY                    = 1 << 0x03,
        CR_BLOCK                    = 1 << 0x04,
        CR_HIT_MELEE                = 1 << 0x05,
        CR_HIT_RANGED               = 1 << 0x06,
        CR_HIT_SPELL                = 1 << 0x07,
        CR_CRIT_MELEE               = 1 << 0x08,
        CR_CRIT_RANGED              = 1 << 0x09,
        CR_CRIT_SPELL               = 1 << 0x0A,
        CR_HIT_TAKEN_MELEE          = 1 << 0x0B,
        CR_HIT_TAKEN_RANGED         = 1 << 0x0C,
        CR_HIT_TAKEN_SPELL          = 1 << 0x0D,
        CR_CRIT_TAKEN_MELEE         = 1 << 0x0E,
        CR_CRIT_TAKEN_RANGED        = 1 << 0x0F,
        CR_CRIT_TAKEN_SPELL         = 1 << 0x10,
        CR_HASTE_MELEE              = 1 << 0x11,
        CR_HASTE_RANGED             = 1 << 0x12,
        CR_HASTE_SPELL              = 1 << 0x13,
        CR_WEAPON_SKILL_MAINHAND    = 1 << 0x14,
        CR_WEAPON_SKILL_OFFHAND     = 1 << 0x15,
        CR_WEAPON_SKILL_RANGED      = 1 << 0x16,
        CR_EXPERTISE                = 1 << 0x17,
        CR_ARMOR_PENETRATION        = 1 << 0x18,
    }

    public enum UnitMods
    {
        UNIT_MOD_STAT_STRENGTH          = 0,                  // UNIT_MOD_STAT_STRENGTH..UNIT_MOD_STAT_SPIRIT must be in existed order, it's accessed by index values of Stats enum.
        UNIT_MOD_STAT_AGILITY           = 1,
        UNIT_MOD_STAT_STAMINA           = 2,
        UNIT_MOD_STAT_INTELLECT         = 3,
        UNIT_MOD_STAT_SPIRIT            = 4,
        UNIT_MOD_HEALTH                 = 5,
        UNIT_MOD_MANA                   = 6,                  // UNIT_MOD_MANA..UNIT_MOD_RUNIC_POWER must be in existed order, it's accessed by index values of Powers enum.
        UNIT_MOD_RAGE                   = 7,
        UNIT_MOD_FOCUS                  = 8,
        UNIT_MOD_ENERGY                 = 9,
        UNIT_MOD_HAPPINESS              = 10,
        UNIT_MOD_RUNE                   = 11,
        UNIT_MOD_RUNIC_POWER            = 12,
        UNIT_MOD_ARMOR                  = 13,                 // UNIT_MOD_ARMOR..UNIT_MOD_RESISTANCE_ARCANE must be in existed order, it's accessed by index values of SpellSchools enum.
        UNIT_MOD_RESISTANCE_HOLY        = 14,
        UNIT_MOD_RESISTANCE_FIRE        = 15,
        UNIT_MOD_RESISTANCE_NATURE      = 16,
        UNIT_MOD_RESISTANCE_FROST       = 17,
        UNIT_MOD_RESISTANCE_SHADOW      = 18,
        UNIT_MOD_RESISTANCE_ARCANE      = 19,
        UNIT_MOD_ATTACK_POWER           = 20,
        UNIT_MOD_ATTACK_POWER_RANGED    = 21,
        UNIT_MOD_DAMAGE_MAINHAND        = 22,
        UNIT_MOD_DAMAGE_OFFHAND         = 23,
        UNIT_MOD_DAMAGE_RANGED          = 24,
        UNIT_MOD_END                    = 25,
        // synonyms
        UNIT_MOD_STAT_START             = UNIT_MOD_STAT_STRENGTH,
        UNIT_MOD_STAT_END               = UNIT_MOD_STAT_SPIRIT       + 1,
        UNIT_MOD_RESISTANCE_START       = UNIT_MOD_ARMOR,
        UNIT_MOD_RESISTANCE_END         = UNIT_MOD_RESISTANCE_ARCANE + 1,
        UNIT_MOD_POWER_START            = UNIT_MOD_MANA,
        UNIT_MOD_POWER_END              = UNIT_MOD_RUNIC_POWER       + 1,
    }

    enum GameObjectActions
    {
                                        // Name from client executable      // Comments
        None,                           // -NONE-
        AnimateCustom0,                 // Animate Custom0
        AnimateCustom1,                 // Animate Custom1
        AnimateCustom2,                 // Animate Custom2
        AnimateCustom3,                 // Animate Custom3
        Disturb,                        // Disturb                          // Triggers trap
        Unlock,                         // Unlock                           // Resets GO_FLAG_LOCKED
        Lock,                           // Lock                             // Sets GO_FLAG_LOCKED
        Open,                           // Open                             // Sets GO_STATE_ACTIVE
        OpenAndUnlock,                  // Open + Unlock                    // Sets GO_STATE_ACTIVE and resets GO_FLAG_LOCKED
        Close,                          // Close                            // Sets GO_STATE_READY
        ToggleOpen,                     // Toggle Open
        Destroy,                        // Destroy                          // Sets GO_STATE_DESTROYED
        Rebuild,                        // Rebuild                          // Resets from GO_STATE_DESTROYED
        Creation,                       // Creation
        Despawn,                        // Despawn
        MakeInert,                      // Make Inert                       // Disables interactions
        MakeActive,                     // Make Active                      // Enables interactions
        CloseAndLock,                   // Close + Lock                     // Sets GO_STATE_READY and sets GO_FLAG_LOCKED
        UseArtKit0,                     // Use ArtKit0                      // 46904: 121
        UseArtKit1,                     // Use ArtKit1                      // 36639: 81, 46903: 122
        UseArtKit2,                     // Use ArtKit2
        UseArtKit3,                     // Use ArtKit3
        SetTapList,                     // Set Tap List
    }

// ReSharper restore InconsistentNaming

    public class SpellEnums
    {
        #region ProcFlagDesc

        public static readonly string[] ProcFlagDesc =
        {
            //00 0x00000001 000000000000000000000001 -
            "Killed by aggressor that receive experience or honor",
            //01 0x00000002 000000000000000000000010 -
            "Kill that yields experience or honor",

            //02 0x00000004 000000000000000000000100 -
            "Successful melee attack",
            //03 0x00000008 000000000000000000001000 -
            "Taken damage from melee strike hit",

            //04 0x00000010 000000000000000000010000 -
            "Successful attack by Spell that use melee weapon",
            //05 0x00000020 000000000000000000100000 -
            "Taken damage by Spell that use melee weapon",

            //06 0x00000040 000000000000000001000000 -
            "Successful Ranged attack(and wand spell cast)",
            //07 0x00000080 000000000000000010000000 -
            "Taken damage from ranged attack",

            //08 0x00000100 000000000000000100000000 -
            "Successful Ranged attack by Spell that use ranged weapon",
            //09 0x00000200 000000000000001000000000 -
            "Taken damage by Spell that use ranged weapon",

            //10 0x00000400 000000000000010000000000 -
            "Successful positive spell hit",
            //11 0x00000800 000000000000100000000000 -
            "Taken positive spell hit",

            //12 0x00001000 000000000001000000000000 -
            "Successful negative spell cast",
            //13 0x00002000 000000000010000000000000 -
            "Taken negative spell hit",

            //14 0x00004000 000000000100000000000000 -
            "Successful cast positive magic spell",
            //15 0x00008000 000000001000000000000000 -
            "Taken positive magic spell hit",

            //16 0x00010000 000000010000000000000000 -
            "Successful damage from harmful magic spell cast",
            //17 0x00020000 000000100000000000000000 -
            "Taken magic spell damage",

            //18 0x00040000 000001000000000000000000 -
            "Deal periodic damage",
            //19 0x00080000 000010000000000000000000 -
            "Taken periodic damage",

            //20 0x00100000 000100000000000000000000 -
            "Taken any damage",
            //21 0x00200000 001000000000000000000000 -
            "On trap activation",

            //22 0x00800000 010000000000000000000000 -
            "Successful main-hand melee attacks",
            //23 0x00800000 100000000000000000000000 -
            "Successful off-hand melee attacks",

            //24 0x01000000
            "On death",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"
        };
        #endregion
    }
}
