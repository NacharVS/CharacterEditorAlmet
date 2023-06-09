using CharacterEditor.Arsenal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CharacterEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ICharacter currentCharacter;

        List<Weapon> weapons;
        public MainWindow()
        {
            InitializeComponent();
            weapons = new List<Weapon>()
            {
                new Club(), new IronSword(),new SilverAxe()
            };
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (chrctChoosing.SelectedIndex == 0)
            {
                currentCharacter = Warrior.CreateWarrior(txtName.Text);
                lblStr.Content = currentCharacter.Strength;
                lblDex.Content = currentCharacter.Dexterity;
                lblInt.Content = currentCharacter.Intelligence;
                lblCon.Content = currentCharacter.Constitution;
                lblHealth.Content = currentCharacter.Health;
                lblEnegry.Content = currentCharacter.Energy;
                lblPDamage.Content = currentCharacter.PhysDamage;
                lblArmor.Content = currentCharacter.Armor;
                lblWeight.Content = currentCharacter.Weight;
                lblPoints.Content = currentCharacter.CharPoints;
                lblLvl.Content = currentCharacter.Level;
                lblCurrenExp.Content = currentCharacter.CurrentExp;
                lblNeedExp.Content = currentCharacter.NeededExpirience;
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {          
            currentCharacter.StrenghtIncrease(ref lblHealth, ref lblStr, ref lblWeight, ref lblPDamage, ref lblArmor, ref  lblPoints);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            currentCharacter.StrenghtDecrease(ref lblHealth, ref lblStr, ref lblWeight, ref lblPDamage, ref lblArmor, ref lblPoints);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            currentCharacter.ExpGain(100);
            lblNeedExp.Content = currentCharacter.NeededExpirience;
            lblCurrenExp.Content = currentCharacter.CurrentExp;
        }

        private void lBoxWeapons_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (var item in weapons)
            {
                lBoxWeapons.Items.Add(item.WeaponType);
            }
        }

        private void lBoxWeapons_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (lBoxWeapons.SelectedItem.ToString())
            {
                case "Club":
                    { 
                        lblPDamage.Content = (int.Parse(lblPDamage.Content.ToString()) + weapons[0].Damage).ToString();
                    }
                    break;
            }
        }
    }
}
