using System;
using System.ComponentModel.Composition;
using System.Linq;
using System.Windows.Forms;
using CustomClassTemplate.Gui;
using CustomClassTemplate.Objects;
using CustomClassTemplate.Settings;
using ZzukBot.Constants;
using ZzukBot.ExtensionFramework.Classes;
using ZzukBot.Game.Statics;
using ZzukBot.Mem;
using ZzukBot.Objects;

// CC By Bokutox with the major help of XHZ
// Thanks to Z0mg for the Template
// EnjoY!

namespace CustomClassTemplate
{
    [Export(typeof(CustomClass))]
    public class EmuClass : CustomClass
    {
        private Form CCGui = new CCGui();
        private Spellbook spellbook;
        /// <summary>
        /// The WoW class the CustomClass is designed for
        /// </summary>
        public override Enums.ClassId Class => Enums.ClassId.Mage;


       
        private bool CanCast(string parSpell)
        {
            return ZzukBot.Game.Statics.Spell.Instance.IsSpellReady(parSpell) && ZzukBot.Game.Statics.Spell.Instance.GetSpellRank(parSpell) != 0;
        }

        private void TryCast(string parSpell, int parWait = 0)
        {
            if (CanCast(parSpell))
            {
                ZzukBot.Game.Statics.Spell.Instance.CastWait(parSpell, parWait);
            }
        }
        /// <summary>
        /// Should be called when the CC is loaded
        /// </summary>
        /// <returns></returns>
        public override bool Load()
        {
            this.spellbook = new Spellbook();
            CustomClassSettings.Values.Load();
            return true;
        }

        /// <summary>
        /// Should be called when the CC is unloaded
        /// </summary>
        public override void Unload()
        {
        }

        /// <summary>
        /// Should be called when the botbase is pulling an unit
        /// </summary>
        public override void OnPull()
        {
            try
            {
                WoWUnit targetUnit = ObjectManager.Instance.Target;
                if (targetUnit == null) return;


                var damageSpells = this.spellbook.GetDamageSpells();

                foreach (var spell in damageSpells)
                {
                    if (spell.IsWanted)
                    {
                        spell.Cast();
                        spellbook.UpdateLastSpell(spell);
                        break;
                    }
                }
            }
            catch (Exception e)
            {

            }
        }

        /// <summary>
        /// Should be called when the botbase is fighting an unit
        /// </summary>
        public override void OnFight()
        {
            
            try
            {
                WoWUnit targetUnit = ObjectManager.Instance.Target;
                if (targetUnit == null) return;

                var damageSpells = this.spellbook.GetDamageSpells();

                foreach (var spell in damageSpells)
                {

                    if (ObjectManager.Instance.Player.HealthPercent <= 20)
                    {
                        ObjectManager.Instance.Items.FirstOrDefault(i => i.Name == CustomClassSettings.Values.HealthPot)
                               .Use();
                    }                   
                     
                    if (ObjectManager.Instance.Player.ManaPercent <= 20)
                    {
                        ObjectManager.Instance.Items.FirstOrDefault(i => i.Name == CustomClassSettings.Values.ManaPot)
                                  .Use();
                        ObjectManager.Instance.Items.FirstOrDefault(i => i.Name == CustomClassSettings.Values.ManaGem)
                                  .Use();
                    }

                    if (spell.IsWanted)
                    {
                        spell.Cast();
                        spellbook.UpdateLastSpell(spell);
                        break;
                    }
                }
            }
            catch(Exception e)
            {
                
            }
        }

      
       


        // -- CHECK THIS SHIT...

        public sealed class Mage
        {

            public int StackCount { get; private set; }

        }
 
        // CHECK THIS SHIT




