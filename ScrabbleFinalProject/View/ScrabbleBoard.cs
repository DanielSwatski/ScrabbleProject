using Microsoft.VisualBasic;
using ScrabbleFinalProject.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrabbleFinalProject.View
{
    public partial class ScrabbleBoard : Form
    {
        private bool firstTurn;
        private Title titleForm; // owns the form

        private Button[,] arrOnBoard; // displays the board
        

        private List<Button> selectedOnBoard;
        private List<Button> selectedOnHand;

        private Button[] activeHand;
        private Word potentialWord;

        internal void SetOwner(Title titleForm)
        {
            this.titleForm = titleForm;

        }

        public ScrabbleBoard()
        {
            InitializeComponent();
        }


        /*
        public void reloadHand()
        {
            for(int i = 0; i < activeHand.Length; i++)
            {
                if(activeHand[i].Text != "*")
                {
                    activeHand[i].Text = potentialWord.WordList[0].ToString();
                    potentialWord.WordList = potentialWord.WordList.GetRange(1, potentialWord.WordList.Count - 1);
                }
            }
        }
        */

        public void loadNextPlayerHand()
        {
            //grpBoxHand = new GroupBox();
            //grpBoxHand.Location = new Point(500, 500);
            
            activeHand = new Button[7]; // may need to change this later to a constant but will keep for now
            for (int i = 0; i < this.titleForm.gameObj.CurPlayer.Hand.TilesinHand.Count(); i++)
            {
                
                activeHand[i] = new System.Windows.Forms.Button();
                grpBoxHand.Controls.Add(activeHand[i]);
                //MessageBox.Show(i.ToString());
                activeHand[i].Size = new Size(40, 40);
                activeHand[i].Enabled = true;

                activeHand[i].Text = this.titleForm.gameObj.CurPlayer.Hand.TilesinHand[i].Letter.ToString();
                activeHand[i].Tag = this.titleForm.gameObj.CurPlayer.Hand.TilesinHand[i]; // doesnt copy it all over here for some reason


                grpBoxHand.Controls.Add(activeHand[i]);

                activeHand[i].Location = new Point(activeHand[i].Location.X + i * 40, activeHand[i].Location.Y + 20);

                activeHand[i].Click += new EventHandler(buttonClickedHand); //most important line here: This adds the ability to have the clicks to read it

                //grpBoxPlayerHand.Controls.Add(activeHand[i]);
            }



        }



        public void setTurnInfo()
        {
            // sets the next player info
            txtBoxPlayerName.Text = this.titleForm.gameObj.CurPlayer.PlayerName;
            txtBoxScore.Text = this.titleForm.gameObj.CurPlayer.Score.ToString();


        }


        private void ScrabbleBoard_Load(object sender, EventArgs e)
        {
            firstTurn = true;
            this.titleForm.gameObj.StartGame();

            arrOnBoard = new Button[this.titleForm.gameObj.Board.BoardTiles.GetLength(0), this.titleForm.gameObj.Board.BoardTiles.GetLength(1)]; // represents the board as buttons

            
            selectedOnBoard = new List<Button>();
            potentialWord = new Word();

            selectedOnHand = new List<Button>();



            for (int i = 0; i < this.titleForm.gameObj.Board.BoardTiles.GetLength(0); i++)
            {
                for (int j = 0; j < this.titleForm.gameObj.Board.BoardTiles.GetLength(1); j++)
                {
                    arrOnBoard[i, j] = new System.Windows.Forms.Button();
                    
                    arrOnBoard[i, j].Location = new Point(40 * i, 40 * j);
                    arrOnBoard[i, j].Enabled = true;
                    arrOnBoard[i, j].Size = new Size(40, 40);
                    

                    this.Controls.Add(arrOnBoard[i, j]);

                    if (this.titleForm.gameObj.Board.BoardTiles[i, j].Bonus != null)
                    {
                        arrOnBoard[i, j].Text = this.titleForm.gameObj.Board.BoardTiles[i, j].Bonus.getBonusValue().ToString();
                    }
                    else
                        arrOnBoard[i, j].Text = "*";

                    // may need to be mixed around
                    this.titleForm.gameObj.Board.BoardTiles[i, j].Column = j;
                    this.titleForm.gameObj.Board.BoardTiles[i, j].Row = i;

                    arrOnBoard[i, j].Click += new EventHandler(buttonClickedBoard);


                    grpBoxBoard.Controls.Add(arrOnBoard[i, j]);


                    // will also display the current score of the player

                }
            }


            loadNextPlayerHand();



            // loads in the playername and score
            txtBoxPlayerName.Text = this.titleForm.gameObj.CurPlayer.PlayerName;
            txtBoxScore.Text = this.titleForm.gameObj.CurPlayer.Score.ToString();



        }


        // this occurs when one of the buttons is clicked
        private void buttonClickedHand(object sender, EventArgs e)
        {
            Button addToHand = (Button)sender;
            this.selectedOnHand.Add(addToHand);
            Tile potentialLetter = (Tile)addToHand.Tag; // misses location here
            
            potentialWord.AddToWordList(potentialLetter);
            
            //addToHand.Text = "*";
            
            
            //this.potentialWord.AddToWordList(this.titleForm.gameObj.Board.BoardTiles;
            
        }

        // Adds the button to the list so it can be played and potentially make a word
        private void buttonClickedBoard(object sender, EventArgs e)
        {
            this.selectedOnBoard.Add((Button)sender); 
        }

  

        // Figure this shit out later
        private void btnSkipPlay_Click(object sender, EventArgs e)
        {
            if (selectedOnHand.Count == 0)
            {
                MessageBox.Show("Turn has been skipped");
            }
            else
            {
                //MessageBox.Show("Here");
                // checks to see if the world is a word first
                Tile potter;
                if (!firstTurn)
                {
                    potter = (Tile)this.selectedOnBoard[0].Tag;
                    potentialWord.WordList.Insert(0, potter);
                }

                if (this.titleForm.gameObj.isWord(potentialWord)) //failure here for some reason ignore now
                {

                    // adds the first selected on the selectedBoard
                    
                    if (!firstTurn)
                    {
                        potter = (Tile)this.selectedOnBoard[0].Tag;
                        potentialWord.AddToWordList(potter);
                        for (int i = 1; i < selectedOnHand.Count; i++)
                        {
                            potter = (Tile)this.selectedOnHand[i].Tag;
                            this.selectedOnBoard[i].Text = potter.Letter.ToString();
                            //potentialWord.AddToWordList(potter);
                        }

                        firstTurn = false;

                    }
                    else
                    {
                        for (int i = 0; i < selectedOnHand.Count; i++)
                        {
                            potter = (Tile)this.selectedOnHand[i].Tag;
                            this.selectedOnBoard[i].Text = potter.Letter.ToString();
                            potentialWord.AddToWordList(potter);
                        }

                        firstTurn = false;

                    }

                    // add score for this player
                    potentialWord.calculateValue();
                    this.titleForm.gameObj.CurPlayer.Score  += potentialWord.Value;
                    txtBoxScore.Text = this.titleForm.gameObj.CurPlayer.Score.ToString();

                    // adds the current info to the turn
                    this.titleForm.gameObj.Turn[this.titleForm.gameObj.Turn.Count - 1].Score = potentialWord.Value;
                    this.titleForm.gameObj.Turn[this.titleForm.gameObj.Turn.Count - 1].WhoWent= this.titleForm.gameObj.CurPlayer;
                    this.titleForm.gameObj.Turn[this.titleForm.gameObj.Turn.Count - 1].Word = potentialWord;


                    // sets up the next cur player
                    
                    this.titleForm.gameObj.nextTurn();
                    loadNextPlayerHand();
                    setTurnInfo();
                }

                else
                {
                   // MessageBox.Show("This is not a word");
                    MessageBox.Show(potentialWord.wordStringForm() + " is not a word");
                    potentialWord.clearData();
                }
            }

            // check if the word is legitimate or not

            MessageBox.Show("Player: " + this.titleForm.gameObj.CurPlayer.PlayerName + " Score: " + this.titleForm.gameObj.CurPlayer.Score.ToString());


            selectedOnBoard.Clear();
            selectedOnHand.Clear();
            potentialWord.clearData();
        }


        // not working at the momemnt but will clean it up later
        private void btnRemovePlayedPieces_Click(object sender, EventArgs e)
        {

            //reloadHand();

            // removes all pieces from the board that have been played
            selectedOnBoard.Clear();
            selectedOnHand.Clear();

            MessageBox.Show("Removed played pieces");
        }


        // this can probably be deleted
        private void grpBoxBoard_Enter(object sender, EventArgs e)
        {

        }
    }

    


}

