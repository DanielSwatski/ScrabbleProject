using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScrabbleFinalProject.Controller;
using Microsoft.VisualBasic;
using ScrabbleFinalProject.View;

namespace ScrabbleFinalProject
{
    public partial class Title : Form
    {

        internal Game gameObj;
        public Title()
        {
            InitializeComponent();
        }


        // Begins the game here
        private void btnBegin_Click(object sender, EventArgs e)
        {
            // write error checking for the number of players and heights later. Our goal now should be to focus on getting the game out and somewhat functional
            int playerNumber = int.Parse(txtBoxPlayers.Text);
                // Open up a new window that asks to enter all players names
            


            int height = int.Parse(txtBoxHeight.Text);
            int width = int.Parse(txtBoxWidth.Text);

            String[] names = new string[playerNumber];
            // Gets all the player names here
            for(int i = 0; i < playerNumber; i++)
            {
               // used a visualbasic Interaction clqss for this
                names[i] = Interaction.InputBox("Enter in the Players name: ", "", "", 300, 300);

            }

            // how this works: https://stackoverflow.com/questions/18547326/how-do-i-get-which-radio-button-is-checked-from-a-groupbox
            String language = grpBoxLanguage.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text;
            //MessageBox.Show(language);

                
            gameObj = new Game(names, height, width, language);


            // Using the below to lots of the features of the game object
            //textBox1.Text = gameObj.ToString();


            // Example of how the isInDictionary function works just by passing in a string 
           // MessageBox.Show(gameObj.Dictionary.isInDictionary(textBox3.Text).ToString());


            // this actually loads the form
            ScrabbleBoard gameForm = new ScrabbleBoard();
            gameForm.SetOwner(this);
            gameForm.Show();


        }

        // This will open up another form for users to enter in the players name, it can be not clicked and the names will default to player0-n

    }
}
