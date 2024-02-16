namespace Scoreboard
{
    public partial class Form1 : Form
    {
        private AutoCompleteStringCollection autoCompleteCollection;
        private const string apiUrl = "https://your-api-endpoint.com/graphql";
        private const string token = "YOUR_TOKEN_HERE";

        public Form1()
        {
            InitializeComponent();
            textBoxS2.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
            textBoxS1.KeyPress += new KeyPressEventHandler(textBox_KeyPress);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            buttonDecrement_Click(textBoxS2, sender, e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            buttonIncrement_Click(textBoxS2, sender, e);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Create and configure FolderBrowserDialog
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Select a folder";
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;

            // Show the dialog
            DialogResult result = folderBrowserDialog.ShowDialog();

            // Check if a folder was selected
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
            {
                // Get the selected folder path and display it
                string selectedFolder = folderBrowserDialog.SelectedPath;
                textBoxPath.Text = selectedFolder;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            resetAll();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            resetScore();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void resetAll()
        {
            textBoxP1.Text = string.Empty;
            textBoxP2.Text = string.Empty;
            resetScore();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a control key, a digit, or a period
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                // Suppress the key press event
                e.Handled = true;
            }
        }

        private void buttonDecrement_Click(TextBox t, object sender, EventArgs e)
        {
            // Parse the text from the textbox as an integer
            if (int.TryParse(t.Text, out int number))
            {
                if (number > 0)// Decrement the number by 1
                    number--;

                // Update the textbox with the incremented value
                t.Text = number.ToString();
            }

        }
        private void buttonIncrement_Click(TextBox t, object sender, EventArgs e)
        {
            // Parse the text from the textbox as an integer
            if (int.TryParse(t.Text, out int number))
            {
                // Increment the number by 1
                number++;

                // Update the textbox with the incremented value
                t.Text = number.ToString();
            }
        }

        private void resetScore()
        {
            textBoxS1.Text = "0";
            textBoxS2.Text = "0";
        }

        private void buttonSwitchPlayers_Click(object sender, EventArgs e)
        {
            string temp = textBoxP1.Text;
            textBoxP1.Text = textBoxP2.Text;
            textBoxP2.Text = temp;

            temp = textBoxS1.Text;
            textBoxS1.Text = textBoxS2.Text;
            textBoxS2.Text = temp;
        }

        private bool IsPositiveNumber(string text)
        {
            // Attempt to parse the text to a double
            // If successful, check if it's greater than zero
            if (double.TryParse(text, out double number))
            {
                return number > 0;
            }
            return false;
        }
        private void textBox_Leave(TextBox ob, object sender, EventArgs e)
        {
            // Check if the textbox is empty or doesn't contain a valid positive number
            if (string.IsNullOrWhiteSpace(ob.Text) || !IsPositiveNumber(ob.Text))
            {
                // Set the textbox's text to empty or display an error message
                ob.Text = "0";
                MessageBox.Show("Please enter a valid positive number.");
            }
        }

        private void button1M_Click(object sender, EventArgs e)
        {
            buttonDecrement_Click(textBoxS1, sender, e);
        }

        private void button1P_Click(object sender, EventArgs e)
        {
            buttonIncrement_Click(textBoxS1, sender, e);
        }

        private void buttonPlayerList_Click(object sender, EventArgs e)
        {
            // Create the AutoCompleteStringCollection
            autoCompleteCollection = new AutoCompleteStringCollection();

            // Load names from a file or any other source
            string[] names = LoadNamesFromSomeSource("C:/Users/youtu/Downloads/pipi.txt");
            // Add names to the AutoCompleteStringCollection
            autoCompleteCollection.AddRange(names.ToArray());
            // Update the TextBox's AutoCompleteCustomSource
            textBoxP1.AutoCompleteCustomSource = autoCompleteCollection;
            textBoxP2.AutoCompleteCustomSource = autoCompleteCollection;
            textBoxP1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxP1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxP2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxP2.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private string[] LoadNamesFromSomeSource(string t)
        {
            if (File.Exists(t)) return File.ReadAllLines(t);
            else throw new Exception("No File Found");
        }
        
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // Get the folder path from textBoxPath
            string folderPath = textBoxPath.Text;

            // Check if the folder path is empty
            if (string.IsNullOrWhiteSpace(folderPath)){
                MessageBox.Show("Please provide a valid folder path.");
                return; // Exit the method if folder path is not valid
            }

            // Check if the folder path exists
            if (!Directory.Exists(folderPath)){
                MessageBox.Show("The folder path does not exist.");
                return; // Exit the method if folder path doesn't exist
            }

            // Create the Scoreboard folder if it doesn't exist
            string scoreboardFolderPath = Path.Combine(folderPath, "Scoreboard");
            Directory.CreateDirectory(scoreboardFolderPath);

            // Call the function for each TextBox
            SaveTextBoxToFile(textBoxP1, "Player1.tmp");
            SaveTextBoxToFile(textBoxP2, "Player2.tmp");
            SaveTextBoxToFile(textBoxS1, "Score1.tmp");
            SaveTextBoxToFile(textBoxS2, "Score2.tmp");
            SaveTextBoxToFile(textBoxL1, "Label1.tmp");
            SaveTextBoxToFile(textBoxM1, "Misc1.tmp");
            SaveTextBoxToFile(textBoxL2, "Label2.tmp");
            SaveTextBoxToFile(textBoxM2, "Misc2.tmp");
           

        }
        private void SaveTextBoxToFile(TextBox textBox, string fileName)
        {
            // Get the file path
            string filePath = Path.Combine(textBoxPath.Text, "Scoreboard", fileName);

            // Check if the file exists, create it if it doesn't
            if (!File.Exists(filePath)){
                File.Create(filePath).Close();
            }

            // Erase the content of the file and write the TextBox's text
            File.WriteAllText(filePath, textBox.Text);
        }
    }
}