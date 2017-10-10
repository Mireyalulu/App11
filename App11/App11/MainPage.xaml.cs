using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App11
{
    public partial class MainPage : CarouselPage
    {
        public MainPage()
        {
            InitializeComponent();

            ima.Source = new UriImageSource
            {
                Uri = new Uri("https://i.blogs.es/f48d28/appstore/original.jpg")
            };

            imag.Source = new UriImageSource
            {
                Uri = new Uri("http://holatelcel.com/wp-content/uploads/2014/10/Apps-android-2.jpg")
            };
            imag1.Source = new UriImageSource
            {
                Uri = new Uri("https://appaplicacionpara.com/wp-content/uploads/2016/06/App-para-Windows-Phone-8.1.png")
            };
            imag2.Source = new UriImageSource
            {
                Uri = new Uri("https://store.storeimages.cdn-apple.com/4974/as-images.apple.com/is/image/AppleInc/aos/published/images/i/ph/iphone7/plus/iphone7-plus-silver-select-2016?wid=300&hei=300&fmt=png-alpha&qlt=95&.v=1472430173129")
            };
            imag3.Source = new UriImageSource
            {
                Uri = new Uri("http://omicrono.elespanol.com/wp-content/uploads/2015/12/android-logo.jpg")
            };

        }
        int count = 0;
        int countDislike = 0;
        int count1 = 0;
        int countDislike1 = 0;
        int count2 = 0;
        int countDislike2 = 0;
        int count3 = 0;
        int countDislike3 = 0;
        int count4 = 0;
        int countDislike4 = 0;
        int count5 = 0;
        int countDislike5 = 0;
        int count6 = 0;
        int countDislike6 = 0;
        int count7 = 0;
        int countDislike7 = 0;
        int count8 = 0;
        int countDislike8 = 0;
        int count9 = 0;
        int countDislike9 = 0;



        protected override void OnAppearing()
        {
            base.OnAppearing();

            HDCsumar.Clicked += HDCsumar_Clicked;
            HDCsumar1.Clicked += HDCsumar1_Clicked;
            HDCsumar2.Clicked += HDCsumar2_Clicked;
            HDCsumar3.Clicked += HDCsumar3_Clicked;
            HDCsumar4.Clicked += HDCsumar4_Clicked;
            HDCsumar5.Clicked += HDCsumar5_Clicked;
            HDCsumar6.Clicked += HDCsumar6_Clicked;
            HDCsumar7.Clicked += HDCsumar7_Clicked;
            HDCsumar8.Clicked += HDCsumar8_Clicked;
            HDCsumar9.Clicked += HDCsumar9_Clicked;
            HDCsumar10.Clicked += HDCsumar10_Clicked;
            HDCsumar11.Clicked += HDCsumar11_Clicked;
            HDCsumar12.Clicked += HDCsumar12_Clicked;
            HDCsumar13.Clicked += HDCsumar13_Clicked;
            HDCsumar14.Clicked += HDCsumar14_Clicked;
            HDCsumar15.Clicked += HDCsumar15_Clicked;
            HDCsumar16.Clicked += HDCsumar16_Clicked;
            HDCsumar17.Clicked += HDCsumar17_Clicked;
            HDCsumar18.Clicked += HDCsumar18_Clicked;
            HDCsumar19.Clicked += HDCsumar19_Clicked;
           
        }

        private void HDCsumar19_Clicked(object sender, EventArgs e)
        {
            countDislike9++;
            HDCsumar19.Text = countDislike9.ToString();
        }

        private void HDCsumar18_Clicked(object sender, EventArgs e)
        {
            count9++;
            HDCsumar18.Text = count9.ToString();
        }

        private void HDCsumar17_Clicked(object sender, EventArgs e)
        {
            countDislike8++;
            HDCsumar17.Text = countDislike8.ToString();
        }

        private void HDCsumar16_Clicked(object sender, EventArgs e)
        {
            count8++;
            HDCsumar16.Text = count8.ToString();
        }

        private void HDCsumar15_Clicked(object sender, EventArgs e)
        {
            countDislike7++;
            HDCsumar15.Text = countDislike7.ToString();
        }

        private void HDCsumar14_Clicked(object sender, EventArgs e)
        {
            count7++;
            HDCsumar14.Text = count7.ToString();
        }

        private void HDCsumar13_Clicked(object sender, EventArgs e)
        {
            countDislike6++;
            HDCsumar13.Text = countDislike6.ToString();
        }

        private void HDCsumar12_Clicked(object sender, EventArgs e)
        {
            count6++;
            HDCsumar12.Text = count6.ToString();
        }

        private void HDCsumar11_Clicked(object sender, EventArgs e)
        {
            countDislike5++;
            HDCsumar11.Text = countDislike5.ToString();
        }

        private void HDCsumar10_Clicked(object sender, EventArgs e)
        {
            count5++;
            HDCsumar10.Text = count5.ToString();
        }

        private void HDCsumar9_Clicked(object sender, EventArgs e)
        {
            countDislike4++;
            HDCsumar9.Text = countDislike4.ToString();
        }

        private void HDCsumar8_Clicked(object sender, EventArgs e)
        {
            count4++;
            HDCsumar8.Text = count4.ToString();
        }

        private void HDCsumar7_Clicked(object sender, EventArgs e)
        {
            countDislike3++;
            HDCsumar7.Text = countDislike3.ToString();
        }

        private void HDCsumar6_Clicked(object sender, EventArgs e)
        {
            count3++;
            HDCsumar6.Text = count3.ToString();
        }

        private void HDCsumar5_Clicked(object sender, EventArgs e)
        {
            countDislike2++;
            HDCsumar5.Text = countDislike2.ToString();
        }

        private void HDCsumar4_Clicked(object sender, EventArgs e)
        {
            count2++;
            HDCsumar4.Text = count2.ToString();
        }

        private void HDCsumar3_Clicked(object sender, EventArgs e)
        {
            countDislike1++;
            HDCsumar3.Text = countDislike1.ToString();
        }

        private void HDCsumar2_Clicked(object sender, EventArgs e)
        {
            count1++;
            HDCsumar2.Text = count1.ToString();
        }

        private void HDCsumar1_Clicked(object sender, EventArgs e)
        {
            countDislike++;
            HDCsumar1.Text = countDislike.ToString();
        }

        private void HDCsumar_Clicked(object sender, EventArgs e)
        {
            count++;
            HDCsumar.Text = count.ToString();

        }

        private void consulat_Clicked(object sender, EventArgs e)
        {
            int sumLikes = count + count1 + count3 + count4 + count5 + count6 + count7 + count8 + count9;
            int sumDisLikes = countDislike + countDislike1 + countDislike3 + countDislike4 + countDislike5 + countDislike6 + countDislike7 + countDislike8 + countDislike9;
            like.Text = "Fotos con Likes=" + sumLikes+" y Fotos con disLike="+sumDisLikes;
        }
    }
}
