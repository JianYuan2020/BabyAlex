using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BabyAlex.UI.ViewModel
{
  public class MainViewModel : ViewModelBase
  {
    public string Hello { get; set; }

    public MainViewModel(string helloText)
    {
      Hello = helloText;
    }

    public void Load()
    {
      MediaElement mediaElement = new MediaElement();

      // Initialize a new instance of the SpeechSynthesizer.  
      SpeechSynthesizer synth = new SpeechSynthesizer();

      // Configure the audio output.   
      synth.SetOutputToDefaultAudioDevice();

      // Speak the Hello asynchronously.  
      synth.SpeakAsync(Hello);

      //mediaElement.Play();

    }

  }
}
