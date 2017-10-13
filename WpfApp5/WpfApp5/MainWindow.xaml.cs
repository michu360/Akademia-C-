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
        
        public char randomSign()
        {
            int randomNumber;
            char sign= ' ';
            char[] tabsign;
            tabsign = new char[7];
            tabsign[0] = '!';
            tabsign[1] = 'X';
            tabsign[2] = '#';
            tabsign[3] = '$';
            tabsign[4] = '%';
            tabsign[5] = '?';
            tabsign[6] = '@';

            randomNumber = z.Next(0,7);
            sign = tabsign[randomNumber];

            return sign;
        }
        
        public void fillBoardSigns()
        {
            int randomNumber;
            List<Button> buttons = Grid.Children.Cast<Button>().ToList();

            for (int k = 0; k < 1; k++)
            {
                randomNumber = z.Next(1, 50);
                if (buttons[randomNumber].Content.ToString() != " ")
                {
                    k--;
                    continue;
                }
                buttons[randomNumber].Content = randomSign().ToString();
                break;
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
            int row = Grid.GetRow(button) - 1;
            //Performing a shift for signs
            if (movesCounter == 0 && table[row, column] != " ")
            {
                buf = table[row, column];
                bufrow = row;
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
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    for (int k = 1; k < 7 - j; k++)
                    {
                        buforForHorizontally = k;
                        if (table[i, j] != " " && table[i, j] == table[i, j + k])
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
                        if (table[i, j] != " " && table[i, j] == table[i + k, j])
                            countRightMovementVertical++;
                        else if (table[i, j] != " " && table[i, j] != table[i + k, j])
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
            bool check = true;

            if (movesCounter == 0)
            {
                pastrow = x;
                pastcolumn = y;
            }
            else if (movesCounter == 1)
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
                if (buttons[i].Content.ToString() != " ")
                {
                    count++;
                }
            }
            if (count == 47)
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
 