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

namespace VoiceRecognitionForm
{
    public partial class Voice_Display : Form
    {

        SpeechRecognitionEngine speechRecognitionEngine = new SpeechRecognitionEngine();
        SpeechRecognitionEngine actualSpeechRecognitionEngine = new SpeechRecognitionEngine();

        public Voice_Display()
        {
            InitializeComponent();
        }
        
        private void Voice_Display_Load(object sender, EventArgs e)
        {
            //Set Password Recognition
            Choices name = new Choices();
            name.Add(new string[] { "Hello", "Yellow Orangotang", "Green", "Lemur Foxtrot", "Blue" });

            GrammarBuilder grammarBuilder = new GrammarBuilder();
            grammarBuilder.Append(name);

            Grammar grammar = new Grammar(grammarBuilder);

            speechRecognitionEngine.LoadGrammarAsync(grammar);

            speechRecognitionEngine.SetInputToDefaultAudioDevice();
            speechRecognitionEngine.SpeechRecognized += speechRecognizer_SpeedRecognized;
            speechRecognitionEngine.SpeechRecognitionRejected += speechRecognizer_SpeedNotRecgonized;

            //Set Actual Speech Recognition
            //TODO: Make this work better to only pick up when password is given
            actualSpeechRecognitionEngine.SetInputToDefaultAudioDevice();
            Grammar actualGrammar = new DictationGrammar();
            actualSpeechRecognitionEngine.LoadGrammar(actualGrammar);
            actualSpeechRecognitionEngine.RecognizeAsync(RecognizeMode.Multiple);
            actualSpeechRecognitionEngine.SpeechRecognized += ActualSpeech_Recognized;
        }

        private void speechRecognizer_SpeedRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if(e.Result.Confidence > .60)
            {
                if(e.Result.Text == "Hello")
                {
                    conversation_Log.Text += $"\nSpeach Recognized as 'Madison'. Hello Madison!";
                }
                conversation_Log.Text += $"\nSpeach Recognized as '{e.Result.Text}': Confidence: '{e.Result.Confidence}'";
            }
            else
            {
                conversation_Log.Text += $"\nNot Confident in Speech: '{e.Result.Confidence}'. THREAT DETECTED!";
            }
        }

        private void speechRecognizer_SpeedNotRecgonized(object sender, SpeechRecognitionRejectedEventArgs e)
        {
            conversation_Log.Text += $"\nSpeech Rejected: '{e.Result.Confidence}'. THREAT DETECTED!";
        }

        private void ActualSpeech_Recognized(object sender, SpeechRecognizedEventArgs e)
        {
            conversation_Log.Text += $"\nSpeech Recorded: '{e.Result.Text}'.";
        }

        private void enableBtn_Click1_Click(object sender, EventArgs e)
        {
            speechRecognitionEngine.RecognizeAsync(RecognizeMode.Multiple);
            disableBtn_Click1.Enabled = true;
        }

        private void disableBtn_Click1_Click(object sender, EventArgs e)
        {
            speechRecognitionEngine.RecognizeAsyncStop();
            disableBtn_Click1.Enabled = false;
        }
    }
}
