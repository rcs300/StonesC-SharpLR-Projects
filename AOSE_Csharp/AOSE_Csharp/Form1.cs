using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOSE_Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        // %-Key used to determin how much points trickledown to the skill that is based on points
        // spent on one or more ability that it is dependant on - in this case i use one skill
        // that is dependant on one ability therefore i only need one percentKey for now
        private double percentKey10 = 0.025;
        private double percentKey20 = 0.05;
        private double percentKey30 = 0.075;
        private double percentKey40 = 0.1;
        private double percentKey50 = 0.125;
        private double percentKey60 = 0.15;
        private double percentKey70 = 0.175;
        private double percentKey80 = 0.2;
        private double percentKey100 = 0.25;
        // these two sets are user input for abilities 'named after the collum in spreadsheet they represent
        public double nakStr;
        public double nakAgi;
        public double nakStm; // B-base (nak)abilities
        public double nakInt;
        public double nakSen;
        public double nakPsy;
        
        public double addedStr;
        public double addedAgi;
        public double addedStm; // O-added abilities
        public double addedInt;
        public double addedSen;
        public double addedPsy;        

        private double startingPointsAbilities = 6; // ability point character starts with
        private double startingPointsSkills = 4; // skill points character starts with

        // IP Points spent on abillities - used to get total abiliy points
        private double spentIPStr;
        private double spentIPAgi;
        private double spentIPStm; // F-ability = nakAbillity - startingAbilityPoints
        private double spentIPInt;
        private double spentIPSen;
        private double spentIPPsy;

        // these two large sets of skills will be User Input also
        public double nakBdyDev; // O-abilities - BODY
        public double nakNanoPool;
        public double nakEvadeClsCombat;
        public double nakDodgeRanged;
        public double nakDuckExpl;
        public double nakNanoResist;
        public double nakParry;
        public double nak1HB; // MELEE WEAPONS
        public double nak1HE;
        public double nakPiercing;
        public double nak2HB;
        public double nak2HE;
        public double nakMeleeEnergy;
        public double nakMartialArts;
        public double nakMultiMelee;
        public double nakMeleeInit;
        public double nakPhysicalInit;
        public double nakSneakAttack; // MELEE SPECIAL
        public double nakBrawl;
        public double nakFastAttack;
        public double nakDimach;
        public double nakRipost;
        public double nakPistol; // RANGED WEAPON
        public double nakBow;
        public double nakSubMachineGun;
        public double nakAssultRifle;
        public double nakShotgun;
        public double nakRifle;
        public double nakRangedEnergy;
        public double nakGrenade;
        public double nakHeavyWeapons;
        public double nakMultiRanged;
        public double nakRangedInit;
        public double nakFlingShot; // RANGED SPECIAL
        public double nakAimedShot;
        public double nakBurst;
        public double nakFullAuto;
        public double nakBowSpcAtk;
        public double nakSharpObjects;
        public double nakMaterMet; // NANO & AIDING
        public double nakBioMet;
        public double nakPsychoMod;
        public double nakSenseImp;
        public double nakTimeSpace;
        public double nakMaterCrea;
        public double nakNanoCInit;
        public double nakVehAir; // EXPLORING
        public double nakVehGround;
        public double nakVehWater;
        public double nakAdventuring;
        public double nakRunSpeed;
        public double nakPerception; // COMBAT & HEALING
        public double nakConcealment;
        public double nakPsychology;
        public double nakTrapDisarm;
        public double nakFirstAid;
        public double nakTreatment;
        public double nakMechanicalEng; // TRADE & REPAIR
        public double nakElectricalEng;
        public double nakFieldQuantumPhy;
        public double nakChemestry;
        public double nakWeaponSmithing;
        public double nakNanoProgramming;
        public double nakTutoring;
        public double nakBreakingEntering;
        public double nakComputerLiteracy;
        public double nakPharma;
        public double nakSwim; // OLD - REMOVED from game
        public double nakMapNav;        

        public double addedBdyDev; // O-skills - BODY
        public double addedNanoPool;
        public double addedEvadeClsCombat;
        public double addedDodgeRanged;
        public double addedDuckExpl;
        public double addedNanoResist;
        public double addedParry;
        public double added1HB; // MELEE WEAPONS
        public double added1HE;
        public double addedPiercing;
        public double added2HB;
        public double added2HE;
        public double addedMeleeEnergy;
        public double addedMartialArts;
        public double addedMultiMelee;
        public double addedMeleeInit;
        public double addedPhysicalInit;
        public double addedSneakAttack; // MELEE SPECIAL
        public double addedBrawl;
        public double addedFastAttack;
        public double addedDimach;
        public double addedRipost;
        public double addedPistol; // RANGED WEAPON
        public double addedBow;
        public double addedSubMachineGun;
        public double addedAssultRifle;
        public double addedShotgun;
        public double addedRifle;
        public double addedRangedEnergy;
        public double addedGrenade;
        public double addedHeavyWeapons;
        public double addedMultiRanged;
        public double addedRangedInit;
        public double addedFlingShot; // RANGED SPECIAL
        public double addedAimedShot;
        public double addedBurst;
        public double addedFullAuto;
        public double addedBowSpcAtk;
        public double addedSharpObjects;
        public double addedMaterMet; // NANO & AIDING
        public double addedBioMet;
        public double addedPsychoMod;
        public double addedSenseImp;
        public double addedTimeSpace;
        public double addedMaterCrea;
        public double addedNanoCInit;
        public double addedVehAir; // EXPLORING
        public double addedVehGround;
        public double addedVehWater;
        public double addedAdventuring;
        public double addedRunSpeed;
        public double addedPerception; // COMBAT & HEALING
        public double addedConcealment;
        public double addedPsychology;
        public double addedTrapDisarm;
        public double addedFirstAid;
        public double addedTreatment;
        public double addedMechanicalEng; // TRADE & REPAIR
        public double addedElectricalEng;
        public double addedFieldQuantumPhy;
        public double addedChemestry;
        public double addedWeaponSmithing;
        public double addedNanoProgramming;
        public double addedTutoring;
        public double addedBreakingEntering;
        public double addedComputerLiteracy;
        public double addedPharma;
        public double addedSwim; // OLD - REMOVED from game
        public double addedMapNav;

        // This is the total ability points including nakability, addedonlytrickledown, and addedability
        public double totalStr;
        public double totalAgi;
        public double totalStm; // G-totalAbility  = F-spentIPAbility + startingPointsAbilities + O-addedAbility
        public double totalInt;
        public double totalSen;
        public double totalPsy;

        // C-nakTrickledown and Collumn D-totalTrickledown will be used for trickledown calculations effected by nakAbilities
        private double nakTrickleBdyDev; // BODY | C-nakTrickle = percentKey100 * nakAbility
        private double nakTrickleNanoPool;
        private double nakTrickleEvadeClsCombat;
        private double nakTrickleDodgeRanged;
        private double nakTrickleDuckExpl;
        private double nakTrickleNanoResist;
        private double nakTrickleParry;
        private double nakTrickle1HB; // MELEE WEAPONS
        private double nakTrickle1HE;
        private double nakTricklePiercing;
        private double nakTrickle2HB;
        private double nakTrickle2HE;
        private double nakTrickleMeleeEnergy;
        private double nakTrickleMartialArts;
        private double nakTrickleMultiMelee;
        private double nakTrickleMeleeInit;
        private double nakTricklePhysicalInit;
        private double nakTrickleSneakAttack; // MELEE SPECIAL
        private double nakTrickleBrawl;
        private double nakTrickleFastAttack;
        private double nakTrickleDimach;
        private double nakTrickleRipost;
        private double nakTricklePistol; // RANGED WEAPON
        private double nakTrickleBow;
        private double nakTrickleSubMachineGun;
        private double nakTrickleAssultRifle;
        private double nakTrickleShotgun;
        private double nakTrickleRifle;
        private double nakTrickleRangedEnergy;
        private double nakTrickleGrenade;
        private double nakTrickleHeavyWeapons;
        private double nakTrickleMultiRanged;
        private double nakTrickleRangedInit;
        private double nakTrickleFlingShot; // RANGED SPECIAL
        private double nakTrickleAimedShot;
        private double nakTrickleBurst;
        private double nakTrickleFullAuto;
        private double nakTrickleBowSpcAtk;
        private double nakTrickleSharpObjects;
        private double nakTrickleMaterMet; // NANO & AIDING
        private double nakTrickleBioMet;
        private double nakTricklePsychoMod;
        private double nakTrickleSenseImp;
        private double nakTrickleTimeSpace;
        private double nakTrickleMaterCrea;
        private double nakTrickleNanoCInit;
        private double nakTrickleVehAir; // EXPLORING
        private double nakTrickleVehGround;
        private double nakTrickleVehWater;
        private double nakTrickleAdventuring;
        private double nakTrickleRunSpeed;
        private double nakTricklePerception; // COMBAT & HEALING
        private double nakTrickleConcealment;
        private double nakTricklePsychology;
        private double nakTrickleTrapDisarm;
        private double nakTrickleFirstAid;
        private double nakTrickleTreatment;
        private double nakTrickleMechanicalEng; // TRADE & REPAIR
        private double nakTrickleElectricalEng;
        private double nakTrickleFieldQuantumPhy;
        private double nakTrickleChemestry;
        private double nakTrickleWeaponSmithing;
        private double nakTrickleNanoProgramming;
        private double nakTrickleTutoring;
        private double nakTrickleBreakingEntering;
        private double nakTrickleComputerLiteracy;
        private double nakTricklePharma;
        private double nakTrickleSwim; // OLD - REMOVED from game
        private double nakTrickleMapNav;

        private double totalTrickleBdyDev; // D-totalTrickle = percentKey100 * totalAbility
        private double totalTrickleNanoPool;
        private double totalTrickleEvadeClsCombat;
        private double totalTrickleDodgeRanged;
        private double totalTrickleDuckExpl;
        private double totalTrickleNanoResist;
        private double totalTrickleParry;
        private double totalTrickle1HB; // MELEE WEAPONS
        private double totalTrickle1HE;
        private double totalTricklePiercing;
        private double totalTrickle2HB;
        private double totalTrickle2HE;
        private double totalTrickleMeleeEnergy;
        private double totalTrickleMartialArts;
        private double totalTrickleMultiMelee;
        private double totalTrickleMeleeInit;
        private double totalTricklePhysicalInit;
        private double totalTrickleSneakAttack; // MELEE SPECIAL
        private double totalTrickleBrawl;
        private double totalTrickleFastAttack;
        private double totalTrickleDimach;
        private double totalTrickleRipost;
        private double totalTricklePistol; // RANGED WEAPON
        private double totalTrickleBow;
        private double totalTrickleSubMachineGun;
        private double totalTrickleAssultRifle;
        private double totalTrickleShotgun;
        private double totalTrickleRifle;
        private double totalTrickleRangedEnergy;
        private double totalTrickleGrenade;
        private double totalTrickleHeavyWeapons;
        private double totalTrickleMultiRanged;
        private double totalTrickleRangedInit;
        private double totalTrickleFlingShot; // RANGED SPECIAL
        private double totalTrickleAimedShot;
        private double totalTrickleBurst;
        private double totalTrickleFullAuto;
        private double totalTrickleBowSpcAtk;
        private double totalTrickleSharpObjects;
        private double totalTrickleMaterMet; // NANO & AIDING
        private double totalTrickleBioMet;
        private double totalTricklePsychoMod;
        private double totalTrickleSenseImp;
        private double totalTrickleTimeSpace;
        private double totalTrickleMaterCrea;
        private double totalTrickleNanoCInit;
        private double totalTrickleVehAir; // EXPLORING
        private double totalTrickleVehGround;
        private double totalTrickleVehWater;
        private double totalTrickleAdventuring;
        private double totalTrickleRunSpeed;
        private double totalTricklePerception; // COMBAT & HEALING
        private double totalTrickleConcealment;
        private double totalTricklePsychology;
        private double totalTrickleTrapDisarm;
        private double totalTrickleFirstAid;
        private double totalTrickleTreatment;
        private double totalTrickleMechanicalEng; // TRADE & REPAIR
        private double totalTrickleElectricalEng;
        private double totalTrickleFieldQuantumPhy;
        private double totalTrickleChemestry;
        private double totalTrickleWeaponSmithing;
        private double totalTrickleNanoProgramming;
        private double totalTrickleTutoring;
        private double totalTrickleBreakingEntering;
        private double totalTrickleComputerLiteracy;
        private double totalTricklePharma;
        private double totalTrickleSwim; // OLD - REMOVED from game
        private double totalTrickleMapNav;

        private double trickleAddedAbiOnlyBdyDev; // Trickledown calculated from added abilities only for each of these skills
        private double trickleAddedAbiOnlyNanoPool; // E-addedonlyTrickleSkill = D-totalTrickle - C-nakTrickle
        private double trickleAddedAbiOnlyEvadeClsCombat;
        private double trickleAddedAbiOnlyDodgeRanged;
        private double trickleAddedAbiOnlyDuckExpl;
        private double trickleAddedAbiOnlyNanoResist;
        private double trickleAddedAbiOnlyParry;
        private double trickleAddedAbiOnly1HB; // MELEE WEAPONS
        private double trickleAddedAbiOnly1HE;
        private double trickleAddedAbiOnlyPiercing;
        private double trickleAddedAbiOnly2HB;
        private double trickleAddedAbiOnly2HE;
        private double trickleAddedAbiOnlyMeleeEnergy;
        private double trickleAddedAbiOnlyMartialArts;
        private double trickleAddedAbiOnlyMultiMelee;
        private double trickleAddedAbiOnlyMeleeInit;
        private double trickleAddedAbiOnlyPhysicalInit;
        private double trickleAddedAbiOnlySneakAttack; // MELEE SPECIAL
        private double trickleAddedAbiOnlyBrawl;
        private double trickleAddedAbiOnlyFastAttack;
        private double trickleAddedAbiOnlyDimach;
        private double trickleAddedAbiOnlyRipost;
        private double trickleAddedAbiOnlyPistol; // RANGED WEAPON
        private double trickleAddedAbiOnlyBow;
        private double trickleAddedAbiOnlySubMachineGun;
        private double trickleAddedAbiOnlyAssultRifle;
        private double trickleAddedAbiOnlyShotgun;
        private double trickleAddedAbiOnlyRifle;
        private double trickleAddedAbiOnlyRangedEnergy;
        private double trickleAddedAbiOnlyGrenade;
        private double trickleAddedAbiOnlyHeavyWeapons;
        private double trickleAddedAbiOnlyMultiRanged;
        private double trickleAddedAbiOnlyRangedInit;
        private double trickleAddedAbiOnlyFlingShot; // RANGED SPECIAL
        private double trickleAddedAbiOnlyAimedShot;
        private double trickleAddedAbiOnlyBurst;
        private double trickleAddedAbiOnlyFullAuto;
        private double trickleAddedAbiOnlyBowSpcAtk;
        private double trickleAddedAbiOnlySharpObjects;
        private double trickleAddedAbiOnlyMaterMet; // NANO & AIDING
        private double trickleAddedAbiOnlyBioMet;
        private double trickleAddedAbiOnlyPsychoMod;
        private double trickleAddedAbiOnlySenseImp;
        private double trickleAddedAbiOnlyTimeSpace;
        private double trickleAddedAbiOnlyMaterCrea;
        private double trickleAddedAbiOnlyNanoCInit;
        private double trickleAddedAbiOnlyVehAir; // EXPLORING
        private double trickleAddedAbiOnlyVehGround;
        private double trickleAddedAbiOnlyVehWater;
        private double trickleAddedAbiOnlyAdventuring;
        private double trickleAddedAbiOnlyRunSpeed;
        private double trickleAddedAbiOnlyPerception; // COMBAT & HEALING
        private double trickleAddedAbiOnlyConcealment;
        private double trickleAddedAbiOnlyPsychology;
        private double trickleAddedAbiOnlyTrapDisarm;
        private double trickleAddedAbiOnlyFirstAid;
        private double trickleAddedAbiOnlyTreatment;
        private double trickleAddedAbiOnlyMechanicalEng; // TRADE & REPAIR
        private double trickleAddedAbiOnlyElectricalEng;
        private double trickleAddedAbiOnlyFieldQuantumPhy;
        private double trickleAddedAbiOnlyChemestry;
        private double trickleAddedAbiOnlyWeaponSmithing;
        private double trickleAddedAbiOnlyNanoProgramming;
        private double trickleAddedAbiOnlyTutoring;
        private double trickleAddedAbiOnlyBreakingEntering;
        private double trickleAddedAbiOnlyComputerLiteracy;
        private double trickleAddedAbiOnlyPharma;
        private double trickleAddedAbiOnlySwim; // OLD - REMOVED from game
        private double trickleAddedAbiOnlyMapNav;

        private double totalSpentIPBdyDev; // F-skill = B-skill - C-nakTrickle - startingSkill
        private double totalSpentIPNanoPool;
        private double totalSpentIPEvadeClsCombat;
        private double totalSpentIPDodgeRanged;
        private double totalSpentIPDuckExpl;
        private double totalSpentIPNanoResist;
        private double totalSpentIPParry;
        private double totalSpentIP1HB; // MELEE WEAPONS
        private double totalSpentIP1HE;
        private double totalSpentIPPiercing;
        private double totalSpentIP2HB;
        private double totalSpentIP2HE;
        private double totalSpentIPMeleeEnergy;
        private double totalSpentIPMartialArts;
        private double totalSpentIPMultiMelee;
        private double totalSpentIPMeleeInit;
        private double totalSpentIPPhysicalInit;
        private double totalSpentIPSneakAttack; // MELEE SPECIAL
        private double totalSpentIPBrawl;
        private double totalSpentIPFastAttack;
        private double totalSpentIPDimach;
        private double totalSpentIPRipost;
        private double totalSpentIPPistol; // RANGED WEAPON
        private double totalSpentIPBow;
        private double totalSpentIPSubMachineGun;
        private double totalSpentIPAssultRifle;
        private double totalSpentIPShotgun;
        private double totalSpentIPRifle;
        private double totalSpentIPRangedEnergy;
        private double totalSpentIPGrenade;
        private double totalSpentIPHeavyWeapons;
        private double totalSpentIPMultiRanged;
        private double totalSpentIPRangedInit;
        private double totalSpentIPFlingShot; // RANGED SPECIAL
        private double totalSpentIPAimedShot;
        private double totalSpentIPBurst;
        private double totalSpentIPFullAuto;
        private double totalSpentIPBowSpcAtk;
        private double totalSpentIPSharpObjects;
        private double totalSpentIPMaterMet; // NANO & AIDING
        private double totalSpentIPBioMet;
        private double totalSpentIPPsychoMod;
        private double totalSpentIPSenseImp;
        private double totalSpentIPTimeSpace;
        private double totalSpentIPMaterCrea;
        private double totalSpentIPNanoCInit;
        private double totalSpentIPVehAir; // EXPLORING
        private double totalSpentIPVehGround;
        private double totalSpentIPVehWater;
        private double totalSpentIPAdventuring;
        private double totalSpentIPRunSpeed;
        private double totalSpentIPPerception; // COMBAT & HEALING
        private double totalSpentIPConcealment;
        private double totalSpentIPPsychology;
        private double totalSpentIPTrapDisarm;
        private double totalSpentIPFirstAid;
        private double totalSpentIPTreatment;
        private double totalSpentIPMechanicalEng; // TRADE & REPAIR
        private double totalSpentIPElectricalEng;
        private double totalSpentIPFieldQuantumPhy;
        private double totalSpentIPChemestry;
        private double totalSpentIPWeaponSmithing;
        private double totalSpentIPNanoProgramming;
        private double totalSpentIPTutoring;
        private double totalSpentIPBreakingEntering;
        private double totalSpentIPComputerLiteracy;
        private double totalSpentIPPharma;
        private double totalSpentIPSwim; // OLD - REMOVED from game
        private double totalSpentIPMapNav;

        private double totalBdyDev; // Total skill points after all effects are calculated in, nakskills, addedtrickleskill, addedskills
        private double totalNanoPool; // G-totalSkills = B-nakskill + E-addedTrickleSkill + O-addedskill
        private double totalEvadeClsCombat;
        private double totalDodgeRanged;
        private double totalDuckExpl;
        private double totalNanoResist;
        private double totalParry;
        private double total1HB; // MELEE WEAPONS
        private double total1HE;
        private double totalPiercing;
        private double total2HB;
        private double total2HE;
        private double totalMeleeEnergy;
        private double totalMartialArts;
        private double totalMultiMelee;
        private double totalMeleeInit;
        private double totalPhysicalInit;
        private double totalSneakAttack; // MELEE SPECIAL
        private double totalBrawl;
        private double totalFastAttack;
        private double totalDimach;
        private double totalRipost;
        private double totalPistol; // RANGED WEAPON
        private double totalBow;
        private double totalSubMachineGun;
        private double totalAssultRifle;
        private double totalShotgun;
        private double totalRifle;
        private double totalRangedEnergy;
        private double totalGrenade;
        private double totalHeavyWeapons;
        private double totalMultiRanged;
        private double totalRangedInit;
        private double totalFlingShot; // RANGED SPECIAL
        private double totalAimedShot;
        private double totalBurst;
        private double totalFullAuto;
        private double totalBowSpcAtk;
        private double totalSharpObjects;
        private double totalMaterMet; // NANO & AIDING
        private double totalBioMet;
        private double totalPsychoMod;
        private double totalSenseImp;
        private double totalTimeSpace;
        private double totalMaterCrea;
        private double totalNanoCInit;
        private double totalVehAir; // EXPLORING
        private double totalVehGround;
        private double totalVehWater;
        private double totalAdventuring;
        private double totalRunSpeed;
        private double totalPerception; // COMBAT & HEALING
        private double totalConcealment;
        private double totalPsychology;
        private double totalTrapDisarm;
        private double totalFirstAid;
        private double totalTreatment;
        private double totalMechanicalEng; // TRADE & REPAIR
        private double totalElectricalEng;
        private double totalFieldQuantumPhy;
        private double totalChemestry;
        private double totalWeaponSmithing;
        private double totalNanoProgramming;
        private double totalTutoring;
        private double totalBreakingEntering;
        private double totalComputerLiteracy;
        private double totalPharma;
        private double totalSwim; // OLD - REMOVED from game
        private double totalMapNav;
        



        private void button1_Click(object sender, EventArgs e)
        {
            // These have to be assigned to txtbox's and converted to double first so that
            // the following formulas can use them and not get a conversion error (which i get anyway if the text boxes are not populated or populated with something other than a number.

            nakStr = Convert.ToDouble(nakStrTxtBox.Text);
            nakAgi = Convert.ToDouble(nakAgiTxtBox.Text);
            nakStm = Convert.ToDouble(nakStmTxtBox.Text); // B-ability
            nakInt = Convert.ToDouble(nakIntTxtBox.Text);
            nakSen = Convert.ToDouble(nakSenTxtBox.Text);
            nakPsy = Convert.ToDouble(nakPsyTxtBox.Text);

            addedStr = Convert.ToDouble(addedStrTxtBox.Text);
            addedAgi = Convert.ToDouble(addedAgiTxtBox.Text);
            addedStm = Convert.ToDouble(addedStmTxtBox.Text); // O-ability
            addedInt = Convert.ToDouble(addedIntTxtBox.Text);
            addedSen = Convert.ToDouble(addedSenTxtBox.Text);
            addedPsy = Convert.ToDouble(addedPsyTxtBox.Text);

            nakBdyDev = Convert.ToDouble(nakBdyDevTxtBox.Text); // B-skills
            nakNanoPool = Convert.ToDouble(nakNanoPoolTxtBox.Text);
            nakEvadeClsCombat = Convert.ToDouble(nakEvadeClsCombatTxtBox.Text);
            nakDodgeRanged = Convert.ToDouble(nakDodgeRangedTxtBox.Text);
            nakDuckExpl = Convert.ToDouble(nakDuckExplTxtBox.Text);
            nakNanoResist = Convert.ToDouble(nakNanoResistTxtBox.Text);
            nakParry = Convert.ToDouble(nakParryTxtBox.Text);
            nak1HB = Convert.ToDouble(nak1HBTxtBox.Text);
            nak1HE = Convert.ToDouble(nak1HETxtBox.Text);
            nakPiercing = Convert.ToDouble(nakPiercingTxtBox.Text);
            nak2HB = Convert.ToDouble(nak2HBTxtBox.Text);
            nak2HE = Convert.ToDouble(nak2HETxtBox.Text);
            nakMeleeEnergy = Convert.ToDouble(nakMeleeEnergyTxtBox.Text);
            nakMartialArts = Convert.ToDouble(nakMartialArtsTxtBox.Text);
            nakMultiMelee = Convert.ToDouble(nakMultiMeleeTxtBox.Text);
            nakMeleeInit = Convert.ToDouble(nakMeleeInitTxtBox.Text);
            nakPhysicalInit = Convert.ToDouble(nakPhysicalInitTxtBox.Text);
            nakSneakAttack = Convert.ToDouble(nakSneakAttackTxtBox.Text);
            nakBrawl = Convert.ToDouble(nakBrawlTxtBox.Text);
            nakFastAttack = Convert.ToDouble(nakFastAttackTxtBox.Text);
            nakDimach = Convert.ToDouble(nakDimachTxtBox.Text);
            nakRipost = Convert.ToDouble(nakRipostTxtBox.Text);
            nakPistol = Convert.ToDouble(nakPistolTxtBox.Text);
            nakBow = Convert.ToDouble(nakBowTxtBox.Text);
            nakSubMachineGun = Convert.ToDouble(nakSubMachineGunTxtBox.Text);
            nakAssultRifle = Convert.ToDouble(nakAssultRifleTxtBox.Text);
            nakShotgun = Convert.ToDouble(nakShotgunTxtBox.Text);
            nakRifle = Convert.ToDouble(nakRifleTxtBox.Text);
            nakRangedEnergy = Convert.ToDouble(nakRangedEnergyTxtBox.Text);
            nakGrenade = Convert.ToDouble(nakGrenadeTxtBox.Text);
            nakHeavyWeapons = Convert.ToDouble(nakHeavyWeaponsTxtBox.Text);
            nakMultiRanged = Convert.ToDouble(nakMultiRangedTxtBox.Text);
            nakRangedInit = Convert.ToDouble(nakRangedInitTxtBox.Text);
            nakFlingShot = Convert.ToDouble(nakFlingShotTxtBox.Text);
            nakAimedShot = Convert.ToDouble(nakAimedShotTxtBox.Text);
            nakBurst = Convert.ToDouble(nakBurstTxtBox.Text);
            nakFullAuto = Convert.ToDouble(nakFullAutoTxtBox.Text);
            nakBowSpcAtk = Convert.ToDouble(nakBowSpcAtkTxtBox.Text);
            nakSharpObjects = Convert.ToDouble(nakSharpObjectsTxtBox.Text);
            nakMaterMet = Convert.ToDouble(nakMaterMetTxtBox.Text);
            nakBioMet = Convert.ToDouble(nakBioMetTxtBox.Text);
            nakPsychoMod = Convert.ToDouble(nakPsychoModTxtBox.Text);
            nakSenseImp = Convert.ToDouble(nakSenseImpTxtBox.Text);
            nakTimeSpace = Convert.ToDouble(nakTimeSpaceTxtBox.Text);
            nakMaterCrea = Convert.ToDouble(nakMaterCreaTxtBox.Text);
            nakNanoCInit = Convert.ToDouble(nakNanoCInitTxtBox.Text);
            nakVehAir = Convert.ToDouble(nakVehAirTxtBox.Text);
            nakVehGround = Convert.ToDouble(nakVehGroundTxtBox.Text);
            nakVehWater = Convert.ToDouble(nakVehWaterTxtBox.Text);
            nakAdventuring = Convert.ToDouble(nakAdventuringTxtBox.Text);
            nakRunSpeed = Convert.ToDouble(nakRunSpeedTxtBox.Text);
            nakPerception = Convert.ToDouble(nakPerceptionTxtBox.Text);
            nakConcealment = Convert.ToDouble(nakConcealmentTxtBox.Text);
            nakPsychology = Convert.ToDouble(nakPsychologyTxtBox.Text);
            nakTrapDisarm = Convert.ToDouble(nakTrapDisarmTxtBox.Text);
            nakFirstAid = Convert.ToDouble(nakFirstAidTxtBox.Text);
            nakTreatment = Convert.ToDouble(nakTreatmentTxtBox.Text);
            nakMechanicalEng = Convert.ToDouble(nakMechanicalEngTxtBox.Text);
            nakElectricalEng = Convert.ToDouble(nakElectricalEngTxtBox.Text);
            nakFieldQuantumPhy = Convert.ToDouble(nakFieldQuantumPhyTxtBox.Text);
            nakChemestry = Convert.ToDouble(nakChemestryTxtBox.Text);
            nakWeaponSmithing = Convert.ToDouble(nakWeaponSmithingTxtBox.Text);
            nakNanoProgramming = Convert.ToDouble(nakNanoProgrammingTxtBox.Text);
            nakTutoring = Convert.ToDouble(nakTutoringTxtBox.Text);
            nakBreakingEntering = Convert.ToDouble(nakBreakingEnteringTxtBox.Text);
            nakComputerLiteracy = Convert.ToDouble(nakComputerLiteracyTxtBox.Text);
            nakPharma = Convert.ToDouble(nakPharmaTxtBox.Text);
            nakSwim = Convert.ToDouble(nakSwimTxtBox.Text);
            nakMapNav = Convert.ToDouble(nakMapNavTxtBox.Text);

            addedBdyDev = Convert.ToDouble(addedBdyDevTxtBox.Text); // O-skills            
            addedNanoPool = Convert.ToDouble(nakNanoPoolTxtBox.Text);
            addedEvadeClsCombat = Convert.ToDouble(addedEvadeClsCombatTxtBox.Text);
            addedDodgeRanged = Convert.ToDouble(addedDodgeRangedTxtBox.Text);
            addedDuckExpl = Convert.ToDouble(addedDuckExplTxtBox.Text);
            addedNanoResist = Convert.ToDouble(addedNanoResistTxtBox.Text);
            addedParry = Convert.ToDouble(addedParryTxtBox.Text);
            added1HB = Convert.ToDouble(added1HBTxtBox.Text);
            added1HE = Convert.ToDouble(added1HETxtBox.Text);
            addedPiercing = Convert.ToDouble(addedPiercingTxtBox.Text);
            added2HB = Convert.ToDouble(added2HBTxtBox.Text);
            added2HE = Convert.ToDouble(added2HETxtBox.Text);
            addedMeleeEnergy = Convert.ToDouble(addedMeleeEnergyTxtBox.Text);
            addedMartialArts = Convert.ToDouble(addedMartialArtsTxtBox.Text);
            addedMultiMelee = Convert.ToDouble(addedMultiMeleeTxtBox.Text);
            addedMeleeInit = Convert.ToDouble(addedMeleeInitTxtBox.Text);
            addedPhysicalInit = Convert.ToDouble(addedPhysicalInitTxtBox.Text);
            addedSneakAttack = Convert.ToDouble(addedSneakAttackTxtBox.Text);
            addedBrawl = Convert.ToDouble(addedBrawlTxtBox.Text);
            addedFastAttack = Convert.ToDouble(addedFastAttackTxtBox.Text);
            addedDimach = Convert.ToDouble(addedDimachTxtBox.Text);
            addedRipost = Convert.ToDouble(addedRipostTxtBox.Text);
            addedPistol = Convert.ToDouble(addedPistolTxtBox.Text);
            addedBow = Convert.ToDouble(addedBowTxtBox.Text);
            addedSubMachineGun = Convert.ToDouble(addedSubMachineGunTxtBox.Text);
            addedAssultRifle = Convert.ToDouble(addedAssultRifleTxtBox.Text);
            addedShotgun = Convert.ToDouble(addedShotgunTxtBox.Text);
            addedRifle = Convert.ToDouble(addedRifleTxtBox.Text);
            addedRangedEnergy = Convert.ToDouble(addedRangedEnergyTxtBox.Text);
            addedGrenade = Convert.ToDouble(addedGrenadeTxtBox.Text);
            addedHeavyWeapons = Convert.ToDouble(addedHeavyWeaponsTxtBox.Text);
            addedMultiRanged = Convert.ToDouble(addedMultiRangedTxtBox.Text);
            addedRangedInit = Convert.ToDouble(addedRangedInitTxtBox.Text);
            addedFlingShot = Convert.ToDouble(addedFlingShotTxtBox.Text);
            addedAimedShot = Convert.ToDouble(addedAimedShotTxtBox.Text);
            addedBurst = Convert.ToDouble(addedBurstTxtBox.Text);
            addedFullAuto = Convert.ToDouble(addedFullAutoTxtBox.Text);
            addedBowSpcAtk = Convert.ToDouble(addedBowSpcAtkTxtBox.Text);
            addedSharpObjects = Convert.ToDouble(addedSharpObjectsTxtBox.Text);
            addedMaterMet = Convert.ToDouble(addedMaterMetTxtBox.Text);
            addedBioMet = Convert.ToDouble(addedBioMetTxtBox.Text);
            addedPsychoMod = Convert.ToDouble(addedPsychoModTxtBox.Text);
            addedSenseImp = Convert.ToDouble(addedSenseImpTxtBox.Text);
            addedTimeSpace = Convert.ToDouble(addedTimeSpaceTxtBox.Text);
            addedMaterCrea = Convert.ToDouble(addedMaterCreaTxtBox.Text);
            addedNanoCInit = Convert.ToDouble(addedNanoCInitTxtBox.Text);
            addedVehAir = Convert.ToDouble(addedVehAirTxtBox.Text);
            addedVehGround = Convert.ToDouble(addedVehGroundTxtBox.Text);
            addedVehWater = Convert.ToDouble(addedVehWaterTxtBox.Text);
            addedAdventuring = Convert.ToDouble(addedAdventuringTxtBox.Text);
            addedRunSpeed = Convert.ToDouble(addedRunSpeedTxtBox.Text);
            addedPerception = Convert.ToDouble(addedPerceptionTxtBox.Text);
            addedConcealment = Convert.ToDouble(addedConcealmentTxtBox.Text);
            addedPsychology = Convert.ToDouble(addedPsychologyTxtBox.Text);
            addedTrapDisarm = Convert.ToDouble(addedTrapDisarmTxtBox.Text);
            addedFirstAid = Convert.ToDouble(addedFirstAidTxtBox.Text);
            addedTreatment = Convert.ToDouble(addedTreatmentTxtBox.Text);
            addedMechanicalEng = Convert.ToDouble(addedMechanicalEngTxtBox.Text);
            addedElectricalEng = Convert.ToDouble(addedElectricalEngTxtBox.Text);
            addedFieldQuantumPhy = Convert.ToDouble(addedFieldQuantumPhyTxtBox.Text);
            addedChemestry = Convert.ToDouble(addedChemestryTxtBox.Text);
            addedWeaponSmithing = Convert.ToDouble(addedWeaponSmithingTxtBox.Text);
            addedNanoProgramming = Convert.ToDouble(nakNanoProgrammingTxtBox.Text);
            addedTutoring = Convert.ToDouble(addedTutoringTxtBox.Text);
            addedBreakingEntering = Convert.ToDouble(addedBreakingEnteringTxtBox.Text);
            addedComputerLiteracy = Convert.ToDouble(addedComputerLiteracyTxtBox.Text);
            addedPharma = Convert.ToDouble(addedPharmaTxtBox.Text);
            addedSwim = Convert.ToDouble(addedSwimTxtBox.Text);
            addedMapNav = Convert.ToDouble(addedMapNavTxtBox.Text);

            // perform nessary calculation... 
            spentIPStr = nakStr - startingPointsAbilities;
            spentIPAgi = nakAgi - startingPointsAbilities;
            spentIPStm = nakStm - startingPointsAbilities; // F-ability
            spentIPInt = nakInt - startingPointsAbilities;
            spentIPSen = nakSen - startingPointsAbilities;
            spentIPPsy = nakPsy - startingPointsAbilities;

            totalStr = spentIPStr + startingPointsAbilities + addedStr;
            totalAgi = spentIPAgi + startingPointsAbilities + addedAgi;
            totalStm = spentIPStm + startingPointsAbilities + addedStm; // G-ability
            totalInt = spentIPInt + startingPointsAbilities + addedInt;
            totalSen = spentIPSen + startingPointsAbilities + addedSen;
            totalPsy = spentIPPsy + startingPointsAbilities + addedPsy;

            // base trickledown calculation
            nakTrickleBdyDev = Math.Ceiling(percentKey100 * nakStm); // C-nakTrickle
            nakTrickleNanoPool = Math.Ceiling((percentKey10 * nakStm)+(percentKey10 * nakInt)+(percentKey10 * nakSen)+(percentKey70 * nakPsy));
            nakTrickleEvadeClsCombat = Math.Ceiling((percentKey50 * nakStm)+(percentKey20 * nakInt)+(percentKey30 * nakSen));
            nakTrickleDodgeRanged = Math.Ceiling((percentKey50 * nakAgi)+(percentKey20 * nakInt)+(percentKey30 * nakSen));
            nakTrickleDuckExpl = Math.Ceiling((percentKey50 * nakAgi)+(percentKey20 * nakInt)+(percentKey30 * nakSen));
            nakTrickleNanoResist = Math.Ceiling((percentKey20 * nakInt)+(percentKey80 * nakPsy));
            nakTrickleParry = Math.Ceiling((percentKey50 * nakStr)+(percentKey20 * nakAgi)+(percentKey30 * nakSen));
            nakTrickle1HB = Math.Ceiling((percentKey50 * nakStr)+(percentKey10 * nakAgi) +(percentKey40 * nakStm));
            nakTrickle1HE = Math.Ceiling((percentKey30 * nakStr)+(percentKey40 * nakAgi) +(percentKey30 * nakStm));
            nakTricklePiercing = Math.Ceiling((percentKey20 * nakStr)+(percentKey50 * nakAgi) +(percentKey30 * nakStm));
            nakTrickle2HB = Math.Ceiling((percentKey50 * nakStr)+(percentKey50 * nakStm));
            nakTrickle2HE = Math.Ceiling((percentKey60 * nakStr)+(percentKey40 * nakStm));
            nakTrickleMeleeEnergy = Math.Ceiling((percentKey100 * nakStm)+ (percentKey50 * nakInt));
            nakTrickleMartialArts = Math.Ceiling((percentKey20 * nakStr)+(percentKey50 * nakAgi)+(percentKey30 * nakPsy));
            nakTrickleMultiMelee = Math.Ceiling((percentKey30 * nakStr)+(percentKey60 * nakAgi)+(percentKey10 * nakStm));
            nakTrickleMeleeInit = Math.Ceiling((percentKey10 * nakAgi)+(percentKey10 * nakInt)+(percentKey60 * nakSen)+(percentKey20 * nakPsy));
            nakTricklePhysicalInit = Math.Ceiling((percentKey10 * nakAgi)+(percentKey10 * nakInt)+(percentKey60 * nakSen)+ (percentKey20 * nakPsy));
            nakTrickleSneakAttack = Math.Ceiling((percentKey80 * nakSen)+ (percentKey20 * nakPsy));
            nakTrickleBrawl = Math.Ceiling((percentKey60 * nakStr)+ (percentKey40 * nakStm));
            nakTrickleFastAttack = Math.Ceiling((percentKey60 * nakAgi)+ (percentKey40 * nakSen));
            nakTrickleDimach = Math.Ceiling((percentKey80 * nakSen)+ (percentKey20 * nakPsy));
            nakTrickleRipost = Math.Ceiling((percentKey50 * nakStm)+ (percentKey50 * nakSen));
            nakTricklePistol = Math.Ceiling((percentKey60 * nakAgi)+ (percentKey40 * nakSen));
            nakTrickleBow = Math.Ceiling((percentKey20 * nakStr)+ (percentKey40 * nakAgi)+ (percentKey40 * nakSen));
            nakTrickleSubMachineGun = Math.Ceiling((percentKey30 * nakStr)+ (percentKey30 * nakAgi)+ (percentKey30 * nakStm)+ (percentKey10 * nakSen));
            nakTrickleAssultRifle = Math.Ceiling((percentKey10 * nakStr)+ (percentKey30 * nakAgi)+ (percentKey40 * nakStm)+ (percentKey20 * nakSen));
            nakTrickleShotgun = Math.Ceiling((percentKey40 * nakStr)+ (percentKey60 * nakAgi));
            nakTrickleRifle = Math.Ceiling((percentKey60 * nakAgi)+ (percentKey40 * nakSen));
            nakTrickleRangedEnergy = Math.Ceiling((percentKey20 * nakInt)+ (percentKey40 * nakSen)+ (percentKey40 * nakPsy));
            nakTrickleGrenade = Math.Ceiling((percentKey40 * nakAgi)+ (percentKey20 * nakInt)+ (percentKey40 * nakSen));
            nakTrickleHeavyWeapons = Math.Ceiling((percentKey40 * nakStr)+ (percentKey60 * nakAgi));
            nakTrickleMultiRanged = Math.Ceiling((percentKey60 * nakAgi)+ (percentKey40 * nakInt));
            nakTrickleRangedInit = Math.Ceiling((percentKey10 * nakAgi)+ (percentKey10 * nakInt)+(percentKey60 * nakSen)+ (percentKey20 * nakPsy));
            nakTrickleFlingShot = Math.Ceiling(percentKey100 * nakAgi);
            nakTrickleAimedShot = Math.Ceiling(percentKey100 * nakSen);
            nakTrickleBurst = Math.Ceiling((percentKey30 * nakStr)+ (percentKey50 * nakAgi)+ (percentKey20 * nakStm));
            nakTrickleFullAuto = Math.Ceiling((percentKey60 * nakStr)+ (percentKey40 * nakStm));
            nakTrickleBowSpcAtk = Math.Ceiling((percentKey10 * nakStr)+ (percentKey50 * nakAgi)+ (percentKey40 * nakSen));
            nakTrickleSharpObjects = Math.Ceiling((percentKey20 * nakStr)+ (percentKey60 * nakAgi)+ (percentKey20 * nakSen));
            nakTrickleMaterMet = Math.Ceiling((percentKey80 * nakInt)+ (percentKey20 * nakPsy));
            nakTrickleBioMet = Math.Ceiling((percentKey80 * nakInt) + (percentKey20 * nakPsy));
            nakTricklePsychoMod = Math.Ceiling((percentKey80 * nakInt) + (percentKey20 * nakSen));
            nakTrickleSenseImp = Math.Ceiling((percentKey20 * nakStr) + (percentKey80 * nakInt));
            nakTrickleTimeSpace = Math.Ceiling((percentKey20 * nakAgi) + (percentKey80 * nakInt));
            nakTrickleMaterCrea = Math.Ceiling((percentKey20 * nakStm) + (percentKey80 * nakInt));
            nakTrickleNanoCInit = Math.Ceiling((percentKey40 * nakAgi)+(percentKey60 * nakSen));
            nakTrickleVehAir = Math.Ceiling((percentKey20 * nakAgi)+ (percentKey20 * nakInt)+ (percentKey60 * nakSen));
            nakTrickleVehGround = Math.Ceiling((percentKey20 * nakAgi) + (percentKey20 * nakInt) + (percentKey60 * nakSen));
            nakTrickleVehWater = Math.Ceiling((percentKey20 * nakAgi) + (percentKey20 * nakInt) + (percentKey60 * nakSen));
            nakTrickleAdventuring = Math.Ceiling((percentKey20 * nakStr)+ (percentKey50 * nakAgi)+ (percentKey30 * nakStm));
            nakTrickleRunSpeed = Math.Ceiling((percentKey20 * nakStr) + (percentKey40 * nakAgi) + (percentKey40 * nakStm));
            nakTricklePerception = Math.Ceiling((percentKey30 * nakInt)+ (percentKey70 * nakSen));
            nakTrickleConcealment = Math.Ceiling((percentKey30 * nakAgi)+ (percentKey70 * nakSen));
            nakTricklePsychology = Math.Ceiling((percentKey50 * nakInt)+ (percentKey50 * nakSen));
            nakTrickleTrapDisarm = Math.Ceiling((percentKey30 * nakAgi)+ (percentKey20 * nakInt)+ (percentKey60 * nakSen));
            nakTrickleFirstAid = Math.Ceiling((percentKey30 * nakAgi) + (percentKey30 * nakInt) + (percentKey40 * nakSen));
            nakTrickleTreatment = Math.Ceiling((percentKey30 * nakAgi) + (percentKey50 * nakInt) + (percentKey20 * nakSen));
            nakTrickleMechanicalEng = Math.Ceiling((percentKey50 * nakAgi)+ (percentKey50 * nakInt));
            nakTrickleElectricalEng = Math.Ceiling((percentKey30 * nakAgi)+ (percentKey20 * nakStm)+ (percentKey50 * nakInt));
            nakTrickleFieldQuantumPhy = Math.Ceiling((percentKey50 * nakInt)+ (percentKey50 * nakPsy));
            nakTrickleChemestry = Math.Ceiling((percentKey50 * nakStm)+ (percentKey50 * nakInt));
            nakTrickleWeaponSmithing = Math.Ceiling((percentKey50 * nakStr)+ (percentKey50 * nakInt));
            nakTrickleNanoProgramming = Math.Ceiling(percentKey100 * nakInt);
            nakTrickleTutoring = Math.Ceiling((percentKey70 * nakInt)+ (percentKey20 * nakSen) + (percentKey10 * nakPsy));
            nakTrickleBreakingEntering = Math.Ceiling((percentKey40 * nakAgi) + (percentKey30 * nakSen) + (percentKey30 * nakPsy));
            nakTrickleComputerLiteracy = Math.Ceiling(percentKey100 * nakInt);
            nakTricklePharma = Math.Ceiling((percentKey20 * nakAgi) + (percentKey80 * nakInt));
            nakTrickleSwim = Math.Ceiling((percentKey20 * nakStr) + (percentKey20 * nakAgi) + (percentKey60 * nakStm));
            nakTrickleMapNav = Math.Ceiling((percentKey40 * nakInt) + (percentKey50 * nakSen) + (percentKey10 * nakPsy));
            // total trickledown calculations
            totalTrickleBdyDev = Math.Ceiling(percentKey100 * totalStm); // D-addedTrickle            
            totalTrickleNanoPool = Math.Ceiling((percentKey10 * totalStm) + (percentKey10 * totalInt) + (percentKey10 * totalSen) + (percentKey70 * totalPsy));
            totalTrickleEvadeClsCombat = Math.Ceiling((percentKey50 * totalStm) + (percentKey20 * totalInt) + (percentKey30 * totalSen));
            totalTrickleDodgeRanged = Math.Ceiling((percentKey50 * totalAgi) + (percentKey20 * totalInt) + (percentKey30 * totalSen));
            totalTrickleDuckExpl = Math.Ceiling((percentKey50 * totalAgi) + (percentKey20 * totalInt) + (percentKey30 * totalSen));
            totalTrickleNanoResist = Math.Ceiling((percentKey20 * totalInt) + (percentKey80 * totalPsy));
            totalTrickleParry = Math.Ceiling((percentKey50 * totalStr) + (percentKey20 * totalAgi) + (percentKey30 * totalSen));
            totalTrickle1HB = Math.Ceiling((percentKey50 * totalStr) + (percentKey10 * totalAgi) + (percentKey40 * totalStm));
            totalTrickle1HE = Math.Ceiling((percentKey30 * totalStr) + (percentKey40 * totalAgi) + (percentKey30 * totalStm));
            totalTricklePiercing = Math.Ceiling((percentKey20 * totalStr) + (percentKey50 * totalAgi) + (percentKey30 * totalStm));
            totalTrickle2HB = Math.Ceiling((percentKey50 * totalStr) + (percentKey50 * totalStm));
            totalTrickle2HE = Math.Ceiling((percentKey60 * totalStr) + (percentKey40 * totalStm));
            totalTrickleMeleeEnergy = Math.Ceiling((percentKey100 * totalStm) + (percentKey50 * totalInt));
            totalTrickleMartialArts = Math.Ceiling((percentKey20 * totalStr) + (percentKey50 * totalAgi) + (percentKey30 * totalPsy));
            totalTrickleMultiMelee = Math.Ceiling((percentKey30 * totalStr) + (percentKey60 * totalAgi) + (percentKey10 * totalStm));
            totalTrickleMeleeInit = Math.Ceiling((percentKey10 * totalAgi) + (percentKey10 * totalInt) + (percentKey60 * totalSen) + (percentKey20 * totalPsy));
            totalTricklePhysicalInit = Math.Ceiling((percentKey10 * totalAgi) + (percentKey10 * totalInt) + (percentKey60 * totalSen) + (percentKey20 * totalPsy));
            totalTrickleSneakAttack = Math.Ceiling((percentKey80 * totalSen) + (percentKey20 * totalPsy));
            totalTrickleBrawl = Math.Ceiling((percentKey60 * totalStr) + (percentKey40 * totalStm));
            totalTrickleFastAttack = Math.Ceiling((percentKey60 * totalAgi) + (percentKey40 * totalSen));
            totalTrickleDimach = Math.Ceiling((percentKey80 * totalSen) + (percentKey20 * totalPsy));
            totalTrickleRipost = Math.Ceiling((percentKey50 * totalStm) + (percentKey50 * totalSen));
            totalTricklePistol = Math.Ceiling((percentKey60 * totalAgi) + (percentKey40 * totalSen));
            totalTrickleBow = Math.Ceiling((percentKey20 * totalStr) + (percentKey40 * totalAgi) + (percentKey40 * totalSen));
            totalTrickleSubMachineGun = Math.Ceiling((percentKey30 * totalStr) + (percentKey30 * totalAgi) + (percentKey30 * totalStm) + (percentKey10 * totalSen));
            totalTrickleAssultRifle = Math.Ceiling((percentKey10 * totalStr) + (percentKey30 * totalAgi) + (percentKey40 * totalStm) + (percentKey20 * totalSen));
            totalTrickleShotgun = Math.Ceiling((percentKey40 * totalStr) + (percentKey60 * totalAgi));
            totalTrickleRifle = Math.Ceiling((percentKey60 * totalAgi) + (percentKey40 * totalSen));
            totalTrickleRangedEnergy = Math.Ceiling((percentKey20 * totalInt) + (percentKey40 * totalSen) + (percentKey40 * totalPsy));
            totalTrickleGrenade = Math.Ceiling((percentKey40 * totalAgi) + (percentKey20 * totalInt) + (percentKey40 * totalSen));
            totalTrickleHeavyWeapons = Math.Ceiling((percentKey40 * totalStr) + (percentKey60 * totalAgi));
            totalTrickleMultiRanged = Math.Ceiling((percentKey60 * totalAgi) + (percentKey40 * totalInt));
            totalTrickleRangedInit = Math.Ceiling((percentKey10 * totalAgi) + (percentKey10 * totalInt) + (percentKey60 * totalSen) + (percentKey20 * totalPsy));
            totalTrickleFlingShot = Math.Ceiling(percentKey100 * totalAgi);
            totalTrickleAimedShot = Math.Ceiling(percentKey100 * totalSen);
            totalTrickleBurst = Math.Ceiling((percentKey30 * totalStr) + (percentKey50 * totalAgi) + (percentKey20 * totalStm));
            totalTrickleFullAuto = Math.Ceiling((percentKey60 * totalStr) + (percentKey40 * totalStm));
            totalTrickleBowSpcAtk = Math.Ceiling((percentKey10 * totalStr) + (percentKey50 * totalAgi) + (percentKey40 * totalSen));
            totalTrickleSharpObjects = Math.Ceiling((percentKey20 * totalStr) + (percentKey60 * totalAgi) + (percentKey20 * totalSen));
            totalTrickleMaterMet = Math.Ceiling((percentKey80 * totalInt) + (percentKey20 * totalPsy));
            totalTrickleBioMet = Math.Ceiling((percentKey80 * totalInt) + (percentKey20 * totalPsy));
            totalTricklePsychoMod = Math.Ceiling((percentKey80 * totalInt) + (percentKey20 * totalSen));
            totalTrickleSenseImp = Math.Ceiling((percentKey20 * totalStr) + (percentKey80 * totalInt));
            totalTrickleTimeSpace = Math.Ceiling((percentKey20 * totalAgi) + (percentKey80 * totalInt));
            totalTrickleMaterCrea = Math.Ceiling((percentKey20 * totalStm) + (percentKey80 * totalInt));
            totalTrickleNanoCInit = Math.Ceiling((percentKey40 * totalAgi) + (percentKey60 * totalSen));
            totalTrickleVehAir = Math.Ceiling((percentKey20 * totalAgi) + (percentKey20 * totalInt) + (percentKey60 * totalSen));
            totalTrickleVehGround = Math.Ceiling((percentKey20 * totalAgi) + (percentKey20 * totalInt) + (percentKey60 * totalSen));
            totalTrickleVehWater = Math.Ceiling((percentKey20 * totalAgi) + (percentKey20 * totalInt) + (percentKey60 * totalSen));
            totalTrickleAdventuring = Math.Ceiling((percentKey20 * totalStr) + (percentKey50 * totalAgi) + (percentKey30 * totalStm));
            totalTrickleRunSpeed = Math.Ceiling((percentKey20 * totalStr) + (percentKey40 * totalAgi) + (percentKey40 * totalStm));
            totalTricklePerception = Math.Ceiling((percentKey30 * totalInt) + (percentKey70 * totalSen));
            totalTrickleConcealment = Math.Ceiling((percentKey30 * totalAgi) + (percentKey70 * totalSen));
            totalTricklePsychology = Math.Ceiling((percentKey50 * totalInt) + (percentKey50 * totalSen));
            totalTrickleTrapDisarm = Math.Ceiling((percentKey30 * totalAgi) + (percentKey20 * totalInt) + (percentKey60 * totalSen));
            totalTrickleFirstAid = Math.Ceiling((percentKey30 * totalAgi) + (percentKey30 * totalInt) + (percentKey40 * totalSen));
            totalTrickleTreatment = Math.Ceiling((percentKey30 * totalAgi) + (percentKey50 * totalInt) + (percentKey20 * totalSen));
            totalTrickleMechanicalEng = Math.Ceiling((percentKey50 * totalAgi) + (percentKey50 * totalInt));
            totalTrickleElectricalEng = Math.Ceiling((percentKey30 * totalAgi) + (percentKey20 * totalStm) + (percentKey50 * totalInt));
            totalTrickleFieldQuantumPhy = Math.Ceiling((percentKey50 * totalInt) + (percentKey50 * totalPsy));
            totalTrickleChemestry = Math.Ceiling((percentKey50 * totalStm) + (percentKey50 * totalInt));
            totalTrickleWeaponSmithing = Math.Ceiling((percentKey50 * totalStr) + (percentKey50 * totalInt));
            totalTrickleNanoProgramming = Math.Ceiling(percentKey100 * totalInt);
            totalTrickleTutoring = Math.Ceiling((percentKey70 * totalInt) + (percentKey20 * totalSen) + (percentKey10 * totalPsy));
            totalTrickleBreakingEntering = Math.Ceiling((percentKey40 * totalAgi) + (percentKey30 * totalSen) + (percentKey30 * totalPsy));
            totalTrickleComputerLiteracy = Math.Ceiling(percentKey100 * totalInt);
            totalTricklePharma = Math.Ceiling((percentKey20 * totalAgi) + (percentKey80 * totalInt));
            totalTrickleSwim = Math.Ceiling((percentKey20 * totalStr) + (percentKey20 * totalAgi) + (percentKey60 * totalStm));
            totalTrickleMapNav = Math.Ceiling((percentKey40 * totalInt) + (percentKey50 * totalSen) + (percentKey10 * totalPsy));
            // trickledown calculations from added abilities only
            trickleAddedAbiOnlyBdyDev = totalTrickleBdyDev - nakTrickleBdyDev; // E-Skill
            trickleAddedAbiOnlyNanoPool = totalTrickleNanoPool - nakTrickleNanoPool;
            trickleAddedAbiOnlyEvadeClsCombat = totalTrickleEvadeClsCombat - nakTrickleEvadeClsCombat;
            trickleAddedAbiOnlyDodgeRanged = totalTrickleDodgeRanged - nakTrickleDodgeRanged;
            trickleAddedAbiOnlyDuckExpl = totalTrickleDuckExpl - nakTrickleDuckExpl;
            trickleAddedAbiOnlyNanoResist = totalTrickleNanoResist - nakTrickleNanoResist;
            trickleAddedAbiOnlyParry = totalTrickleParry - nakTrickleParry;
            trickleAddedAbiOnly1HB = totalTrickle1HB - nakTrickle1HB;
            trickleAddedAbiOnly1HE = totalTrickle1HE - nakTrickle1HE;
            trickleAddedAbiOnlyPiercing = totalTricklePiercing - nakTricklePiercing;
            trickleAddedAbiOnly2HB = totalTrickle2HB - nakTrickle2HB;
            trickleAddedAbiOnly2HE = totalTrickle2HE - nakTrickle2HE;
            trickleAddedAbiOnlyMeleeEnergy = totalTrickleMeleeEnergy - nakTrickleMeleeEnergy;
            trickleAddedAbiOnlyMartialArts = totalTrickleMartialArts - nakTrickleMartialArts;
            trickleAddedAbiOnlyMultiMelee = totalTrickleMultiMelee - nakTrickleMultiMelee;
            trickleAddedAbiOnlyMeleeInit = totalTrickleMeleeInit - nakTrickleMeleeInit;
            trickleAddedAbiOnlyPhysicalInit = totalTricklePhysicalInit - nakTricklePhysicalInit;
            trickleAddedAbiOnlySneakAttack = totalTrickleSneakAttack - nakTrickleSneakAttack;
            trickleAddedAbiOnlyBrawl = totalTrickleBrawl - nakTrickleBrawl;
            trickleAddedAbiOnlyFastAttack = totalTrickleFastAttack - nakTrickleFastAttack;
            trickleAddedAbiOnlyDimach = totalTrickleDimach - nakTrickleDimach;
            trickleAddedAbiOnlyRipost = totalTrickleRipost - nakTrickleRipost;
            trickleAddedAbiOnlyPistol = totalTricklePistol - nakTricklePistol;
            trickleAddedAbiOnlyBow = totalTrickleBow - nakTrickleBow;
            trickleAddedAbiOnlySubMachineGun = totalTrickleSubMachineGun - nakTrickleSubMachineGun;
            trickleAddedAbiOnlyAssultRifle = totalTrickleAssultRifle - nakTrickleAssultRifle;
            trickleAddedAbiOnlyShotgun = totalTrickleShotgun - nakTrickleShotgun;
            trickleAddedAbiOnlyRifle = totalTrickleRifle - nakTrickleRifle;
            trickleAddedAbiOnlyRangedEnergy = totalTrickleRangedEnergy - nakTrickleRangedEnergy;
            trickleAddedAbiOnlyGrenade = totalTrickleGrenade - nakTrickleGrenade;
            trickleAddedAbiOnlyHeavyWeapons = totalTrickleHeavyWeapons - nakTrickleHeavyWeapons;
            trickleAddedAbiOnlyMultiRanged = totalTrickleMultiRanged - nakTrickleMultiRanged;
            trickleAddedAbiOnlyRangedInit = totalTrickleRangedInit - nakTrickleRangedInit;
            trickleAddedAbiOnlyFlingShot = totalTrickleFlingShot - nakTrickleFlingShot;
            trickleAddedAbiOnlyAimedShot = totalTrickleAimedShot - nakTrickleAimedShot;
            trickleAddedAbiOnlyBurst = totalTrickleBurst - nakTrickleBurst;
            trickleAddedAbiOnlyFullAuto = totalTrickleFullAuto - nakTrickleFullAuto;
            trickleAddedAbiOnlyBowSpcAtk = totalTrickleBowSpcAtk - nakTrickleBowSpcAtk;
            trickleAddedAbiOnlySharpObjects = totalTrickleSharpObjects - nakTrickleSharpObjects;
            trickleAddedAbiOnlyMaterMet = totalTrickleMaterMet - nakTrickleMaterMet;
            trickleAddedAbiOnlyBioMet = totalTrickleBioMet - nakTrickleBioMet;
            trickleAddedAbiOnlyPsychoMod = totalTricklePsychoMod - nakTricklePsychoMod;
            trickleAddedAbiOnlySenseImp = totalTrickleSenseImp - nakTrickleSenseImp;
            trickleAddedAbiOnlyTimeSpace = totalTrickleTimeSpace - nakTrickleTimeSpace;
            trickleAddedAbiOnlyMaterCrea = totalTrickleMaterCrea - nakTrickleMaterCrea;
            trickleAddedAbiOnlyNanoCInit = totalTrickleNanoCInit - nakTrickleNanoCInit;
            trickleAddedAbiOnlyVehAir = totalTrickleVehAir - nakTrickleVehAir;
            trickleAddedAbiOnlyVehGround = totalTrickleVehGround - nakTrickleVehGround;
            trickleAddedAbiOnlyVehWater = totalTrickleVehWater - nakTrickleVehWater;
            trickleAddedAbiOnlyAdventuring = totalTrickleAdventuring - nakTrickleAdventuring;
            trickleAddedAbiOnlyRunSpeed = totalTrickleRunSpeed - nakTrickleRunSpeed;
            trickleAddedAbiOnlyPerception = totalTricklePerception - nakTricklePerception;
            trickleAddedAbiOnlyConcealment = totalTrickleConcealment - nakTrickleConcealment;
            trickleAddedAbiOnlyPsychology = totalTricklePsychology - nakTricklePsychology;
            trickleAddedAbiOnlyTrapDisarm = totalTrickleTrapDisarm - nakTrickleTrapDisarm;
            trickleAddedAbiOnlyFirstAid = totalTrickleFirstAid - nakTrickleFirstAid;
            trickleAddedAbiOnlyTreatment = totalTrickleTreatment - nakTrickleTreatment;
            trickleAddedAbiOnlyMechanicalEng = totalTrickleMechanicalEng - nakTrickleMechanicalEng;
            trickleAddedAbiOnlyElectricalEng = totalTrickleElectricalEng - nakTrickleElectricalEng;
            trickleAddedAbiOnlyFieldQuantumPhy = totalTrickleFieldQuantumPhy - nakTrickleFieldQuantumPhy;
            trickleAddedAbiOnlyChemestry = totalTrickleChemestry - nakTrickleChemestry;
            trickleAddedAbiOnlyWeaponSmithing = totalTrickleWeaponSmithing - nakTrickleWeaponSmithing;
            trickleAddedAbiOnlyNanoProgramming = totalTrickleNanoProgramming - nakTrickleNanoProgramming;
            trickleAddedAbiOnlyTutoring = totalTrickleTutoring - nakTrickleTutoring;
            trickleAddedAbiOnlyBreakingEntering = totalTrickleBreakingEntering - nakTrickleBreakingEntering;
            trickleAddedAbiOnlyComputerLiteracy = totalTrickleComputerLiteracy - nakTrickleComputerLiteracy;
            trickleAddedAbiOnlyPharma = totalTricklePharma - nakTricklePharma;
            trickleAddedAbiOnlySwim = totalTrickleSwim - nakTrickleSwim;
            trickleAddedAbiOnlyMapNav = totalTrickleMapNav - nakTrickleMapNav;

            // Spent IP Points - for viewing only not used for other calculations
            totalSpentIPBdyDev = nakBdyDev - nakTrickleBdyDev - startingPointsSkills; // F-Skill
            totalSpentIPNanoPool = nakNanoPool - nakTrickleNanoPool - startingPointsSkills;
            totalSpentIPEvadeClsCombat = nakEvadeClsCombat - nakTrickleEvadeClsCombat - startingPointsSkills;
            totalSpentIPDodgeRanged = nakDodgeRanged - nakTrickleDodgeRanged - startingPointsSkills;
            totalSpentIPDuckExpl = nakDuckExpl - nakTrickleDuckExpl - startingPointsSkills;
            totalSpentIPNanoResist = nakNanoResist - nakTrickleNanoResist - startingPointsSkills;
            totalSpentIPParry = nakParry - nakTrickleParry - startingPointsSkills;
            totalSpentIP1HB = nak1HB - nakTrickle1HB - startingPointsSkills;
            totalSpentIP1HE = nak1HE - nakTrickle1HE - startingPointsSkills;
            totalSpentIPPiercing = nakPiercing - nakTricklePiercing - startingPointsSkills;
            totalSpentIP2HB = nak2HB - nakTrickle2HB - startingPointsSkills;
            totalSpentIP2HE = nak2HE - nakTrickle2HE - startingPointsSkills;
            totalSpentIPMeleeEnergy = nakMeleeEnergy - nakTrickleMeleeEnergy - startingPointsSkills;
            totalSpentIPMartialArts = nakMartialArts - nakTrickleMartialArts - startingPointsSkills;
            totalSpentIPMultiMelee = nakMultiMelee - nakTrickleMultiMelee - startingPointsSkills;
            totalSpentIPMeleeInit = nakMeleeInit - nakTrickleMeleeInit - startingPointsSkills;
            totalSpentIPPhysicalInit = nakPhysicalInit - nakTricklePhysicalInit - startingPointsSkills;
            totalSpentIPSneakAttack = nakSneakAttack - nakTrickleSneakAttack - startingPointsSkills;
            totalSpentIPBrawl = nakBrawl - nakTrickleBrawl - startingPointsSkills;
            totalSpentIPFastAttack = nakFastAttack - nakTrickleFastAttack - startingPointsSkills;
            totalSpentIPDimach = nakDimach - nakTrickleDimach - startingPointsSkills;
            totalSpentIPRipost = nakRipost - nakTrickleRipost - startingPointsSkills;
            totalSpentIPPistol = nakPistol - nakTricklePistol - startingPointsSkills;
            totalSpentIPBow = nakBow - nakTrickleBow - startingPointsSkills;
            totalSpentIPSubMachineGun = nakSubMachineGun - nakTrickleSubMachineGun - startingPointsSkills;
            totalSpentIPAssultRifle = nakAssultRifle - nakTrickleAssultRifle - startingPointsSkills;
            totalSpentIPShotgun = nakShotgun - nakTrickleShotgun - startingPointsSkills;
            totalSpentIPRifle = nakRifle - nakTrickleRifle - startingPointsSkills;
            totalSpentIPRangedEnergy = nakRangedEnergy - nakTrickleRangedEnergy - startingPointsSkills;
            totalSpentIPGrenade = nakGrenade - nakTrickleGrenade - startingPointsSkills;
            totalSpentIPHeavyWeapons = nakHeavyWeapons - nakTrickleHeavyWeapons - startingPointsSkills;
            totalSpentIPMultiRanged = nakMultiRanged - nakTrickleMultiRanged - startingPointsSkills;
            totalSpentIPRangedInit = nakRangedInit - nakTrickleRangedInit - startingPointsSkills;
            totalSpentIPFlingShot = nakFlingShot - nakTrickleFlingShot - startingPointsSkills;
            totalSpentIPAimedShot = nakAimedShot - nakTrickleAimedShot - startingPointsSkills;
            totalSpentIPBurst = nakBurst - nakTrickleBurst - startingPointsSkills;
            totalSpentIPFullAuto = nakFullAuto - nakTrickleFullAuto - startingPointsSkills;
            totalSpentIPBowSpcAtk = nakBowSpcAtk - nakTrickleBowSpcAtk - startingPointsSkills;
            totalSpentIPSharpObjects = nakSharpObjects - nakTrickleSharpObjects - startingPointsSkills;
            totalSpentIPMaterMet = nakMaterMet - nakTrickleMaterMet - startingPointsSkills;
            totalSpentIPBioMet = nakBioMet - nakTrickleBioMet - startingPointsSkills;
            totalSpentIPPsychoMod = nakPsychoMod - nakTricklePsychoMod - startingPointsSkills;
            totalSpentIPSenseImp = nakSenseImp - nakTrickleSenseImp - startingPointsSkills;
            totalSpentIPTimeSpace = nakTimeSpace - nakTrickleTimeSpace - startingPointsSkills;
            totalSpentIPMaterCrea = nakMaterCrea - nakTrickleMaterCrea - startingPointsSkills;
            totalSpentIPNanoCInit = nakNanoCInit - nakTrickleNanoCInit - startingPointsSkills;
            totalSpentIPVehAir = nakVehAir - nakTrickleVehAir - startingPointsSkills;
            totalSpentIPVehGround = nakVehGround - nakTrickleVehGround - startingPointsSkills;
            totalSpentIPVehWater = nakVehWater - nakTrickleVehWater - startingPointsSkills;
            totalSpentIPAdventuring = nakAdventuring - nakTrickleAdventuring - startingPointsSkills;
            totalSpentIPRunSpeed = nakRunSpeed - nakTrickleRunSpeed - startingPointsSkills;
            totalSpentIPPerception = nakPerception - nakTricklePerception - startingPointsSkills;
            totalSpentIPConcealment = nakConcealment - nakTrickleConcealment - startingPointsSkills;
            totalSpentIPPsychology = nakPsychology - nakTricklePsychology - startingPointsSkills;
            totalSpentIPTrapDisarm = nakTrapDisarm - nakTrickleTrapDisarm - startingPointsSkills;
            totalSpentIPFirstAid = nakFirstAid - nakTrickleFirstAid - startingPointsSkills;
            totalSpentIPTreatment = nakTreatment - nakTrickleTreatment - startingPointsSkills;
            totalSpentIPMechanicalEng = nakMechanicalEng - nakTrickleMechanicalEng - startingPointsSkills;
            totalSpentIPElectricalEng = nakElectricalEng - nakTrickleElectricalEng - startingPointsSkills;
            totalSpentIPFieldQuantumPhy = nakFieldQuantumPhy - nakTrickleFieldQuantumPhy - startingPointsSkills;
            totalSpentIPChemestry = nakChemestry - nakTrickleChemestry - startingPointsSkills;
            totalSpentIPWeaponSmithing = nakWeaponSmithing - nakTrickleWeaponSmithing - startingPointsSkills;
            totalSpentIPNanoProgramming = nakNanoProgramming - nakTrickleNanoProgramming - startingPointsSkills;
            totalSpentIPTutoring = nakTutoring - nakTrickleTutoring - startingPointsSkills;
            totalSpentIPBreakingEntering = nakBreakingEntering - nakTrickleBreakingEntering - startingPointsSkills;
            totalSpentIPComputerLiteracy = nakComputerLiteracy - nakTrickleComputerLiteracy - startingPointsSkills;
            totalSpentIPPharma = nakPharma - nakTricklePharma - startingPointsSkills;
            totalSpentIPSwim = nakSwim - nakTrickleSwim - startingPointsSkills;
            totalSpentIPMapNav = nakMapNav - nakTrickleMapNav - startingPointsSkills;

            // total skill after trickledown added in
            totalBdyDev = nakBdyDev + trickleAddedAbiOnlyBdyDev + addedBdyDev; // G-Skill
            totalNanoPool = nakNanoPool + trickleAddedAbiOnlyNanoPool + addedNanoPool;
            totalEvadeClsCombat = nakEvadeClsCombat + trickleAddedAbiOnlyEvadeClsCombat + addedEvadeClsCombat;
            totalDodgeRanged = nakDodgeRanged + trickleAddedAbiOnlyDodgeRanged + addedDodgeRanged;
            totalDuckExpl = nakDuckExpl + trickleAddedAbiOnlyDuckExpl + addedDuckExpl;
            totalNanoResist = nakNanoResist + trickleAddedAbiOnlyNanoResist + addedNanoResist;
            totalParry = nakParry + trickleAddedAbiOnlyParry + addedParry;
            total1HB = nak1HB + trickleAddedAbiOnly1HB + added1HB;
            total1HE = nak1HE + trickleAddedAbiOnly1HE + added1HE;
            totalPiercing = nakPiercing + trickleAddedAbiOnlyPiercing + addedPiercing;
            total2HB = nak2HB + trickleAddedAbiOnly2HB + added2HB;
            total2HE = nak2HE + trickleAddedAbiOnly2HE + added2HE;
            totalMeleeEnergy = nakMeleeEnergy + trickleAddedAbiOnlyMeleeEnergy + addedMeleeEnergy;
            totalMartialArts = nakMartialArts + trickleAddedAbiOnlyMartialArts + addedMartialArts;
            totalMultiMelee = nakMultiMelee + trickleAddedAbiOnlyMultiMelee + addedMultiMelee;
            totalMeleeInit = nakMeleeInit + trickleAddedAbiOnlyMeleeInit + addedMeleeInit;
            totalPhysicalInit = nakPhysicalInit + trickleAddedAbiOnlyPhysicalInit + addedPhysicalInit;
            totalSneakAttack = nakSneakAttack + trickleAddedAbiOnlySneakAttack + addedSneakAttack;
            totalBrawl = nakBrawl + trickleAddedAbiOnlyBrawl + addedBrawl;
            totalFastAttack = nakFastAttack + trickleAddedAbiOnlyFastAttack + addedFastAttack;
            totalDimach = nakDimach + trickleAddedAbiOnlyDimach + addedDimach;
            totalRipost = nakRipost + trickleAddedAbiOnlyRipost + addedRipost;
            totalPistol = nakPistol + trickleAddedAbiOnlyPistol + addedPistol;
            totalBow = nakBow + trickleAddedAbiOnlyBow + addedBow;
            totalSubMachineGun = nakSubMachineGun + trickleAddedAbiOnlySubMachineGun + addedSubMachineGun;
            totalAssultRifle = nakAssultRifle + trickleAddedAbiOnlyAssultRifle + addedAssultRifle;
            totalShotgun = nakShotgun + trickleAddedAbiOnlyShotgun + addedShotgun;
            totalRifle = nakRifle + trickleAddedAbiOnlyRifle + addedRifle;
            totalRangedEnergy = nakRangedEnergy + trickleAddedAbiOnlyRangedEnergy + addedRangedEnergy;
            totalGrenade = nakGrenade + trickleAddedAbiOnlyGrenade + addedGrenade;
            totalHeavyWeapons = nakHeavyWeapons + trickleAddedAbiOnlyHeavyWeapons + addedHeavyWeapons;
            totalMultiRanged = nakMultiRanged + trickleAddedAbiOnlyMultiRanged + addedMultiRanged;
            totalRangedInit = nakRangedInit + trickleAddedAbiOnlyRangedInit + addedRangedInit;
            totalFlingShot = nakFlingShot + trickleAddedAbiOnlyFlingShot + addedFlingShot;
            totalAimedShot = nakAimedShot + trickleAddedAbiOnlyAimedShot + addedAimedShot;
            totalBurst = nakBurst + trickleAddedAbiOnlyBurst + addedBurst;
            totalFullAuto = nakFullAuto + trickleAddedAbiOnlyFullAuto + addedFullAuto;
            totalBowSpcAtk = nakBowSpcAtk + trickleAddedAbiOnlyBowSpcAtk + addedBowSpcAtk;
            totalSharpObjects = nakSharpObjects + trickleAddedAbiOnlySharpObjects + addedSharpObjects;
            totalMaterMet = nakMaterMet + trickleAddedAbiOnlyMaterMet + addedMaterMet;
            totalBioMet = nakBioMet + trickleAddedAbiOnlyBioMet + addedBioMet;
            totalPsychoMod = nakPsychoMod + trickleAddedAbiOnlyPsychoMod + addedPsychoMod;
            totalSenseImp = nakSenseImp + trickleAddedAbiOnlySenseImp + addedSenseImp;
            totalTimeSpace = nakTimeSpace + trickleAddedAbiOnlyTimeSpace + addedTimeSpace;
            totalMaterCrea = nakMaterCrea + trickleAddedAbiOnlyMaterCrea + addedMaterCrea;
            totalNanoCInit = nakNanoCInit + trickleAddedAbiOnlyNanoCInit + addedNanoCInit;
            totalVehAir = nakVehAir + trickleAddedAbiOnlyVehAir + addedVehAir;
            totalVehGround = nakVehGround + trickleAddedAbiOnlyVehGround + addedVehGround;
            totalVehWater = nakVehWater + trickleAddedAbiOnlyVehWater + addedVehWater;
            totalAdventuring = nakAdventuring + trickleAddedAbiOnlyAdventuring + addedAdventuring;
            totalRunSpeed = nakRunSpeed + trickleAddedAbiOnlyRunSpeed + addedRunSpeed;
            totalPerception = nakPerception + trickleAddedAbiOnlyPerception + addedPerception;
            totalConcealment = nakConcealment + trickleAddedAbiOnlyConcealment + addedConcealment;
            totalPsychology = nakPsychology + trickleAddedAbiOnlyPsychology + addedPsychology;
            totalTrapDisarm = nakTrapDisarm + trickleAddedAbiOnlyTrapDisarm + addedTrapDisarm;
            totalFirstAid = nakFirstAid + trickleAddedAbiOnlyFirstAid + addedFirstAid;
            totalTreatment = nakTreatment + trickleAddedAbiOnlyTreatment + addedTreatment;
            totalMechanicalEng = nakMechanicalEng + trickleAddedAbiOnlyMechanicalEng + addedMechanicalEng;
            totalElectricalEng = nakElectricalEng + trickleAddedAbiOnlyElectricalEng + addedElectricalEng;
            totalFieldQuantumPhy = nakFieldQuantumPhy + trickleAddedAbiOnlyFieldQuantumPhy + addedFieldQuantumPhy;
            totalChemestry = nakChemestry + trickleAddedAbiOnlyChemestry + addedChemestry;
            totalWeaponSmithing = nakWeaponSmithing + trickleAddedAbiOnlyWeaponSmithing + addedWeaponSmithing;
            totalNanoProgramming = nakNanoProgramming + trickleAddedAbiOnlyNanoProgramming + addedNanoProgramming;
            totalTutoring = nakTutoring + trickleAddedAbiOnlyTutoring + addedTutoring;
            totalBreakingEntering = nakBreakingEntering + trickleAddedAbiOnlyBreakingEntering + addedBreakingEntering;
            totalComputerLiteracy = nakComputerLiteracy + trickleAddedAbiOnlyComputerLiteracy + addedComputerLiteracy;
            totalPharma = nakPharma + trickleAddedAbiOnlyPharma + addedPharma;
            totalSwim = nakSwim + trickleAddedAbiOnlySwim + addedSwim;
            totalMapNav = nakMapNav + trickleAddedAbiOnlyMapNav + addedMapNav;



            // show values in text box's 
            // - I dont need to show the spentIP, naktrickle, totaltrickle, trickleaddedabionly, or total spent IP
            // as i have not created text boxes for them and the user doesnt need to see them - also the starting ability and skill points are
            // not correct but they dont break my program unless i take them out - I know i have some updating to do to this formula
            // but the formula works as expected for now. So I will only show whats needed for now, just the total abilities and skills
            //spentIPStmTxtBox1.Text = spentIPStm.ToString(); // F-ability

            totalStrTxtBox.Text = totalStr.ToString();
            totalAgiTxtBox.Text = totalAgi.ToString();
            totalStmTxtBox.Text = totalStm.ToString(); // G-ability
            totalIntTxtBox.Text = totalInt.ToString();
            totalSenTxtBox.Text = totalSen.ToString();
            totalPsyTxtBox.Text = totalPsy.ToString();

            //nakTrickleBdyDevTxtBox1.Text = nakTrickleBdyDev.ToString(); // C-nakTrickle
            //totalTrickleBdyDevTxtBox1.Text = totalTrickleBdyDev.ToString(); // D-totalTrickle
            //trickleAddedAbiOnlyBdyDevTxtBox1.Text = trickleAddedAbiOnlyBdyDev.ToString(); // E-addedTrickle
            //totalSpentIPBdyDevTxtBox1.Text = totalSpentIPBdyDev.ToString(); // F-skill

            totalBdyDevTxtBox.Text = totalBdyDev.ToString(); // G-skill
            totalNanoPoolTxtBox.Text = totalNanoPool.ToString();
            totalEvadeClsCombatTxtBox.Text = totalEvadeClsCombat.ToString();
            totalDodgeRangedTxtBox.Text = totalDodgeRanged.ToString();
            totalDuckExplTxtBox.Text = totalDuckExpl.ToString();
            totalNanoResistTxtBox.Text = totalNanoResist.ToString();
            totalParryTxtBox.Text = totalParry.ToString();
            total1HBTxtBox.Text = total1HB.ToString();
            total1HETxtBox.Text = total1HE.ToString();
            totalPiercingTxtBox.Text = totalPiercing.ToString();
            total2HBTxtBox.Text = total2HB.ToString();
            total2HETxtBox.Text = total2HE.ToString();
            totalMeleeEnergyTxtBox.Text = totalBdyDev.ToString();
            totalMartialArtsTxtBox.Text = totalMartialArts.ToString();
            totalMultiMeleeTxtBox.Text = totalMultiMelee.ToString();
            totalMeleeInitTxtBox.Text = totalMeleeInit.ToString();
            totalPhysicalInitTxtBox.Text = totalPhysicalInit.ToString();
            totalSneakAttackTxtBox.Text = totalSneakAttack.ToString();
            totalBrawlTxtBox.Text = totalBrawl.ToString();
            totalFastAttackTxtBox.Text = totalFastAttack.ToString();
            totalDimachTxtBox.Text = totalDimach.ToString();
            totalRipostTxtBox.Text = totalRipost.ToString();
            totalPistolTxtBox.Text = totalPistol.ToString();
            totalBowTxtBox.Text = totalBow.ToString();
            totalSubMachineGunTxtBox.Text = totalSubMachineGun.ToString();
            totalAssultRifleTxtBox.Text = totalAssultRifle.ToString();
            totalShotgunTxtBox.Text = totalShotgun.ToString();
            totalRifleTxtBox.Text = totalRifle.ToString();
            totalRangedEnergyTxtBox.Text = totalRangedEnergy.ToString();
            totalGrenadeTxtBox.Text = totalGrenade.ToString();
            totalHeavyWeaponsTxtBox.Text = totalHeavyWeapons.ToString();
            totalMultiRangedTxtBox.Text = totalMultiRanged.ToString();
            totalRangedInitTxtBox.Text = totalRangedInit.ToString();
            totalFlingShotTxtBox.Text = totalFlingShot.ToString();
            totalAimedShotTxtBox.Text = totalAimedShot.ToString();
            totalBurstTxtBox.Text = totalBurst.ToString();
            totalFullAutoTxtBox.Text = totalFullAuto.ToString();
            totalBowSpcAtkTxtBox.Text = totalBowSpcAtk.ToString();
            totalSharpObjectsTxtBox.Text = totalSharpObjects.ToString();
            totalMaterMetTxtBox.Text = totalMaterMet.ToString();
            totalBioMetTxtBox.Text = totalBioMet.ToString();
            totalPsychoModTxtBox.Text = totalPsychoMod.ToString();
            totalSenseImpTxtBox.Text = totalSenseImp.ToString();
            totalTimeSpaceTxtBox.Text = totalTimeSpace.ToString();
            totalMaterCreaTxtBox.Text = totalMaterCrea.ToString();
            totalNanoCInitTxtBox.Text = totalNanoCInit.ToString();
            totalVehAirTxtBox.Text = totalVehAir.ToString();
            totalVehGroundTxtBox.Text = totalVehGround.ToString();
            totalVehWaterTxtBox.Text = totalVehWater.ToString();
            totalAdventuringTxtBox.Text = totalAdventuring.ToString();
            totalRunSpeedTxtBox.Text = totalRunSpeed.ToString();
            totalPerceptionTxtBox.Text = totalPerception.ToString();
            totalConcealmentTxtBox.Text = totalConcealment.ToString();
            totalPsychologyTxtBox.Text = totalPsychology.ToString();
            totalTrapDisarmTxtBox.Text = totalTrapDisarm.ToString();
            totalFirstAidTxtBox.Text = totalFirstAid.ToString();
            totalTreatmentTxtBox.Text = totalTreatment.ToString();
            totalMechanicalEngTxtBox.Text = totalMechanicalEng.ToString();
            totalElectricalEngTxtBox.Text = totalElectricalEng.ToString();
            totalFieldQuantumPhyTxtBox.Text = totalFieldQuantumPhy.ToString();
            totalChemestryTxtBox.Text = totalChemestry.ToString();
            totalWeaponSmithingTxtBox.Text = totalWeaponSmithing.ToString();
            totalNanoProgrammingTxtBox.Text = totalNanoProgramming.ToString();
            totalTutoringTxtBox.Text = totalTutoring.ToString();
            totalBreakingEnteringTxtBox.Text = totalBreakingEntering.ToString();
            totalComputerLiteracyTxtBox.Text = totalComputerLiteracy.ToString();
            totalPharmaTxtBox.Text = totalPharma.ToString();
            totalSwimTxtBox.Text = totalSwim.ToString();
            totalMapNavTxtBox.Text = totalMapNav.ToString();


            // Properties.Settings.Default.Save();        
        }

        
        
    }
}