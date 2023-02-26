using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrabbleFinalProject.Controller
{
 
    // Game is the main class that controls a lot of the stuff in the game
    public class Game
    {
        Board board;
        Dictionary dictionary;
        Bag bag; // added this after we started to code because it is necessary for it
        List<Player> player;
        List<Turn> turn;
        Player curPlayer; // added so the scrabbleboard form can see the current player

        public Board Board { get => board; set => board = value; }
        public Dictionary Dictionary { get => dictionary; set => dictionary = value; }
        public List<Player> Player { get => player; set => player = value; }
        public List<Turn> Turn { get => turn; set => turn = value; }
        public Bag Bag { get => bag; set => bag = value; }

        public Player CurPlayer { get => curPlayer; set => curPlayer = value; }


        // Need to get the things from the user read in options
        // We can probably adjust some of this code and make the board and objects properly
        public Game(String[] players, int height, int width, String language)
        {
            createGame(players, height, width);
            selectDictionary(language);
        }


        // May be able to make sure of these internal or private but think about this later
        // Main functin that is called to create the game
        public void createGame(String[] playersNames, int height, int width)
        {
            this.bag = new Bag(); // works on this
            this.player = new List<Player>();
            this.turn = new List<Turn>();
            this.board = new Board(height, width);
            // adds all the players to a list

            for (int i = 0; i < playersNames.Length; i++)
            {
                addPlayer(playersNames[i]);
                // Adds tiles to the players hand
                for(int j = 0; j < 7; j++)
                    this.player[this.player.Count - 1].Hand.addToHand(this.bag.randomTile());
                
            }
        }

        public void addPlayer(String playerName)
        {
           this.player.Add(new Player(playerName));
        }

        public void selectDictionary(String language)
        {
            if (language.Equals("English"))
            {
                this.dictionary = new Dictionary("en-US.dic");
            }

            else if(language.Equals("French"))
            {
                this.dictionary = new Dictionary("fr-FR.dic");
            }
            else
            {
                this.dictionary = new Dictionary("it-IT.dic");
            }
        }

        public void StartGame()
        {

            // puts places on the title associated with the board

            curPlayer = this.player[0];
            turn.Add(new Turn(curPlayer, new Word(), 0));


            // bool continueGame = true;

            // figure out what to do with turns later
            

        }

        
        public bool isWord(Word word)
        {

            return this.dictionary.isInDictionary(word.wordStringForm());
        }


        public void nextTurn()
        {
            turn[turn.Count - 1].Score = turn[turn.Count - 1].Word.Value;
            // gets the score for the player


            // Sets the new player to go 
            curPlayer = player[turn.Count % player.Count];
            turn.Add(new Turn(curPlayer, new Word(), 0));



        }

        

        

        // Using this purely for DEBUG purposes, not really a necessary function
        public override String ToString()
        {
            // Add in this later: "Board: " + this.board.ToString() + "Dictionary: " + this.dictionary.ToString() + 
            return "Board: " + this.board.ToString() + "\nDictionary: " + this.dictionary.ToString() + "\nBag: " + this.bag.ToString() + "\nPlayers: " + this.player.ToString() + "\nTurn: " + this.turn.ToString();
        }


    }



}
