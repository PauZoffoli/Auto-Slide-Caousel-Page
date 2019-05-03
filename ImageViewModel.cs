using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace CarouselPageNavigation
{
    public class ImageViewModel : NotificationObject
    {

        public static ObservableCollection<ImageViewModel> All { get; set; }


        private string imageSource;

        public string ImageSource

        {

            get { return imageSource; }

            set { imageSource = value; OnPropertyChanged(); }

        }
        private Color colores;

        public Color Colores

        {

            get { return colores; }

            set { colores = value; OnPropertyChanged(); }

        }


        static ImageViewModel()
        {
            All = new ObservableCollection<ImageViewModel> {
                new ImageViewModel {
                    ImageSource = "http://192.168.20.38:8000/api/imagenes/divinagabriela/banner/banner1",
                    Colores = Color.Red
                },
                new ImageViewModel {
                    ImageSource = "http://192.168.20.38:8000/api/imagenes/divinagabriela/banner/banner2",
                    Colores = Color.Green
                },
                new ImageViewModel {
                    ImageSource = "http://192.168.20.38:8000/api/imagenes/divinagabriela/banner/banner3",
                    Colores = Color.Blue
                }
            };
        }


    
    }
}
