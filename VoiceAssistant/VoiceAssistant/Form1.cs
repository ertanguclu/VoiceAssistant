using System;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace VoiceAssistant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SpeechRecognitionEngine record = new SpeechRecognitionEngine();
        SpeechSynthesizer sentence = new SpeechSynthesizer();

        private void PbxMic1_Click(object sender, EventArgs e)
        {
            pbxMic1.Visible = false;
            record.RecognizeAsync();
        }

        private void PbxMic2_Click(object sender, EventArgs e)
        {
            pbxMic1.Visible = true;
        }

        void VoiceMatch()
        {
            string[] commands = { "Hello", "How are you","Open Visual","Open Opera","Show commands" };
            Choices  options= new Choices(commands);
            Grammar grammar = new Grammar(new GrammarBuilder(options));
            record.LoadGrammar(grammar);
            record.SetInputToDefaultAudioDevice();
            record.SpeechRecognized += VoiceMatched;
            foreach(var c in commands)
            {
                lbxCommands.Items.Add(c);
            }
        }
        private void VoiceMatched(object sender, SpeechRecognizedEventArgs e)
        {
            pbxMic1.Visible = true;
            if(e.Result.Text=="Open Visual")
            {
                sentence.SpeakAsync("Okey");
                System.Diagnostics.Process.Start("\"C:\\Program Files\\Microsoft Visual Studio\\2022\\Community\\Common7\\IDE\\devenv.exe\"");
            }
            if (e.Result.Text == "Open Opera")
            {
                sentence.SpeakAsync("Okey I open opera");
                System.Diagnostics.Process.Start("\"C:\\Users\\ETİ\\AppData\\Local\\Programs\\Opera\\launcher.exe\"");
            }
            if (e.Result.Text == "Hello")
            {
                sentence.SpeakAsync("Hello What's up");
                
            }
            if (e.Result.Text == "Show commands")
            {
                timer1.Start();
                sentence.SpeakAsync("Okey");
                lbxCommands.Visible = true;

            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VoiceMatch();
        }

        private void OptionMenu_Click(object sender, EventArgs e)
        {
            pbxMic1.Visible=false;
            pbxMic2.Visible=false;
            lblOptions.Visible = true;
        }

        private void SpeakMenu_Click(object sender, EventArgs e)
        {
            pbxMic1.Visible = true;
            pbxMic2.Visible = true;
            lblOptions.Visible = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbxCommands.Visible=false;
            sentence.SpeakAsync("Closed");
        }
    }
}
