using System;
using Xamarin.Forms;

namespace Carousel_App
{
    public partial class MainPage : CarouselPage
    {
        string[] imageTitles = {
            "GIGABYTE GeForce RTX­­™ 4060",
            "GIGABYTE GeForce RTX­­™ 4070",
            "GIGABYTE GeForce RTX­­™ 4080",
            "GIGABYTE GeForce RTX­­™ 4090"
        };

        string[] imageDescriptions = {
            "The GIGABYTE GeForce RTX­­™ 4060 GAMING OC 8G is a high-performance graphics card designed for gaming. It features the NVIDIA GeForce RTX 4060 chipset with 8GB of GDDR6 graphics memory. With a 128-bit memory interface and PCIE 4.0 16x support, it delivers smooth and immersive gaming experiences. It also comes with dual slot fansink cooling, 2 HDMI connections, and 2 DisplayPort connections.",
            "GeForce RTX­­™ 4070 GAMING OC 12G - Powered by NVIDIA DLSS 3, ultra-efficient Ada Lovelace arch, and full ray tracing - 4th Generation Tensor Cores: Up to 4x performance with DLSS 3 vs. brute-force rendering - 3rd Generation RT Cores: Up to 2X ray tracing performance - Powered by GeForce RTX™ 4070 - Integrated with 12GB GDDR6X 192bit memory interface - WINDFORCE cooling system - RGB Fusion - Dual BIOS - Protection metal back plate",
            "The Gigabyte GeForce RTX 4080 16GB EAGLE OC DLSS 3 is a high-end graphics card designed for gaming and professional use. With 16GB of GDDR6X VRAM and a GPU clock speed of 2520 MHz, this card delivers exceptional performance for demanding applications. It also supports DLSS 3, which uses AI to improve gaming performance and image quality. The card has 3 DisplayPort and 1 HDMI connections, and requires a 900W power supply.",
            "e Gigabyte GeForce RTX 4090 GAMING OC 24G DLSS 3 is a high-end graphics card designed for gaming and professional use. It features the latest Lovelace architecture from NVIDIA, with new streaming multiprocessors, tensor cores, and RT cores for improved performance and ray tracing capabilities. It also supports DLSS 3 for improved AI-accelerated graphics, and features a dual slot fansink cooling system for efficient heat dissipation."
        };

        public MainPage()
        {
            Image[] images = {
                new Image { Source = "six.png", WidthRequest = 400, HeightRequest = 400, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.CenterAndExpand },
                new Image { Source = "seven.png", WidthRequest = 400, HeightRequest = 400, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.CenterAndExpand },
                new Image { Source = "eigth.png", WidthRequest = 400, HeightRequest = 400, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.CenterAndExpand },
                new Image { Source = "nine.png", WidthRequest = 400, HeightRequest = 400, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.CenterAndExpand }
            };

            for (int i = 0; i < images.Length; i++)
            {
                int index = i;

                images[i].GestureRecognizers.Add(new TapGestureRecognizer
                {
                    Command = new Command(() => DisplayAlert(imageTitles[index], imageDescriptions[index], "Osta"))
                });

                Children.Add(new ContentPage
                {
                    Content = new StackLayout
                    {
                        Children =
                        {
                            new Label
                            {
                                Text = imageTitles[index],
                                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                                HorizontalOptions = LayoutOptions.Center
                            },
                            images[index]
                        }
                    }
                });
            }
        }
    }
}
