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

        int buttonPressCount = 0;   //keeps track of where the dialogue is

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                leviTxt.Text = (leviTalk[buttonPressCount]);
                suepTxt.Text = (suepTalk[buttonPressCount]);
                if (buttonPressCount <= 9)  //hard coded based on the amount of dialogue. Not optimal, but it'll work
                {
                    buttonPressCount += 1;  //if you press the button it moves forward 1 piece of dialogue
                }
                else
                {
                    Console.WriteLine("Nope"); //if you exceed the dialogue
                }
            }
            catch
            {
                Console.WriteLine("oops"); //if you got out of bounds of the array
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonPressCount > 0)
                {
                    buttonPressCount -= 1;  //steps back one part in dialogue
                }
                else
                {
                    Console.WriteLine("Nope");  //if you exceed the dialogue
                }
                leviTxt.Text = (leviTalk[buttonPressCount]);
                suepTxt.Text = (suepTalk[buttonPressCount]);
            }
            catch
            {
                Console.WriteLine("oops");  //if you got out of bounds of the array
            }
        }

    }
}
