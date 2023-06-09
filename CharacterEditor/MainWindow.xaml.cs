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
        public MainWindow()
        {
            InitializeComponent();
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
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            currentCharacter.Strength += 1;
            lblStr.Content = currentCharacter.Strength;
            lblHealth.Content = currentCharacter.Health;
            lblPDamage.Content = currentCharacter.PhysDamage;
            lblArmor.Content = currentCharacter.Armor;
            lblWeight.Content = currentCharacter.Weight;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            currentCharacter.Strength -= 1;
            lblStr.Content = currentCharacter.Strength;
            lblHealth.Content = currentCharacter.Health;
            lblPDamage.Content = currentCharacter.PhysDamage;
            lblArmor.Content = currentCharacter.Armor;
            lblWeight.Content = currentCharacter.Weight;
        }
    }
}
