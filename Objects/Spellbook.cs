using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ZzukBot.ExtensionFramework.Classes;
using ZzukBot.Game.Statics;
using ZzukBot.Objects;
using CustomClassTemplate.Data;

namespace CustomClassTemplate.Objects
{
    internal class Spellbook
    {
        private static Spell lastSpell = new Spell(string.Empty, -1, false, false);

        private List<Spell> spells;

        //-------------------------------------------------------------------------------------------------------
        // Survival Spells - Not buff but doesn't do damage            Prio - Buff - Dmg - insta
        // Mana Shield
        public static readonly Spell Sheild = new Spell("Mana Shield", 2000, false, true, true,
            isWanted:
                () =>
                    Helpers.CanCast("Mana Shield") && Me.IsInCombat &&
                    Me.HealthPercent <= 25,
                customAction:
                () =>
                {
                    //Make sure it's cast on us!
                    Helpers.TryBuff("Mana Shield");
                });
        //-------------------------------------------------------------------------------------------------------

        // Evocation

        public static readonly Spell Evocation = new Spell("Evocation", 1900, false, true, true, isChanneled: true,
            isWanted:
                () =>
                    Helpers.CanCast("Evocation") &&
                    Me.ManaPercent <= 20
                );
        //-------------------------------------------------------------------------------------------------------
        //Ice Block
        public static readonly Spell IceBlock = new Spell("Ice Block", 1700, false, true, true,
            isWanted:
                () =>
                    Helpers.CanCast("Ice Block") && Me.IsInCombat
                    && Me.HealthPercent <= 10,
                customAction:
                () =>
                {
                    //Make sure it's cast on us!
                    Helpers.TryCast("Ice Block");
                });
        //-------------------------------------------------------------------------------------------------------
        // Ice Barrier
        public static readonly Spell Barrier = new Spell("Ice Barrier", 1600, false, true, true,
    isWanted:
        () =>
            Helpers.CanCast("Ice Barrier") && Me.GotAura("Ice Barrier") && Me.IsInCombat,
        customAction:
        () =>
        {
            //Make sure it's cast on us!
            Helpers.TryCast("Ice Barrier");
        });
        // Sheep - if More than 2 Targts , then Cast sheep and Pwn one of them
        // Water
        //-------------------------------------------------------------------------------------------------------
        // Damage Spells                                      NAME     Prio - Buff - Dmg - insta
        //Frostbolt
        public static readonly Spell Frostbolt = new Spell("Frostbolt", 500, false, true,
        isWanted:
            () =>
                Helpers.CanCast("Frostbolt"));
        //-------------------------------------------------------------------------------------------------------
        // Damage Spells                                      NAME     Prio - Buff - Dmg - insta
        //Frostbolt
        public static readonly Spell Fireball = new Spell("Fireball", 600, false, true,
        isWanted:
            () =>
                !Helpers.CanCast("Frostbolt") && Helpers.CanCast("Fireball"), customAction:
            () =>
            {
                Helpers.TryCast("Fireball");
            });
        //-------------------------------------------------------------------------------------------------------
        //Frost Nova                                            NAME      Prio - Buff - Dmg - insta
        public static readonly Spell FrostNova = new Spell("Frost Nova", 700, false, true,
            isWanted:
                () =>
                    Helpers.CanCast("Frost Nova") && Target.Position.GetDistanceTo(Me.Position) <= 5, customAction:
                () =>
                {
                    Helpers.TryCast("Frost Nova");
                });
        //-------------------------------------------------------------------------------------------------------
        // Fire Blast                                            NAME    Prio , Buff , Dmg , insta
        public static readonly Spell FireBlast = new Spell("Fire Blast", 800, false, true, true,
            isWanted:
                () =>
                    Helpers.CanCast("Fire Blast") && Target.Position.GetDistanceTo(Me.Position) <= 20, customAction:
                () =>
                {
                    Helpers.TryCast("Fire Blast");
                });
        //-------------------------------------------------------------------------------------------------------
        // Cone of Cold                                          NAME       Prio , Buff , Dmg , insta
        public static readonly Spell ConeOfCold = new Spell("Cone of Cold", 900, false, true, true,
            isWanted:
                () =>
                   Helpers.CanCast("Cone of Cold") && (Target.GotDebuff("Frost Nova") || Target.GotDebuff("Freeze")), customAction:
                () =>
                {
                    Helpers.TryCast("Cone of Cold");
                });
        //-------------------------------------------------------------------------------------------------------
        // Counterspell                                          NAME       Prio , Buff , Dmg , insta
        public static readonly Spell Counterspell = new Spell("Countrspell", 1000, false, true, true,
           isWanted:
               () =>
                   Helpers.CanCast("Counterspell") && (Target.Casting != 0 || Target.Casting != 0), customAction:
                () =>
                {
                    Helpers.TryCast("Counterspell");
                });
        //-------------------------------------------------------------------------------------------------------

