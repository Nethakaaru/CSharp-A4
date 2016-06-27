using System;
using System.IO;
using System.Windows.Forms;

namespace Assignment4
{
    /// <summary>
    /// The MainForm class. This is where everything happens. This class does the calculations and communicates with the GUI.
    /// Written by Sebastian Aspegren
    /// </summary>
    public partial class MainForm : Form
    {
        //Task variable
        private Task currentTask;

        /// <summary>
        /// Constructor that calls the setup method of the GUI.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitGUI();
        }
        /// <summary>
        /// The method that prepares the GUI or resets it to its initial state.
        /// </summary>
        private void InitGUI()
        {
            toolTipDate.SetToolTip(datePicker, "Click to open calendar for date, Click on the time to edit it. The format is Day - Month - Year.");
            lblTime.Text = string.Format("{0:HH:mm}", DateTime.Now);
            InitTimePicker();
            txtBoxToDo.ResetText();
            listBox.Items.Clear();
            InitComboBox();
            currentTask = new Task(DateTime.Now);
            timer1.Start();
        }
        /// <summary>
        /// Method to setup the combo box with priority options. Separate method from the InitGUI method to make the code easier to modulate.
        /// </summary>
        private void InitComboBox()
        {
            cBoxPrio.Items.Clear();
            string[] names = Enum.GetNames(typeof(PriorityType));
            cBoxPrio.Items.AddRange(names);
            cBoxPrio.SelectedIndex = (int)PriorityType.Normal;
            cBoxPrio.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        /// <summary>
        /// Method to setup the date timer picker component so the user can select a date and time the task is due.
        /// </summary>
        private void InitTimePicker()
        {
            datePicker.CustomFormat = "dd - MM - yyyy  HH:mm";
            datePicker.ResetText();
        }
        /// <summary>
        /// If the user clicks on the new tab we clear the current one without saving the current one.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newCtrlNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitGUI();
        }
        /// <summary>
        /// Auto generated method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Method used to load previousd data and print it into the listbox.
        /// Method written by Farid Naisan
        /// </summary>
        private void OpenFileAndSaveToListBox()
        {
            string fileName = Application.StartupPath + "\\Tasks.txt";
            StreamReader reader = null;
            listBox.Items.Clear();
            try
            {
                string textIn;
                reader = new StreamReader(fileName);
                while (!reader.EndOfStream)
                {
                    textIn = reader.ReadLine();
                    listBox.Items.Add(textIn);
                }
            }
            catch
            {
                MessageBox.Show("Problem saving data to file!");
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }
        /// <summary>
        /// Method used to save current data in listbox so it can later be opened again.
        /// Method written by Farid Naisan
        /// </summary>
        private void SaveListBoxToFile()
        {
            if (listBox.Items.Count != 0)
            {
                string fileName = Application.StartupPath + "\\Tasks.txt";
                StreamWriter writer = null;
                try
                {
                    writer = new StreamWriter(fileName);
                    for (int i = 0; i < listBox.Items.Count; i++)
                    {
                        writer.WriteLine(listBox.Items[i].ToString());
                    }
                    MessageBox.Show("Saved! Yay!");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Problem saving data to file!" + e.Message);
                }
                finally
                {
                    if (writer != null)
                        writer.Close();
                }
            }
            else
            {
                MessageBox.Show("You have nothing to save!");
            }

        }
        /// <summary>
        /// If the user clicks on open we open the saved file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openDatafileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileAndSaveToListBox();
        }
        /// <summary>
        /// If the user clicks save we save the data in the listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveDatafileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveListBoxToFile();
        }
        /// <summary>
        /// Method that overrides the keypress method so we can write our own shortcuts
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //If the user clicks control and N reset the form.
            if (keyData == (Keys.Control | Keys.N))
            {
                InitGUI();
                return true;
            }
            //if they press alt f4 we ask them if they are sure they want to exit.
            else if (keyData == (Keys.Alt | Keys.F4))
            {
                ExitConfirm();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        /// <summary>
        /// Method used to prompt the user that they are about to close the program. If they say yes we close it.
        /// </summary>
        private void ExitConfirm()
        {
            DialogResult dialogResult = MessageBox.Show("Click OK to exit the program.", "To Do Reminder", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        /// <summary>
        /// If the user clicks exit we ask them if they are sure about it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitAltToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitConfirm();
        }
        /// <summary>
        /// If the user clicks the about button we bring up the about box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void omToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
        }
        /// <summary>
        /// If the user clicks the add button we add the current input to the listbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //If the task lack a description do not add it.
            if (!string.IsNullOrEmpty(txtBoxToDo.Text))
            {
                ReadInput();
                listBox.Items.Add(currentTask.ToString());
            }

        }
        /// <summary>
        /// Method that reads the description, priority and date and stores them in the task variable.
        /// </summary>
        private void ReadInput()
        {
            currentTask.Description = txtBoxToDo.Text;
            currentTask.Date = datePicker.Value;
            currentTask.Priority = (PriorityType)cBoxPrio.SelectedIndex;
        }
        /// <summary>
        /// If the change button is clicked we read the input then attempt to edit the marked item in the listbox. If the index is below 0 nothing is probably selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChange_Click(object sender, EventArgs e)
        {
            int index = listBox.SelectedIndex;
            if (index >= 0)
            {
                ReadInput();
                listBox.Items.RemoveAt(index);
                listBox.Items.Insert(index, currentTask.ToString());
            }
            else
            {
                MessageBox.Show("Select an item from the listbox!", "Error");
            }
        }
        /// <summary>
        /// If the button delete is clicked we first check so something is selected. If it is we ask the user if they are sure they want to delete this item.
        /// If they say yes we delete the selected item in the listbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = listBox.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Select an item from the listbox!", "Error");
            }
            else
            {
                DialogResult dlg = MessageBox.Show("Sure to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dlg == DialogResult.Yes)
                {
                    listBox.Items.RemoveAt(index);
                }
                else if (dlg == DialogResult.No)
                {

                }
                else
                {
                    MessageBox.Show("Somethign went wrong", "Error");
                }
            }
        }
        /// <summary>
        /// Whenever the timer ticks we update the label showing the current time to the current time in hours and minutes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = string.Format("{0:HH:mm}", DateTime.Now);
        }
    }
}
