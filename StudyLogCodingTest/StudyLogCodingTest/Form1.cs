using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyLogCodingTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public enum ErrorTypes
        {
            Method,//need to select randomization method
            Group,//need to select a group or groups
            Animals,//need to select animals
            Randomization//randomization error
        }

        IRandomizationMethod pureRandom = new PureRandomMethod();

        private void Form1_Load(object sender, EventArgs e)
        {
            this.sortingMethod_cb.Items.Add("Select type of method");
            this.sortingMethod_cb.Items.Add(PureRandomMethod._name);
            //set default method selection
            this.sortingMethod_cb.SelectedIndex = 0;
            //populate groups listbox
            loadGroups();
            //populate animals listbox
            loadAnimals();
        }

        private void randomize_btn_Click(object sender, EventArgs e)
        {
            //if randomization method is selected else show error
            if (this.sortingMethod_cb.SelectedIndex != 0)
            {
                /*
                 * validate selections and make a call to pure random
                 */
                if (this.sortingMethod_cb.SelectedItem.ToString().Equals("Pure Random"))
                {
                    if (this.groups_lst.SelectedItems != null && this.groups_lst.SelectedItems.Count == 2)
                    {
                        String[] selectedGroups = this.groups_lst.SelectedItems.Cast<String>().ToArray();
                       
                        if (this.animals_lst.SelectedItem != null && this.animals_lst.SelectedItems.Count == 10)
                        {
                            clearError();
                            Animal[] groupedAnimals = pureRandom.Randomize(selectedGroups, this.animals_lst.SelectedItems.Cast<Animal>().ToArray());
                            if (groupedAnimals != null)
                            {
                                foreach (Animal a in groupedAnimals)
                                {
                                    results_lst.Items.Add(new ListViewItem(new string[] { a.Group, a.NameTag, a.Weight.ToString("0.00") }));
                                }
                            }
                            else
                            {
                                showError(ErrorTypes.Randomization);
                            }
                        }
                        else
                        {
                            showError(ErrorTypes.Animals);
                        }
                    }
                    else
                    {
                        showError(ErrorTypes.Group);
                    }
                } else
                {
                    //some other randomization code goes here
                }
            }
            else
            {
                showError(ErrorTypes.Method);
            }
            
        }

        //hard code group 1 and 2
        private void loadGroups()
        {
            String[] groups = new String[2];
            groups[0] = "Group 1";
            groups[1] = "Group 2";
            this.groups_lst.Items.AddRange(groups);
        } 

        //create animals with name tag and body weight
        private void loadAnimals()
        {
            List<Animal> mice = new List<Animal>();
            Animal mouse1 = new Animal("m_001", 20.50f);
            mice.Add(mouse1);
            Animal mouse2 = new Animal("m_002", 28.20f);
            mice.Add(mouse2);
            Animal mouse3 = new Animal("m_003", 26.60f);
            mice.Add(mouse3);
            Animal mouse4 = new Animal("m_004", 29.10f);
            mice.Add(mouse4);
            Animal mouse5 = new Animal("m_005", 23.70f);
            mice.Add(mouse5);
            Animal mouse6 = new Animal("m_006", 24.30f);
            mice.Add(mouse6);
            Animal mouse7 = new Animal("m_007", 21.40f);
            mice.Add(mouse7);
            Animal mouse8 = new Animal("m_008", 27.80f);
            mice.Add(mouse8);
            Animal mouse9 = new Animal("m_009", 22.90f);
            mice.Add(mouse9);
            Animal mouse10 = new Animal("m_010", 30.00f);
            mice.Add(mouse10);

            this.animals_lst.DisplayMember = "nameTag";
            this.animals_lst.ValueMember = "Weight";

            foreach(var mouse in mice)
            {
                this.animals_lst.Items.Add(mouse);
            }
        }

        //manage errors on the page
        public void showError(ErrorTypes errorType)
        {
            this.message_lbl.ForeColor = System.Drawing.Color.Red;
            switch (errorType)
            {
                case ErrorTypes.Method:
                    {
                        this.message_lbl.Text = "Randomization method must be selected from the dropdown.";
                        break;
                    }
                case ErrorTypes.Group:
                    {
                        this.message_lbl.Text = "Two groups must be selected for randomization to work.";
                        break;
                    }
                case ErrorTypes.Animals:
                    {
                        this.message_lbl.Text = "Ten animals must be selected for randomization to work.";
                        break;
                    }
                case ErrorTypes.Randomization:
                    {
                        this.message_lbl.Text = "Randomization failed.";
                        break;
                    }
                default:
                    {
                        this.message_lbl.Text = "Unknown error.";
                        break;
                    }
            }
        }

        //clear any error on the page
        public void clearError()
        {
            this.message_lbl.Text = "";
        }
    }
}
