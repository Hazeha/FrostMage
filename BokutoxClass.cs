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
using ZzukBot.Helpers.PPather;

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
                    

                    if (Inventory.Instance.GetItemCount(CustomClassSettings.Values.HealthPot) > 0)
                    {
                        if (ObjectManager.Instance.Player.HealthPercent <= 20)
                        {
                            ObjectManager.Instance.Items.FirstOrDefault(i => i.Name == CustomClassSettings.Values.HealthPot)
                                   .Use();
                        }
                    }
                    if (Inventory.Instance.GetItemCount(CustomClassSettings.Values.ManaPot) > 0)
                    {
                        if (ObjectManager.Instance.Player.ManaPercent <= 20)
                        {
                            ObjectManager.Instance.Items.FirstOrDefault(i => i.Name == CustomClassSettings.Values.ManaPot)
                                      .Use();
                            ObjectManager.Instance.Items.FirstOrDefault(i => i.Name == CustomClassSettings.Values.ManaGem)
                                      .Use();
                        }
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
        
        public override void OnRest()
        {
            
            //This needs to be tested & cleaned up
            MainThread.Instance.Invoke(() =>
            {
                try
                {
                   /* if (Inventory.Instance.GetItemCount(CustomClassSettings.Values.ElixirUse) > 0)
                    {
                        if (!ObjectManager.Instance.Player.GotAura(CustomClassSettings.Values.ElixirUse))
                        {
                            ObjectManager.Instance.Items.FirstOrDefault(i => i.Name == CustomClassSettings.Values.ElixirUse).Use();
                            ZzukBot.Helpers.Wait.For("", 500);
                        }
                    } */

                    if (Inventory.Instance.GetItemCount(CustomClassSettings.Values.StamScroll) > 0)
                    {
                        if (!ObjectManager.Instance.Player.GotAura("Stamina"))
                        {
                            ObjectManager.Instance.Items.FirstOrDefault(i => i.Name == CustomClassSettings.Values.StamScroll).Use();
                            ZzukBot.Helpers.Wait.For("Stamina", 500);
                        }
                    }

                    if (Inventory.Instance.GetItemCount(CustomClassSettings.Values.SpiritScroll) > 0)
                    {
                        if (!ObjectManager.Instance.Player.GotAura("Spirit"))
                        {
                            ObjectManager.Instance.Items.FirstOrDefault(i => i.Name == CustomClassSettings.Values.SpiritScroll).Use();
                            ZzukBot.Helpers.Wait.For("Spirit", 500);
                        }
                    }

                    if (Inventory.Instance.GetItemCount(CustomClassSettings.Values.ProtScroll) > 0)
                    {
                        if (!ObjectManager.Instance.Player.GotAura("Armor"))
                        {
                            ObjectManager.Instance.Items.FirstOrDefault(i => i.Name == CustomClassSettings.Values.ProtScroll).Use();
                            ZzukBot.Helpers.Wait.For("Armor", 500);
                        }
                    }

                    if (Inventory.Instance.GetItemCount(CustomClassSettings.Values.WeaponEnch) > 0)
                    {
                        if (!ObjectManager.Instance.Player.IsMainhandEnchanted())
                        {
                            ObjectManager.Instance.Player.EnchantMainhandItem(CustomClassSettings.Values.WeaponEnch);
                            ZzukBot.Helpers.Wait.For("", 500);
                        }
                    }

                    if (Inventory.Instance.GetItemCount(CustomClassSettings.Values.FoodName) < 6 && 
                        !ObjectManager.Instance.Player.IsEating)
                    {                        
                        for (int i = 0; i < 3;)
                        {
                            if (CanCast("Conjure Food") && !ObjectManager.Instance.Player.IsEating)
                            {
                                TryCast("Conjure Food");
                                ZzukBot.Helpers.Wait.For("Conjure Food", 2500);
                                i++;
                            }
                        }

                    }

                     if (Inventory.Instance.GetItemCount(CustomClassSettings.Values.DrinkName) < 6 && 
                    !ObjectManager.Instance.Player.IsEating)
                    {
                        
                        for (int i = 0; i < 3;)
                        {                            
                            if (CanCast("Conjure Water") && !ObjectManager.Instance.Player.IsEating)
                            {                            
                                TryCast("Conjure Water");
                                ZzukBot.Helpers.Wait.For("Conjure Water", 2500);
                                i++;
                            }                            
                        }
                    }

                    if (!ObjectManager.Instance.Player.IsEating)
                    {
                        ObjectManager.Instance.Items.FirstOrDefault(i => i.Name == CustomClassSettings.Values.FoodName)
                            .Use();
                        ZzukBot.Helpers.Wait.For("EatMage", 1500);
                    }

                   
                    if (!ObjectManager.Instance.Player.IsDrinking)
                    {
                            ObjectManager.Instance.Items.FirstOrDefault(i => i.Name == CustomClassSettings.Values.DrinkName)
                                .Use();
                            ZzukBot.Helpers.Wait.For("DrinkMage", 1500);
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
        public override string Name => "TestMageV-9000+";

        /// <summary>
        /// The author of the CC
        /// </summary>
        public override string Author => "Bokutox with the help of Xhz";

        /// <summary>
        /// The version of the CC
        /// </summary>
        public override int Version => 9001;

        /// <summary>
        /// The current combat distance
        /// </summary>
        public override float CombatDistance => Data.Statics.CombatDistance;

    }
}
