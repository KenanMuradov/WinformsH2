using System.Text.Json;
using System.Text.RegularExpressions;

namespace Questionnaire
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool isLoaded = false;


        private void btnLoad_Click(object sender, EventArgs e)
        {
            DirectoryInfo directory = new($@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\QuestionnairiesForms");

            if (!directory.Exists)
            {
                MessageBox.Show("No Data Found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLoadFile.Text))
            {
                MessageBox.Show("Load File Name Must be Filled", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            InformationForm form = null!;

            foreach (var file in directory.GetFiles())
            {
                if (file.Name.Contains(txtLoadFile.Text))
                    form = JsonSerializer.Deserialize<InformationForm>(File.ReadAllText(file.FullName))!;
            }

            if (isLoaded && form != null && form?.Name?.ToLower() == txtName.Text)
                return;

            if (form != null)
            {
                txtName.Text = form.Name;
                txtSurname.Text = form.Surname;
                txtFatherName.Text = form.FatherName;
                txtCountry.Text = form.Country;
                txtCity.Text = form.City;
                txtPhone.Text = form.Phone;
                if (form.Gender == "Male")
                    rbMale.Checked = true;
                else
                    rbFemale.Checked = true;

                birthDatePicker.Value = form.BirthDate;

                btnSave.Text = "Clear";
                isLoaded = true;
                return;
            }

            MessageBox.Show("File Doesn't Exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isLoaded)
            {
                foreach (var control in gbQuestionnaire.Controls)
                {
                    if (control is TextBox txtBox)
                        txtBox.Text = String.Empty;
                    else if (control is DateTimePicker date)
                        date.Text = default;
                    else if (control is RadioButton radioButton)
                        radioButton.Checked = false;
                }

                btnSave.Text = "Save";
                isLoaded = false;
                return;
            }


            string? wordPattern = @"^[\w'\-,.][^0-9_!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:[\]]{2,}$";
            string? phonePattern = @"^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$";

            if (!Regex.Match(txtName.Text, wordPattern).Success || txtName.TextLength < 3)
            {
                MessageBox.Show("Name is invalid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.Match(txtSurname.Text, wordPattern).Success || txtSurname.TextLength < 4)
            {
                MessageBox.Show("Surname is invalid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.Match(txtFatherName.Text, wordPattern).Success || txtFatherName.TextLength < 4)
            {
                MessageBox.Show("Father name is invalid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.Match(txtCountry.Text, wordPattern).Success || txtCountry.TextLength < 4)
            {
                MessageBox.Show("Country name is invalid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.Match(txtCity.Text, wordPattern).Success || txtCity.TextLength < 4)
            {
                MessageBox.Show("City name is invalid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.Match(txtPhone.Text, phonePattern).Success)
            {
                MessageBox.Show("Phone number is invalid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if ((DateTime.Now - birthDatePicker.Value).Days / 365 < 18)
            {
                MessageBox.Show("Age doesn't match", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!rbMale.Checked && !rbFemale.Checked)
            {
                MessageBox.Show("Gender has to be choosen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = txtName.Text;
            string surname = txtSurname.Text;
            string fatherName = txtFatherName.Text;
            string country = txtCountry.Text;
            string city = txtCity.Text;
            string phone = txtPhone.Text;
            string gender;
            if (rbMale.Checked)
                gender = rbMale.Text;
            else
                gender = rbFemale.Text;


            DirectoryInfo directory = new($@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\QuestionnairiesForms");

            if (!directory.Exists)
                Directory.CreateDirectory(directory.FullName);

            File.WriteAllText($@"{directory.FullName}\{txtName.Text}.json", JsonSerializer.Serialize(new InformationForm(name, surname, fatherName, country, city, phone, gender, birthDatePicker.Value)));


        }


    }
}