using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace CarouselPageNavigation
{
	public partial class MainPage : CarouselPage
	{

       
        public int SlidePosition { get; set; }
        public MainPage ()
		{
			InitializeComponent ();


            ItemsSource = ImageViewModel.All;

            AutoSlide();

        }

       

        public void AutoSlide()
        {
            int currentPage = 0;
            Device.StartTimer(TimeSpan.FromSeconds(3), () =>
            {
                this.CurrentPage = this.Children[currentPage];

                if (currentPage == ImageViewModel.All.Count-1)
                {
                    currentPage = 0;
                }
                else
                {
                    currentPage++;
                }

                Console.WriteLine("HI");
              
                return true;
               
            });


        }


    }
}

