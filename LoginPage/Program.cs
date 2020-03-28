using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPage
{
    static class Program
    {
        //Texboxes
        static RichTextBox usernameInput;
        static RichTextBox passwordInput;
        static RichTextBox dialogueTextBox;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form1 form = new Form1();

            usernameInput = (RichTextBox)form.Controls["usernameTextBox"];
            passwordInput = (RichTextBox)form.Controls["passwordTextBox"];
            dialogueTextBox = (RichTextBox)form.Controls["warningDialogueTextBox"];

            //Buttons (and event listeners)
            Button registerButton = (Button)form.Controls["registerButton"];
            registerButton.Click += RegisterButton_Click;
            Button loginButton = (Button)form.Controls["loginButton"];
            loginButton.Click += LoginButton_Click;

            Application.Run(form);

           
        }

        private static void RegisterButton_Click(object sender, EventArgs e)
        {
            UserService.registerNewUser(usernameInput.Text, passwordInput.Text);
            dialogueTextBox.Text = "Successfully registered new user " + usernameInput.Text + "!";
            MessageBox.Show("Successfully registered new user " + usernameInput.Text + "!", "Registered Successfully");
            usernameInput.Text = string.Empty;
            passwordInput.Text = string.Empty;

        }

        private static void LoginButton_Click(object sender, EventArgs e)
        {

        }
    }
}
