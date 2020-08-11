using UnityEngine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using System.Windows.Forms;
using AIMLbot;
// using System.Speech;
// using System.Speech.Synthesis;
namespace Artificial_Intelligence_Chatbot
{
    public class AimlBot: MonoBehaviour
    {
        public AimlBot()
        {
            // InitializeComponent();
        }

        /* private void pictureBox2_Click(object sender, EventArgs e)
        {
            GetBotResponse();
        }
        */
       private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                GetBotResponse();
            }
        }
        
        public void GetBotResponse()
        { 
            Debug.Log("GetBotResponse()");
            Bot AI = new Bot();
            AI.loadSettings();
            //Load AIML Files from the correct folder
            AI.loadAIMLFromFiles();
            // Temporarily Disable User Input
            AI.isAcceptingUserInput = false;

            Debug.Log("new User()");
            User myuser = new User("Username Here", AI);
            AI.isAcceptingUserInput = true;

            Debug.Log("new Request()");
            Request r = new Request("Hello World", myuser, AI);
            Result res = AI.Chat(r);
            Debug.Log("Bot response:  " + res.Output); 


            // OutputBox.Text = "Efface C# Bot: " + res.Output;

            //  SpeechSynthesizer reader = new SpeechSynthesizer();
            // reader.Speak(res.Output);

        }

        /* private void InputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                GetBotResponse();
                e.Handled = e.SuppressKeyPress = true; // Disabling Sound with the Enter Key
            }
        }

        private void OutputBox_TextChanged(object sender, EventArgs e)
        {

        }
        */

        }
    }