        public override void OnRest()
        {
            
            //This needs to be tested & cleaned up
            MainThread.Instance.Invoke(() =>
            {
                try
                {

                    if (Inventory.Instance.GetItemCount(CustomClassSettings.Values.FoodName) <= 6)
                    {
                        if (CanCast("Conjure Food"))
                        {
                            TryCast("Conjure Food");

                        }

                    }
                    else if (!ObjectManager.Instance.Player.IsEating)
                    {
                        ObjectManager.Instance.Items.FirstOrDefault(i => i.Name == CustomClassSettings.Values.FoodName)
                            .Use();
                        ZzukBot.Helpers.Wait.For("EatMage", 500);
                    }

                    if (Inventory.Instance.GetItemCount(CustomClassSettings.Values.DrinkName) <= 6)
                    {
                        if (CanCast("Conjure Water"))
                        {
                            TryCast("Conjure Water");
                        }

                    }
                    else if (!ObjectManager.Instance.Player.IsDrinking)
                    {
                            ObjectManager.Instance.Items.FirstOrDefault(i => i.Name == CustomClassSettings.Values.DrinkName)
                                .Use();
                            ZzukBot.Helpers.Wait.For("DrinkMage", 500);
                    }

                    
                    
                }
                catch (Exception e)
                {

                }

            });
        }

        /// <summary>
        /// Should be called when the botbase is resting
        /// </summary>
        /// <returns>
        /// Returns true when the character is done buffing
        /// </returns>
        public override bool OnBuff()
        {
            try
            {
                if (Inventory.Instance.GetItemCount(CustomClassSettings.Values.FoodName) < 6)
            {
                if (CanCast("Conjure Food"))
                {
                    TryCast("Conjure Food");

                }

            }
            else if (Inventory.Instance.GetItemCount(CustomClassSettings.Values.DrinkName) < 6)
            {
                if (CanCast("Conjure Water"))
                {
                    TryCast("Conjure Water");

                }

            }
            else if (!ObjectManager.Instance.Player.GotAura(CustomClassSettings.Values.ElixirUse))
            {
                ObjectManager.Instance.Items.FirstOrDefault(i => i.Name == CustomClassSettings.Values.ElixirUse).Use();

            }


            else if (!ObjectManager.Instance.Player.GotAura(CustomClassSettings.Values.StamScroll))
            {
                ObjectManager.Instance.Items.FirstOrDefault(i => i.Name == CustomClassSettings.Values.StamScroll).Use();

            }


            else if (!ObjectManager.Instance.Player.GotAura(CustomClassSettings.Values.SpiritScroll))
            {
                ObjectManager.Instance.Items.FirstOrDefault(i => i.Name == CustomClassSettings.Values.SpiritScroll).Use();

            }


            else if (!ObjectManager.Instance.Player.GotAura(CustomClassSettings.Values.ProtScroll))
            {
                ObjectManager.Instance.Items.FirstOrDefault(i => i.Name == CustomClassSettings.Values.ProtScroll).Use();

            }


            else if (!ObjectManager.Instance.Player.IsMainhandEnchanted())
            {
                ObjectManager.Instance.Player.EnchantMainhandItem(CustomClassSettings.Values.WeaponEnch);

            }
            
                         
                                       
                var buffs = this.spellbook.GetBuffSpells();

                foreach (var spell in buffs)
                {                    
                   
                    if (spell.IsWanted)
                    {
                        spell.Cast();
                        return false;
                    }


                }
            }
            catch (Exception e)
            {

            }
            return true;
            
        }

        /// <summary>
        /// Should be called to show the settings form
        /// </summary>
        public override void ShowGui()
        {
            CCGui.Dispose();
            CCGui = new CCGui();
            CCGui.Show();
        }

        /// <summary>
        /// The name of the CC
        /// </summary>
        public override string Name => "BokutoxFrostMageV2";

        /// <summary>
        /// The author of the CC
        /// </summary>
        public override string Author => "Bokutox with the help of Xhz";

        /// <summary>
        /// The version of the CC
        /// </summary>
        public override int Version => 2;

        /// <summary>
        /// The current combat distance
        /// </summary>
        public override float CombatDistance => Data.Statics.CombatDistance;

    }
}
