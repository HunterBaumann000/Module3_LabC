using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Module3_LabC
{
    public partial class MainPage : ContentPage
    {

        IList<string> Questions = new List<string>() { "In Scotland, the unicorn is their national animal.", "The first living animal sent into space were fruit flies.", "Seahorses have stomachs, which aid in the digestion of food." };
        IList<Boolean> Answers = new List<Boolean>() {true, true, false };
        IList<string> Images = new List<string>() { "unicorn2a.jpg", "spaceshipp.jpg", "seahorse.jpg" };
        private int Index = 0;
        private int CountCorrect = 0;

        public MainPage()
        {
            InitializeComponent();
            Question.Text = Questions[Index];
            TheImage.Source = Images[Index];
        }
         
        void OnSwiped(Object sender, SwipedEventArgs e)
        {
            if(e.Direction == SwipeDirection.Right)
            {
                True();
            }
            else
            {
                False();
            }
        }

        void True()
        {
            if (Answers[Index++] == true)
            {
                CountCorrect++;
            }

            if(Index < Questions.Count)
            {
                Question.Text = Questions[Index];
                TheImage.Source = Images[Index];
            }
            else
            {
                TheImage.IsVisible = false;
                Question.Text = $"Correctly Answered: {CountCorrect}";
            }
        }

        void False()
        {
            if (Answers[Index++] == false)
            {
                CountCorrect++;
            }

            if (Index < Questions.Count)
            {
                Question.Text = Questions[Index];
                TheImage.Source = Images[Index];
            }
            else
            {
                TheImage.IsVisible = false;
                Question.Text = $"Correctly Answered: {CountCorrect}";
            }
        }
    }
}
