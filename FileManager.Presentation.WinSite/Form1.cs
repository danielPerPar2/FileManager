using FileManager.Common.Models;
using FileManager.DataAccess.DAO;
using FileManager.DataAccess.DAO.DAOFactoriesImpl;
using FileManager.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager.Presentation.WinSite
{
    public partial class Form1 : Form
    {
        public string language = Properties.Settings.Default.Language;

        private IAbstractStudentDAOFactory studentDAOFactory = null;
        
        private IAbstractStudentDAO studentDAOTxt = null;
        private IAbstractStudentDAO studentDAOXml = null;
        private IAbstractStudentDAO studentDAOJson = null;

        public Form1()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);

            InitializeComponent();
            InitializeDAOFactory();
            InitializeStudentDAOs();               }

        private void InitializeDAOFactory()
        {
            studentDAOFactory = new StudentDAOFactory();
        }

        private void InitializeStudentDAOs()
        {           
            studentDAOTxt = studentDAOFactory.CreateStudentDAOTxt();
            studentDAOXml = studentDAOFactory.CreateStudentDAOXml();
            studentDAOJson = studentDAOFactory.CreateStudentDAOJson();
        }

        private void BtnSaveTxt_Click(object sender, EventArgs e)
        {
            BtnSave(studentDAOTxt);
        }

        private Student CreateStudentFromFields()
        {
            int studentId = Int32.Parse(txtStudentId.Text);
            DateTime dateOfBirth = DateUtilities.StringToDateTimeES(txtDateOfBirth.Text);
            return new Student(studentId, txtName.Text, txtSurname.Text, dateOfBirth);
        }

        private void ClearFormFields()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.ResetText();
                }
            }
        }

        private void ShowPopUp(string message)
        {
            Form popup = new Popup(message);
            popup.ShowDialog();
            popup.Dispose();
        }

        private void BtnSaveXML_Click(object sender, EventArgs e)
        {
            BtnSave(studentDAOXml);
        }

        private void BtnSaveJSON_Click(object sender, EventArgs e)
        {
            BtnSave(studentDAOJson);
        }       

        private void EnglishToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChangeLanguage("en-GB");
            Properties.Settings.Default.Language = "en-GB";
        }

        private void SpanishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("es-ES");
            Properties.Settings.Default.Language = "es-ES";
        }

        private void ChangeLanguage(string language)
        {
            foreach(Control c in this.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
                resources.ApplyResources(c, c.Name, new CultureInfo(language));
            } 
        }

        private void BtnUpdateTxt_Click(object sender, EventArgs e)
        {
            BtnUpdate(studentDAOTxt);
        }

        private void BtnFindStudent_Click(object sender, EventArgs e)
        {
            BtnFind(studentDAOTxt);           
        }

        private void BtnBuscarXml_Click(object sender, EventArgs e)
        {
            BtnFind(studentDAOXml);           
        }

        private void BtnUpdateXml_Click(object sender, EventArgs e)
        {
            BtnUpdate(studentDAOXml);
        }

        private void BtnSave(IAbstractStudentDAO dao)
        {
            Student student = CreateStudentFromFields();
            dao.Add(student);
            //TODO: Check if the save operation is OK, otherwise show error and keep form data.
            ClearFormFields();
            ShowPopUp("Estudiante añadido");
        }

        private void BtnFind(IAbstractStudentDAO dao)
        {
            int studentId = Int32.Parse(txtStudentId.Text);
            Student foundStudent = dao.FindById(studentId);
            if (foundStudent != null)
            {
                txtStudentId.Text = foundStudent.StudentId.ToString();
                txtName.Text = foundStudent.Name;
                txtSurname.Text = foundStudent.Surname;
                txtDateOfBirth.Text = DateUtilities.DateTimeToStringES(foundStudent.DateOfBirth);
            }
        }

        private void BtnUpdate(IAbstractStudentDAO dao)
        {
            Student student = CreateStudentFromFields();
            dao.Update(student.StudentId, student);
            //TODO: Check if the save operation is OK, otherwise show error and keep form data.
            ClearFormFields();
            ShowPopUp("Estudiante actualizado");
        }
    }
}