        // Buff Spells
         
        // Arcane Intellect                                             NAME        Prio , Buff , Dmg , insta

        public static readonly Spell ArcaneIntellect = new Spell("Arcane Intellect", 1500, true, false,
            isWanted:
                () =>
                    Helpers.CanCast("Arcane Intellect") && !Me.GotAura("Arcane Intellect"), customAction:
                () =>
                {
                    //--Custom Action - SelfCasting--//
                    Data.Helpers.TryBuff("Arcane Intellect");
                });

        //-------------------------------------------------------------------------------------------------------

        // Dampen Magic                                           NAME        Prio , Buff , Dmg , insta

        public static readonly Spell DampenMagic = new Spell("Dampen Magic", 1400, true, false,
            isWanted:
               () =>
                   Helpers.CanCast("Dampen Magic") &&
                   !Me.GotAura("Dampen Magic"), customAction:
                () =>
                {
                    //--Custom Action - SelfCasting--//
                    Data.Helpers.TryBuff("Dampen Magic");
                });

        //-------------------------------------------------------------------------------------------------------
        // Armor Buffs
        //Cast Mage Armor only if we have Ice Barrier
        public static readonly Spell MageArmor = new Spell("Mage Armor", 1300, true, false,
            isWanted:
                () =>
                   Helpers.CanCast("Ice Barrier") && !Me.GotAura("Mage Armor"), customAction:
                () =>
                {
                    //--Custom Action - SelfCasting--//
                    Data.Helpers.TryCast("Ice Barrier");
                });

        //Cast Frost Armor only if we cant cast Mage armor and Cant cast Ice Armor
        public static readonly Spell FrostArmor = new Spell("Frost Armor", 1100, true, false,
            isWanted:
                () =>
                   !Helpers.CanCast("Ice Barrier") && !Helpers.CanCast("Ice Armor") && !Me.GotAura("Frost Armor") &&
                   Helpers.CanCast("Frost Armor"), customAction:
                () =>
                {
                    //--Custom Action - SelfCasting--//
                    Data.Helpers.TryCast("Frost Armor");
                });

                  //Cast Ice Armor only if we cant cast Ice Barrier -- Otherwise it will cast Mage Armor
        public static readonly Spell IceArmor = new Spell("ice Armor", 1200, true, false,
            isWanted:
                () =>
                   !Helpers.CanCast("Ice Barrier") && !Me.GotAura("Ice Armor") &&
                   Helpers.CanCast("Ice Armor"), customAction:
                () =>
                {
                    //--Custom Action - SelfCasting--//
                    Data.Helpers.TryCast("Ice Armor");
                });
        //-------------------------------------------------------------------------------------------------------
        // Misc  Wand
        public static readonly Spell Wand = new Spell("Shoot", 650, false, false, true, true, isWanted: () =>
        {
            return Helpers.CanWand() && (Me.ManaPercent <= 8 || Target.HealthPercent <= 5);
        }, customAction: () => ZzukBot.Game.Statics.Spell.Instance.StartWand());


        // Auto Attack
        public static readonly Spell Attack = new Spell("Attack", Int32.MinValue, false, true, true, false,
            () => !Helpers.CanWand() && Helpers.CanCast("Attack"), customAction:
                () =>
                {
                    ZzukBot.Game.Statics.Spell.Instance.Attack();
                });

        public Spellbook()
        {
            this.spells = new List<Spell>();
            this.InitializeSpellbook();
        }

        public IEnumerable<Spell> GetDamageSpells()
        {
            return Cache.Instance.GetOrStore("damageSpells", () => this.spells.Where(s => !s.IsBuff));
        }

        public IEnumerable<Spell> GetBuffSpells()
        {
            return Cache.Instance.GetOrStore("buffSpells", () => this.spells.Where(s => s.IsBuff && !s.DoesDamage));
        }

        public void UpdateLastSpell(Spell spell)
        {
            lastSpell = spell;
        }

        private void InitializeSpellbook()
        {
            foreach (var property in this.GetType().GetFields())
            {
                spells.Add(property.GetValue(property) as Spell);
            }

            spells = spells.OrderByDescending(s => s.Priority).ToList();
        }

        private static WoWUnit Me
        {
            get { return ObjectManager.Instance.Player; }
        }

        private static WoWUnit Target
        {
            get { return ObjectManager.Instance.Target; }
        }

        private static WoWUnit Pet
        {
            get { return ObjectManager.Instance.Pet; }
        }
    }
}
