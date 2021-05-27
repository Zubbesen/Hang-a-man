using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hang_a_man
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GameLogic.SetupStartCondition();
            txtWholeWord.Text = GameLogic.FullWord;
            PlayGameMusic();

        }

        private void Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            GameLogic.SetupStartCondition();
            resetAll();
            txtWholeWord.Text = GameLogic.GetOneWord();
            Wordbox.Text = GameLogic.GetSecretWord();

        }

        private void resetAll()
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnE.Enabled = true;
            btnF.Enabled = true;
            btnG.Enabled = true;
            btnH.Enabled = true;
            btnI.Enabled = true;
            btnJ.Enabled = true;
            btnL.Enabled = true;
            btnM.Enabled = true;
            btnN.Enabled = true;
            btnO.Enabled = true;
            btnP.Enabled = true;
            btnQ.Enabled = true;
            btnR.Enabled = true;
            btnS.Enabled = true;
            btnT.Enabled = true;
            btnU.Enabled = true;
            btnV.Enabled = true;
            btnW.Enabled = true;
            btnX.Enabled = true;
            btnY.Enabled = true;
            btnZ.Enabled = true;
        }


        private void guesswordbtn_Click(object sender, EventArgs e)
        {
            if (GameLogic.IsWordCorrect(txtWholeWord.Text))
            {
                Wordbox.Text = GameLogic.FullWord;
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
                
            }
            else if (GameLogic.GameLost == false)
            {
               MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
                WrongGuessImages(GameLogic.CountGuesses);
            MessageBox.Show( "U have guessed" + GameLogic.CountGuesses + " times", "The word is incorrect", MessageBoxButtons.OK);
                            
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            if (GameLogic.GameWon == true)
            {
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
                GameLogic.SetupStartCondition();

            }
            else if (GameLogic.CorrectLetter('A'))
            {
                Wordbox.Text = GameLogic.SecretWord;
            }
            else if (GameLogic.IsCorrectLetter == false && GameLogic.CountGuesses == 10)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
            {
                WrongGuessImages(GameLogic.CountGuesses);
                MessageBox.Show("Try another letter! You have " + (10 - GameLogic.CountGuesses) + " chances left.", "Wrong Letter", MessageBoxButtons.OK);

            }


        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnB.Enabled = false;
            if (GameLogic.GameWon == true)
            {
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else if (GameLogic.CorrectLetter('B'))
            {
                Wordbox.Text = GameLogic.SecretWord;
            }
            else if (GameLogic.IsCorrectLetter == false && GameLogic.CountGuesses == 10)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
            {
                WrongGuessImages(GameLogic.CountGuesses);
                MessageBox.Show("Try another letter! You have " + (10 - GameLogic.CountGuesses) + " chances left.", "Wrong Letter", MessageBoxButtons.OK);

            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnC.Enabled = false;
            if (GameLogic.GameWon == true)
            {
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else if (GameLogic.CorrectLetter('C'))
            {
                Wordbox.Text = GameLogic.SecretWord;
            }
            else if (GameLogic.IsCorrectLetter == false && GameLogic.CountGuesses == 10)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
            {
                WrongGuessImages(GameLogic.CountGuesses);
                MessageBox.Show("Try another letter! You have " + (10 - GameLogic.CountGuesses) + " chances left.", "Wrong Letter", MessageBoxButtons.OK);

            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnD.Enabled = false;
            if (GameLogic.GameWon == true)
            {
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else if (GameLogic.CorrectLetter('D'))
            {
                Wordbox.Text = GameLogic.SecretWord;
            }
            else if (GameLogic.IsCorrectLetter == false && GameLogic.CountGuesses == 10)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
            {
                WrongGuessImages(GameLogic.CountGuesses);
                MessageBox.Show("Try another letter! You have " + (10 - GameLogic.CountGuesses) + " chances left.", "Wrong Letter", MessageBoxButtons.OK);

            }
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            btnE.Enabled = false;
            if (GameLogic.GameWon == true)
            {
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else if (GameLogic.CorrectLetter('E'))
            {
                Wordbox.Text = GameLogic.SecretWord;
            }
            else if (GameLogic.IsCorrectLetter == false && GameLogic.CountGuesses == 10)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
            {
                WrongGuessImages(GameLogic.CountGuesses);
                MessageBox.Show("Try another letter! You have " + (10 - GameLogic.CountGuesses) + " chances left.", "Wrong Letter", MessageBoxButtons.OK);

            }
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            btnF.Enabled = false;
            if (GameLogic.GameWon == true)
            {
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else if (GameLogic.CorrectLetter('F'))
            {
                Wordbox.Text = GameLogic.SecretWord;
            }
            else if (GameLogic.IsCorrectLetter == false && GameLogic.CountGuesses == 10)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
            {
                WrongGuessImages(GameLogic.CountGuesses);
                MessageBox.Show("Try another letter! You have " + (10 - GameLogic.CountGuesses) + " chances left.", "Wrong Letter", MessageBoxButtons.OK);

            }
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            btnG.Enabled = false;
            if (GameLogic.GameWon == true)
            {
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else if (GameLogic.CorrectLetter('G'))
            {
                Wordbox.Text = GameLogic.SecretWord;
            }
            else if (GameLogic.IsCorrectLetter == false && GameLogic.CountGuesses == 10)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
            {
                WrongGuessImages(GameLogic.CountGuesses);
                MessageBox.Show("Try another letter! You have " + (10 - GameLogic.CountGuesses) + " chances left.", "Wrong Letter", MessageBoxButtons.OK);

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            btnH.Enabled = false;
            if (GameLogic.GameWon == true)
            {
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else if (GameLogic.CorrectLetter('H'))
            {
                Wordbox.Text = GameLogic.SecretWord;
            }
            else if (GameLogic.IsCorrectLetter == false && GameLogic.CountGuesses == 10)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
            {
                WrongGuessImages(GameLogic.CountGuesses);
                MessageBox.Show("Try another letter! You have " + (10 - GameLogic.CountGuesses) + " chances left.", "Wrong Letter", MessageBoxButtons.OK);

            }
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            btnI.Enabled = false;
            if (GameLogic.GameWon == true)
            {
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else if (GameLogic.CorrectLetter('I'))
            {
                Wordbox.Text = GameLogic.SecretWord;
            }
            else if (GameLogic.IsCorrectLetter == false && GameLogic.CountGuesses == 10)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
            {
                WrongGuessImages(GameLogic.CountGuesses);
                MessageBox.Show("Try another letter! You have " + (10 - GameLogic.CountGuesses) + " chances left.", "Wrong Letter", MessageBoxButtons.OK);

            }
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            btnK.Enabled = false;
            if (GameLogic.GameWon == true)
            {
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else if (GameLogic.CorrectLetter('K'))
            {
                Wordbox.Text = GameLogic.SecretWord;
            }
            else if (GameLogic.IsCorrectLetter == false && GameLogic.CountGuesses == 10)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
            {
                WrongGuessImages(GameLogic.CountGuesses);
                MessageBox.Show("Try another letter! You have " + (10 - GameLogic.CountGuesses) + " chances left.", "Wrong Letter", MessageBoxButtons.OK);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnL.Enabled = false;
            if (GameLogic.GameWon == true)
            {
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else if (GameLogic.CorrectLetter('L'))
            {
                Wordbox.Text = GameLogic.SecretWord;
            }
            else if (GameLogic.IsCorrectLetter == false && GameLogic.CountGuesses == 10)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
            {
                WrongGuessImages(GameLogic.CountGuesses);
                MessageBox.Show("Try another letter! You have " + (10 - GameLogic.CountGuesses) + " chances left.", "Wrong Letter", MessageBoxButtons.OK);

            }
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            btnM.Enabled = false;
            if (GameLogic.GameWon == true)
            {
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else if (GameLogic.CorrectLetter('M'))
            {
                Wordbox.Text = GameLogic.SecretWord;
            }
            else if (GameLogic.IsCorrectLetter == false && GameLogic.CountGuesses == 10)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
            {
                WrongGuessImages(GameLogic.CountGuesses);
                MessageBox.Show("Try another letter! You have " + (10 - GameLogic.CountGuesses) + " chances left.", "Wrong Letter", MessageBoxButtons.OK);

            }
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            btnN.Enabled = false;
            if (GameLogic.GameWon == true)
            {
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else if (GameLogic.CorrectLetter('N'))
            {
                Wordbox.Text = GameLogic.SecretWord;
            }
            else if (GameLogic.IsCorrectLetter == false && GameLogic.CountGuesses == 10)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
            {
                WrongGuessImages(GameLogic.CountGuesses);
                MessageBox.Show("Try another letter! You have " + (10 - GameLogic.CountGuesses) + " chances left.", "Wrong Letter", MessageBoxButtons.OK);

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            btnO.Enabled = false;
            if (GameLogic.GameWon == true)
            {
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else if (GameLogic.CorrectLetter('O'))
            {
                Wordbox.Text = GameLogic.SecretWord;
            }
            else if (GameLogic.IsCorrectLetter == false && GameLogic.CountGuesses == 10)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
            {
                WrongGuessImages(GameLogic.CountGuesses);
                MessageBox.Show("Try another letter! You have " + (10 - GameLogic.CountGuesses) + " chances left.", "Wrong Letter", MessageBoxButtons.OK);

            }
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            btnP.Enabled = false;
            if (GameLogic.GameWon == true)
            {
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else if (GameLogic.CorrectLetter('P'))
            {
                Wordbox.Text = GameLogic.SecretWord;
            }
            else if (GameLogic.IsCorrectLetter == false && GameLogic.CountGuesses == 10)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
            {
                WrongGuessImages(GameLogic.CountGuesses);
                MessageBox.Show("Try another letter! You have " + (10 - GameLogic.CountGuesses) + " chances left.", "Wrong Letter", MessageBoxButtons.OK);

            }
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            btnQ.Enabled = false;
            if (GameLogic.GameWon == true)
            {
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else if (GameLogic.CorrectLetter('Q'))
            {
                Wordbox.Text = GameLogic.SecretWord;
            }
            else if (GameLogic.IsCorrectLetter == false && GameLogic.CountGuesses == 10)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
            {
                WrongGuessImages(GameLogic.CountGuesses);
                MessageBox.Show("Try another letter! You have " + (10 - GameLogic.CountGuesses) + " chances left.", "Wrong Letter", MessageBoxButtons.OK);

            }
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            btnR.Enabled = false;
            if (GameLogic.GameWon == true)
            {
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else if (GameLogic.CorrectLetter('R'))
            {
                Wordbox.Text = GameLogic.SecretWord;
            }
            else if (GameLogic.IsCorrectLetter == false && GameLogic.CountGuesses == 10)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
            {
                WrongGuessImages(GameLogic.CountGuesses);
                MessageBox.Show("Try another letter! You have " + (10 - GameLogic.CountGuesses) + " chances left.", "Wrong Letter", MessageBoxButtons.OK);

            }
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            btnS.Enabled = false;
            if (GameLogic.GameWon == true)
            {
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else if (GameLogic.CorrectLetter('S'))
            {
                Wordbox.Text = GameLogic.SecretWord;
            }
            else if (GameLogic.IsCorrectLetter == false && GameLogic.CountGuesses == 10)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
            {
                WrongGuessImages(GameLogic.CountGuesses);
                MessageBox.Show("Try another letter! You have " + (10 - GameLogic.CountGuesses) + " chances left.", "Wrong Letter", MessageBoxButtons.OK);

            }
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            btnT.Enabled = false;
            if (GameLogic.GameWon == true)
            {
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else if (GameLogic.CorrectLetter('T'))
            {
                Wordbox.Text = GameLogic.SecretWord;
            }
            else if (GameLogic.IsCorrectLetter == false && GameLogic.CountGuesses == 10)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
            {
                WrongGuessImages(GameLogic.CountGuesses);
                MessageBox.Show("Try another letter! You have " + (10 - GameLogic.CountGuesses) + " chances left.", "Wrong Letter", MessageBoxButtons.OK);

            }
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            btnU.Enabled = false;
            if (GameLogic.GameWon == true)
            {
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else if (GameLogic.CorrectLetter('U'))
            {
                Wordbox.Text = GameLogic.SecretWord;
            }
            else if (GameLogic.IsCorrectLetter == false && GameLogic.CountGuesses == 10)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
            {
                WrongGuessImages(GameLogic.CountGuesses);
                MessageBox.Show("Try another letter! You have " + (10 - GameLogic.CountGuesses) + " chances left.", "Wrong Letter", MessageBoxButtons.OK);

            }
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            btnV.Enabled = false;
            if (GameLogic.GameWon == true)
            {
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else if (GameLogic.CorrectLetter('V'))
            {
                Wordbox.Text = GameLogic.SecretWord;
            }
            else if (GameLogic.IsCorrectLetter == false && GameLogic.CountGuesses == 10)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
            {
                WrongGuessImages(GameLogic.CountGuesses);
                MessageBox.Show("Try another letter! You have " + (10 - GameLogic.CountGuesses) + " chances left.", "Wrong Letter", MessageBoxButtons.OK);

            }
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            btnW.Enabled = false;
            if (GameLogic.GameWon == true)
            {
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else if (GameLogic.CorrectLetter('W'))
            {
                Wordbox.Text = GameLogic.SecretWord;
            }
            else if (GameLogic.IsCorrectLetter == false && GameLogic.CountGuesses == 10)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
            {
                WrongGuessImages(GameLogic.CountGuesses);
                MessageBox.Show("Try another letter! You have " + (10 - GameLogic.CountGuesses) + " chances left.", "Wrong Letter", MessageBoxButtons.OK);

            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            btnX.Enabled = false;
            if (GameLogic.GameWon == true)
            {
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else if (GameLogic.CorrectLetter('X'))
            {
                Wordbox.Text = GameLogic.SecretWord;
            }
            else if (GameLogic.IsCorrectLetter == false && GameLogic.CountGuesses == 10)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
            {
                WrongGuessImages(GameLogic.CountGuesses);
                MessageBox.Show("Try another letter! You have " + (10 - GameLogic.CountGuesses) + " chances left.", "Wrong Letter", MessageBoxButtons.OK);

            }
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            btnY.Enabled = false;
            if (GameLogic.GameWon == true)
            {
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else if (GameLogic.CorrectLetter('Y'))
            {
                Wordbox.Text = GameLogic.SecretWord;
            }
            else if (GameLogic.IsCorrectLetter == false && GameLogic.CountGuesses == 10)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
            {
                WrongGuessImages(GameLogic.CountGuesses);
                MessageBox.Show("Try another letter! You have " + (10 - GameLogic.CountGuesses) + " chances left.", "Wrong Letter", MessageBoxButtons.OK);

            }
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            btnZ.Enabled = false;

            if (GameLogic.GameWon == true)
            {
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else if (GameLogic.CorrectLetter('Z'))
            {
                Wordbox.Text = GameLogic.SecretWord;
            }
            else if (GameLogic.IsCorrectLetter == false && GameLogic.CountGuesses == 10)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
            {
                WrongGuessImages(GameLogic.CountGuesses);
                MessageBox.Show("Try another letter! You have " + (10 - GameLogic.CountGuesses) + " chances left.", "Wrong Letter", MessageBoxButtons.OK);

            }
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            btnJ.Enabled = false;
            
            if (GameLogic.GameWon == true)
            {
                MessageBox.Show("U win", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else if (GameLogic.CorrectLetter('J'))
            {
                Wordbox.Text = GameLogic.SecretWord;
            }
            else if (GameLogic.IsCorrectLetter == false && GameLogic.CountGuesses == 10)
            {
                MessageBox.Show("U lost the game", "Do you want to start over?", MessageBoxButtons.OK);
            }
            else
            {
                WrongGuessImages(GameLogic.CountGuesses);
                MessageBox.Show("Try another letter! You have " + (10 - GameLogic.CountGuesses) + " chances left.", "Wrong Letter", MessageBoxButtons.OK);

            }
        }

        
        /// <summary>
        /// Sets the correct image based on guesses number
        /// </summary>
        /// <param name="nr"></param>
        private void WrongGuessImages(int nr)
        {
            string imgDir = @"C:\Users\zubair.gundersen\Documents\Visual Studio 2017\Projects\Hang a man\Hang a man\Resources\Hangman\";

            switch (nr)
            {
                case 1:
                    pcbHangMan.ImageLocation = imgDir + "1.jpg";
                    break;
                case 2:
                    pcbHangMan.ImageLocation = imgDir + "2.jpg";
                    break;
                case 3:
                    pcbHangMan.ImageLocation = imgDir + "3.jpg";
                    break;
                case 4:
                    pcbHangMan.ImageLocation = imgDir + "4.jpg";
                    break;
                case 5:
                    pcbHangMan.ImageLocation = imgDir + "5.jpg";
                    break;
                case 6:
                    pcbHangMan.ImageLocation = imgDir + "6.jpg";
                    break;
                case 7:
                    pcbHangMan.ImageLocation = imgDir + "7.jpg";
                    break;
                case 8:
                    pcbHangMan.ImageLocation = imgDir + "8.jpg";
                    break;
                case 9:
                    pcbHangMan.ImageLocation = imgDir + "9.jpg";
                    break;
                case 10:
                    pcbHangMan.ImageLocation = imgDir + "10.jpg";
                    break;
                default:
                    pcbHangMan.ImageLocation = imgDir + "0.jpg";
                    break;
            }

        }

        /// <summary>
        /// Plays background music for the game
        /// </summary>
        private void PlayGameMusic()
        {
            // Create new SoundPlayer in the using statement.
            using (SoundPlayer player = new SoundPlayer(@"C:\Users\zubair.gundersen\Documents\Visual Studio 2017\Projects\Hang a man\Hang a man\Resources\Hangman\Free Synthwave Loop.wav"))
            {

                player.PlayLooping();

            }
        }

    }
}
