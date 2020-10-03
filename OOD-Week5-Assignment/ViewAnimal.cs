using OOD_Week5_Assignment.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOD_Week5_Assignment
{
    public partial class ViewAnimal : Form
    {
        private Animal animal;
        private string species;

        public ViewAnimal(Animal animal)
        {
            InitializeComponent();
            this.animal = animal;
            species = animal.GetType().ToString();
            ShowDetails();
        }

        // Shows all relevant details about the adoption in the various labels.
        private void ShowDetails()
        {
            labelAnimalName.Text = animal.Name;
            labelAnimalSpecies.Text = species.Substring(species.LastIndexOf('.') + 1);
            labelAnimalGender.Text = animal.Gender.ToString();
            labelAnimalAge.Text = animal.Age.ToString();
            richTextBoxNotes.Text = animal.Notes;
            if (animal.Adopted)
            {
                labelAnimalAdopted.Text = "Yes";
            }
            else
            {
                labelAnimalAdopted.Text = "No";
            }
        }
    }
}
