using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace VoiceRecognition
{
    public partial class Voice_Display : Form
    {
        SpeechRecognitionEngine speechRecognitionEngine = new SpeechRecognitionEngine();
        

        public Voice_Display()
        {
            InitializeComponent();
        }

        private void enableBtn_Click(object sender, EventArgs e)
        {
            speechRecognitionEngine.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void disableBtn_Click(object sender, EventArgs e)
        {
            speechRecognitionEngine.RecognizeAsyncStop();
        }

        private void Voice_Display_Load(object sender, EventArgs e)
        {
            Choices name = new Choices();
            name.Add(new string[] { "Betty", "Madison", "Bear", "Duke" });

            GrammarBuilder grammarBuilder = new GrammarBuilder();
            grammarBuilder.Append(name);

            Grammar grammar = new Grammar(grammarBuilder);

            speechRecognitionEngine.LoadGrammarAsync(grammar);
            
            speechRecognitionEngine.SetInputToDefaultAudioDevice();
            speechRecognitionEngine.SpeechRecognized += speechRecognizer_SpeedRecognized;
            speechRecognitionEngine.SpeechRecognitionRejected += speechRecognizer_SpeedNotRecgonized;

            conversation_Log.Text += "\nSpeech initialized, awaiting speech...";
        }

        private void speechRecognizer_SpeedRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            conversation_Log.Text += $"Speach Recognized as '{e.Result.Text}'";
        }

        private void speechRecognizer_SpeedNotRecgonized(object sender, SpeechRecognitionRejectedEventArgs e)
        {
            conversation_Log.Text += $"Speech Rejected: '{e.Result.Text}'. THREAT DETECTED!";
        }
    }
}
