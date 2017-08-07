using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp5
{
    public partial class MainWindow : Window
    {
        //Global variables
        public int score = 0;
        public string buf = " ";
        public int movesCounter = 0;
        public int bufrow = 0, bufcolumn = 0;
        public int pastrow = -1, pastcolumn = -1, afterRow = -1, aftercolumn = -1;

        Random z = new Random();
        public string randomSign()
        {
            int randomNumber;
            string sign = " ";

            randomNumber = z.Next(1, 8);
            switch (randomNumber)
            {
                case 1: sign = "!"; break;
                case 2: sign = "X"; break;
                case 3: sign = "#"; break;
                case 4: sign = "$"; break;
                case 5: sign = "%"; break;
                case 6: sign = "&"; break;
                case 7: sign = "?"; break;
                case 8: sign = "@"; break;
            }
            return sign;
        }
        public void fillBoardSigns()     
        {
            int randomNumber;
            for (int k = 0; k < 1; k++)
            {
                randomNumber = z.Next(1, 50);
                switch (randomNumber)
                {
                    case 1: if (button1.Content.ToString() != " ") { k--; continue; } button1.Content = randomSign(); break;
                    case 2: if (button2.Content.ToString() != " ") { k--; continue; } button2.Content = randomSign(); break;
                    case 3: if (button3.Content.ToString() != " ") { k--; continue; } button3.Content = randomSign(); break;
                    case 4: if (button4.Content.ToString() != " ") { k--; continue; } button4.Content = randomSign(); break;
                    case 5: if (button5.Content.ToString() != " ") { k--; continue; } button5.Content = randomSign(); break;
                    case 6: if (button6.Content.ToString() != " ") { k--; continue; } button6.Content = randomSign(); break;
                    case 7: if (button7.Content.ToString() != " ") { k--; continue; } button7.Content = randomSign(); break;
                    case 8: if (button8.Content.ToString() != " ") { k--; continue; } button8.Content = randomSign(); break;
                    case 9: if (button9.Content.ToString() != " ") { k--; continue; } button9.Content = randomSign(); break;
                    case 10: if (button10.Content.ToString() != " ") { k--; continue; } button10.Content = randomSign(); break;
                    case 11: if (button11.Content.ToString() != " ") { k--; continue; } button11.Content = randomSign(); break;
                    case 12: if (button12.Content.ToString() != " ") { k--; continue; } button12.Content = randomSign(); break;
                    case 13: if (button13.Content.ToString() != " ") { k--; continue; } button13.Content = randomSign(); break;
                    case 14: if (button14.Content.ToString() != " ") { k--; continue; } button14.Content = randomSign(); break;
                    case 15: if (button15.Content.ToString() != " ") { k--; continue; } button15.Content = randomSign(); break;
                    case 16: if (button16.Content.ToString() != " ") { k--; continue; } button16.Content = randomSign(); break;
                    case 17: if (button17.Content.ToString() != " ") { k--; continue; } button17.Content = randomSign(); break;
                    case 18: if (button18.Content.ToString() != " ") { k--; continue; } button18.Content = randomSign(); break;
                    case 19: if (button19.Content.ToString() != " ") { k--; continue; } button19.Content = randomSign(); break;
                    case 20: if (button20.Content.ToString() != " ") { k--; continue; } button20.Content = randomSign(); break;
                    case 21: if (button21.Content.ToString() != " ") { k--; continue; } button21.Content = randomSign(); break;
                    case 22: if (button22.Content.ToString() != " ") { k--; continue; } button22.Content = randomSign(); break;
                    case 23: if (button23.Content.ToString() != " ") { k--; continue; } button23.Content = randomSign(); break;
                    case 24: if (button24.Content.ToString() != " ") { k--; continue; } button24.Content = randomSign(); break;
                    case 25: if (button25.Content.ToString() != " ") { k--; continue; } button25.Content = randomSign(); break;
                    case 26: if (button26.Content.ToString() != " ") { k--; continue; } button26.Content = randomSign(); break;
                    case 27: if (button27.Content.ToString() != " ") { k--; continue; } button27.Content = randomSign(); break;
                    case 28: if (button28.Content.ToString() != " ") { k--; continue; } button28.Content = randomSign(); break;
                    case 29: if (button29.Content.ToString() != " ") { k--; continue; } button29.Content = randomSign(); break;
                    case 30: if (button30.Content.ToString() != " ") { k--; continue; } button30.Content = randomSign(); break;
                    case 31: if (button31.Content.ToString() != " ") { k--; continue; } button31.Content = randomSign(); break;
                    case 32: if (button32.Content.ToString() != " ") { k--; continue; } button32.Content = randomSign(); break;
                    case 33: if (button33.Content.ToString() != " ") { k--; continue; } button33.Content = randomSign(); break;
                    case 34: if (button34.Content.ToString() != " ") { k--; continue; } button34.Content = randomSign(); break;
                    case 35: if (button35.Content.ToString() != " ") { k--; continue; } button35.Content = randomSign(); break;
                    case 36: if (button36.Content.ToString() != " ") { k--; continue; } button36.Content = randomSign(); break;
                    case 37: if (button37.Content.ToString() != " ") { k--; continue; } button37.Content = randomSign(); break;
                    case 38: if (button38.Content.ToString() != " ") { k--; continue; } button38.Content = randomSign(); break;
                    case 39: if (button39.Content.ToString() != " ") { k--; continue; } button39.Content = randomSign(); break;
                    case 40: if (button40.Content.ToString() != " ") { k--; continue; } button40.Content = randomSign(); break;
                    case 41: if (button41.Content.ToString() != " ") { k--; continue; } button41.Content = randomSign(); break;
                    case 42: if (button42.Content.ToString() != " ") { k--; continue; } button42.Content = randomSign(); break;
                    case 43: if (button43.Content.ToString() != " ") { k--; continue; } button43.Content = randomSign(); break;
                    case 44: if (button44.Content.ToString() != " ") { k--; continue; } button44.Content = randomSign(); break;
                    case 45: if (button45.Content.ToString() != " ") { k--; continue; } button45.Content = randomSign(); break;
                    case 46: if (button46.Content.ToString() != " ") { k--; continue; } button46.Content = randomSign(); break;
                    case 47: if (button47.Content.ToString() != " ") { k--; continue; } button47.Content = randomSign(); break;
                    case 48: if (button48.Content.ToString() != " ") { k--; continue; } button48.Content = randomSign(); break;
                    case 49: if (button49.Content.ToString() != " ") { k--; continue; } button49.Content = randomSign(); break;
                }
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            MessageBox.Show("Let's play a game...");
            NewGame();
        }

        public void NewGame()
        {
            List<Button> buttons = Grid.Children.Cast<Button>().ToList();
            // Clearing table at the beginning of the game
            for (int i = 0; i < 49; i++)
            {
                buttons[i].Content = " ";
            }
            //  Clearing global variables
            score = 0;
            buf = " ";
            movesCounter = 0;
            result.Content = "Score: 0";
            for (int i = 1; i <= 5; i++)
            {
                fillBoardSigns();
            }
        }
 
        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string[,] table;
            table = new string[7, 7];
            bool rightMovement = true;

            RewritingToTable(table);
            int column = Grid.GetColumn(button);
            int row = Grid.GetRow(button)-1;
            //Performing a shift for signs
            if (movesCounter == 0 && table[row, column] != " ")
            {
                buf = table[row, column];
                bufrow =row;
                bufcolumn = column;
                CheckMovement(row, column, table);
                movesCounter = 1;
            }
            else if (movesCounter == 1 && button.Content.ToString() == " ")
            {
                if (CheckMovement(row, column, table))
                {
                    table[row, column] = buf;
                    table[bufrow, bufcolumn] = " ";
                }
                else
                {
                    MessageBox.Show("Incorrect movement");
                    rightMovement = false;
                }
                movesCounter = 0;
            }
            else
            {
                MessageBox.Show("Incorrect movement");
                rightMovement = false;
                movesCounter = 0;
            }

            RewritingToButtons(table);
            int pastScore = score; ;
            CheckBreakingSign(table);

            DisplayScores();

            if (pastScore == score && movesCounter == 0 && rightMovement)
            {
                AddSigns();
                ChceckLose();
                AddSigns();

            }
            ChceckLose();
        }

        public void RewritingToTable(string[,] table)
        {
            // Rewriting content buttons to the table 
            List<Button> buttons = Grid.Children.Cast<Button>().ToList();
            int count = 0;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    table[i, j] = buttons[count].Content.ToString();
                    count++;
                }
            }
        }

        public void RewritingToButtons(string[,] table)
        {
            // Rewriting content table to the buttons
            List<Button> buttons = Grid.Children.Cast<Button>().ToList();
            int count = 0;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    buttons[count].Content = table[i, j];
                    count++;
                }
            }
        }

        public void CheckBreakingSign(string[,] table)
        {
            RewritingToTable(table);
            // Check sign in table in pose horizontally 
            int countRightMovementHorizontally = 1; int buforForHorizontally = 0;
            for(int i=0; i<7; i++)
            {
                for(int j=0; j<7; j++)
                {
                    for (int k=1; k<7-j; k++)
                    {
                        buforForHorizontally = k;
                        if (table[i, j] != " " && table[i, j] == table[i, j + k] )
                        {
                            countRightMovementHorizontally++;
                        }   
                        else if (table[i, j] != " " && table[i, j] != table[i, j + k])
                        {
                            if (countRightMovementHorizontally >= 3)
                            {
                                for (int t = 1; t <= countRightMovementHorizontally; t++)
                                {
                                    table[i, j + k - t] = " ";
                                    score = score + 10;
                                }        
                            }
                            countRightMovementHorizontally = 1;
                            break;
                        }
                    }
                    if (countRightMovementHorizontally >= 3)
                    {
                        for (int t = 0; t < countRightMovementHorizontally; t++)
                        {
                            table[i, j + buforForHorizontally - t] = " ";
                            score = score + 10;
                        }
                        countRightMovementHorizontally = 1;
                    }
                }
            }
            // Check sign in table in pose vertical
            int countRightMovementVertical = 1; int buforForVertical = 0;
            for (int j = 0; j < 7; j++) 
            {
                for (int i = 0; i < 7; i++)
                {
                    for (int k = 1; k < 7 - i; k++)
                    {
                        buforForVertical = k;
                        if (table[i, j] != " " && table[i, j] == table[i+k, j])
                            countRightMovementVertical++;
                        else if (table[i, j] != " " && table[i, j] != table[i+k, j])
                        {
                            if (countRightMovementVertical >= 3)
                            {
                                for (int t = 1; t <= countRightMovementVertical; t++)
                                {
                                    table[i + k - t, j] = " ";
                                    score = score + 10;
                                }   
                            }
                            countRightMovementVertical = 1;
                            break;
                        }
                    }
                    if (countRightMovementVertical >= 3)
                    {
                        for (int t = 0; t < countRightMovementVertical; t++)
                        {
                            table[i + buforForVertical - t, j] = " ";
                            score = score + 10;
                        }
                        countRightMovementVertical = 1;
                    }
                }
            }
            RewritingToButtons(table);
        }

        public void AddSigns()
        {
            fillBoardSigns();
        }

        public bool CheckMovement(int x, int y, string[,] table)
        {
            bool  check=true;
            
            if(movesCounter == 0)
            {
                pastrow = x;
                pastcolumn = y;
            }
            else if(movesCounter == 1)
            {
                afterRow = x;
                aftercolumn = y;

                if (pastrow >= 0 && pastrow == afterRow && aftercolumn != pastcolumn)
                {
                    if (pastcolumn < aftercolumn)
                    {
                        for (int i = pastcolumn + 1; i <= aftercolumn; i++)
                        {
                            if (table[pastrow, i] != " ")
                            {
                                check = false;
                                break;
                            }
                        }
                    }
                    else if (pastcolumn > aftercolumn)
                    {
                        for (int i = pastcolumn - 1; i >= aftercolumn; i--)
                        {
                            if (table[pastrow, i] != " ")
                            {
                                check = false;
                                break;
                            }
                        }
                    }

                }
                else if (pastcolumn >= 0 && pastcolumn == aftercolumn && pastrow != afterRow)
                {
                    if (pastrow < afterRow)
                    {
                        for (int i = pastrow + 1; i <= afterRow; i++)
                        {
                            if (table[i, pastcolumn] != " ")
                            {
                                check = false;
                                break;
                            }
                        }
                    }
                    else if (pastrow > afterRow)
                    {
                        for (int i = pastrow - 1; i >= afterRow; i--)
                        {
                            if (table[i, pastcolumn] != " ")
                            {
                                check = false;
                                break;
                            }
                        }
                    }
                }
               else
                check = false;   
            }
            return check;
        }

        public void DisplayScores()
        {
            score.ToString();
            string displayresult = "Score: ";
            displayresult += score;
            result.Content = displayresult;
        }

        public void ChceckLose()
        {
            List<Button> buttons = Grid.Children.Cast<Button>().ToList();
            int count = 0;
            for (int i = 0; i < 47; i++)
            {
                if(buttons[i].Content.ToString()!=" ")
                {
                    count++;
                }
            }
            if(count == 47)
            {
                FinishTheGame();
            }
        }
        public void FinishTheGame()
        {
            score.ToString();
            string displayresul = "GAME OVER" + Environment.NewLine + "Score: ";
            displayresul += score;
            MessageBox.Show(displayresul);
            Close();
        }

        private void NewGame_Click(object sender, RoutedEventArgs e)
        {
            NewGame();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            FinishTheGame();
        }

        private void Instruction_Click(object sender, RoutedEventArgs e)
        {
            string instruction = "Breaking signs." + Environment.NewLine + "The game consists of posing the same " +
                "signs vertically or horizontally." + Environment.NewLine + "Signs can to move any number of fields only " +
                "if different sign not block movement." + Environment.NewLine + "Mouse control.";
            MessageBox.Show(instruction);
        }

        private void Creators_Click(object sender, RoutedEventArgs e)
        {
            string creators = "Creator - Michał Dębiński.";
            MessageBox.Show(creators);
        }
    }
 }
