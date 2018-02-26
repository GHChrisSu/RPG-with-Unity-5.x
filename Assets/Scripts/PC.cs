using System;
[Serializable]
public class PC : BaseCharacter
{
    public enum SHOULDER_PAD
    {
        none = 0,
        SP01 = 1,
        SP02 = 2,
        SP03 = 3,
        SP04 = 4
    };
    public enum BODY_TYPE { normal = 1, BT01 = 2, BT02 = 3 };
    // Shoulder Pad
    public SHOULDER_PAD selectedShoulderPad = SHOULDER_PAD.none;
    public BODY_TYPE selectedBodyType = BODY_TYPE.normal;
    public bool kneePad = false;
    public bool legPlate = false;
    public enum WEAPON_TYPE
    {
        none = 0,
        axe1 = 1,
        axe2 = 2,
        club1 = 3,
        club2 = 4,
        falchion = 5,
        gladius = 6,
        mace = 7,
        maul = 8,
        scimitar = 9,
        spear = 10,
        sword1 = 11,
        sword2 = 12,
        sword3 = 13
    };
    public WEAPON_TYPE selectedWeapon = WEAPON_TYPE.none;
    public enum HELMET_TYPE
    {
        none = 0, HL01 = 1, HL02 = 2, HL03 = 3, HL04 =
4
    };
    public HELMET_TYPE selectedHelmet = HELMET_TYPE.none;
    public enum SHIELD_TYPE { none = 0, SL01 = 1, SL02 = 2 };
    public SHIELD_TYPE selectedShield = SHIELD_TYPE.none;
    public int SKIN_ID = 1;
    public enum BOOT_TYPE { none = 0, BT01 = 1, BT02 = 2 };
    public BOOT_TYPE selectedBoot = BOOT_TYPE.none;
}
