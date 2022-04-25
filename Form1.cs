using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuepLeviGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String[] leviTalk = { "Oh... Who are you?", "", "...Poop Time?", "", "Oh, I'm sorry dear.", "Did you know...", "That I love you?", "", "" };
        String[] suepTalk = { "", "I'm SuepTime!", "", "What? No! SUEP TIME", "", "", "", "YOU DO?", "That's kinda cringe bro." };

        int buttonPressCount = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                leviTxt.Text = (leviTalk[buttonPressCount]);
                suepTxt.Text = (suepTalk[buttonPressCount]);
                if (buttonPressCount <= 9)
                {
                    buttonPressCount += 1;
                }
                else
                {
                    Console.WriteLine("Nope");
                }
            }
            catch
            {
                Console.WriteLine("oops");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonPressCount > 0)
                {
                    buttonPressCount -= 1;
                }
                else
                {
                    Console.WriteLine("Nope");
                }
                leviTxt.Text = (leviTalk[buttonPressCount]);
                suepTxt.Text = (suepTalk[buttonPressCount]);
            }
            catch
            {
                Console.WriteLine("oops");
            }
        }

    }
}
