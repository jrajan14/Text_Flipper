/********************************************
 *               TEXT FLIPPER              ** 
 *                                         **
 *                                         **
 *           Programmed by J Rajan         **
 *                                         **
 *          To have fun with friends       **
 *                                         **
 * ******************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TextFlipper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string Originaltext;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnFlipText_Click(object sender, RoutedEventArgs e)
        {
            //MAKE THE TEXT BOX BLANK
            txtFlippedText.Text = "";

            if(txtOriginalText.Text == "")
            {
                MessageBox.Show("Text Box is Empty. \n Please Enter some text to flip", "Text Flipper", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                int strLength = txtOriginalText.Text.Length;

                for(int i = 0; i<strLength; i++)
                {
                    //txtFlippedText.Text += txtOriginalText.Text[i];

                    char letterCheck = txtOriginalText.Text[i];

                    //SMALL LETTERS
                    if (letterCheck == 'a')
                    {
                        txtFlippedText.Text += "ɐ";
                    }
                    if (letterCheck == 'b')
                    {
                        txtFlippedText.Text += "q";
                    }
                    if (letterCheck == 'c')
                    {
                        txtFlippedText.Text += "ɔ";
                    }
                    if (letterCheck == 'd')
                    {
                        txtFlippedText.Text += "p";
                    }
                    if (letterCheck == 'e')
                    {
                        txtFlippedText.Text += "ǝ";
                    }
                    if (letterCheck == 'f')
                    {
                        txtFlippedText.Text += "ɟ";
                    }
                    if (letterCheck == 'g')
                    {
                        txtFlippedText.Text += "ƃ";
                    }
                    if (letterCheck == 'h')
                    {
                        txtFlippedText.Text += "ɥ";
                    }
                    if (letterCheck == 'i')
                    {
                        txtFlippedText.Text += "ᴉ";
                    }
                    if (letterCheck == 'j')
                    {
                        txtFlippedText.Text += "ɾ";
                    }
                    if (letterCheck == 'k')
                    {
                        txtFlippedText.Text += "ʞ";
                    }
                    if (letterCheck == 'l')
                    {
                        txtFlippedText.Text += "ן";
                    }
                    if (letterCheck == 'm')
                    {
                        txtFlippedText.Text += "ɯ";
                    }
                    if (letterCheck == 'n')
                    {
                        txtFlippedText.Text += "u";
                    }
                    if (letterCheck == 'o')
                    {
                        txtFlippedText.Text += "o";
                    }
                    if (letterCheck == 'p')
                    {
                        txtFlippedText.Text += "d";
                    }
                    if (letterCheck == 'q')
                    {
                        txtFlippedText.Text += "b";
                    }
                    if (letterCheck == 'r')
                    {
                        txtFlippedText.Text += "ɹ";
                    }
                    if (letterCheck == 's')
                    {
                        txtFlippedText.Text += "s";
                    }
                    if (letterCheck == 't')
                    {
                        txtFlippedText.Text += "ʇ";
                    }
                    if (letterCheck == 'u')
                    {
                        txtFlippedText.Text += "n";
                    }
                    if (letterCheck == 'v')
                    {
                        txtFlippedText.Text += "ʌ";
                    }
                    if (letterCheck == 'w')
                    {
                        txtFlippedText.Text += "ʍ";
                    }
                    if (letterCheck == 'x')
                    {
                        txtFlippedText.Text += "x";
                    }
                    if (letterCheck == 'y')
                    {
                        txtFlippedText.Text += "ʎ";
                    }
                    if (letterCheck == 'z')
                    {
                        txtFlippedText.Text += "z";
                    }
                    if (letterCheck == ' ')
                    {
                        txtFlippedText.Text += " ";
                    }

                    //CAPITAL LETTERS
                    if (letterCheck == 'A')
                    {
                        txtFlippedText.Text += "∀";
                    }
                    if (letterCheck == 'B')
                    {
                        txtFlippedText.Text += "𐐒";
                    }
                    if (letterCheck == 'C')
                    {
                        txtFlippedText.Text += "Ɔ";
                    }
                    if (letterCheck == 'D')
                    {
                        txtFlippedText.Text += "p";
                    }
                    if (letterCheck == 'E')
                    {
                        txtFlippedText.Text += "Ǝ";
                    }
                    if (letterCheck == 'F')
                    {
                        txtFlippedText.Text += "Ⅎ";
                    }
                    if (letterCheck == 'G')
                    {
                        txtFlippedText.Text += "פ";
                    }
                    if (letterCheck == 'H')
                    {
                        txtFlippedText.Text += "H";
                    }
                    if (letterCheck == 'I')
                    {
                        txtFlippedText.Text += "I";
                    }
                    if (letterCheck == 'J')
                    {
                        txtFlippedText.Text += "ſ";
                    }
                    if (letterCheck == 'K')
                    {
                        txtFlippedText.Text += "ʞ";
                    }
                    if (letterCheck == 'L')
                    {
                        txtFlippedText.Text += "˥";
                    }
                    if (letterCheck == 'M')
                    {
                        txtFlippedText.Text += "W";
                    }
                    if (letterCheck == 'N')
                    {
                        txtFlippedText.Text += "N";
                    }
                    if (letterCheck == 'O')
                    {
                        txtFlippedText.Text += "o";
                    }
                    if (letterCheck == 'P')
                    {
                        txtFlippedText.Text += "d";
                    }
                    if (letterCheck == 'Q')
                    {
                        txtFlippedText.Text += "b";
                    }
                    if (letterCheck == 'R')
                    {
                        txtFlippedText.Text += "ɹ";
                    }
                    if (letterCheck == 'S')
                    {
                        txtFlippedText.Text += "s";
                    }
                    if (letterCheck == 'T')
                    {
                        txtFlippedText.Text += "┴";
                    }
                    if (letterCheck == 'U')
                    {
                        txtFlippedText.Text += "∩";
                    }
                    if (letterCheck == 'V')
                    {
                        txtFlippedText.Text += "Λ";
                    }
                    if (letterCheck == 'W')
                    {
                        txtFlippedText.Text += "M";
                    }
                    if (letterCheck == 'X')
                    {
                        txtFlippedText.Text += "X";
                    }
                    if (letterCheck == 'Y')
                    {
                        txtFlippedText.Text += "⅄";
                    }
                    if (letterCheck == 'Z')
                    {
                        txtFlippedText.Text += "Z";
                    }

                }
                
            }

        }

        private void btnReverse_Click(object sender, RoutedEventArgs e)
        {
            //MAKE THE TEXT BOX BLANK
            txtReversedText.Text = "";

            int strLength = txtOriginalText.Text.Length;

            if (txtOriginalText.Text == "")
            {
                MessageBox.Show("Text Box is Empty. \n Please Enter some text to flip", "Text Flipper", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {

                for (int i = strLength-1; i >= 0; i--)
                {
                    txtReversedText.Text += txtOriginalText.Text[i];
                }

            }

            if(txtReversedText.Text != "")
            {
                for (int i = 0; i < strLength; i++)
                {
                    //txtFlippedText.Text += txtOriginalText.Text[i];

                    char letterCheck = txtReversedText.Text[i];

                    //SMALL LETTERS
                    if (letterCheck == 'a')
                    {
                        txtReverseFlipped.Text += "ɐ";
                    }
                    if (letterCheck == 'b')
                    {
                        txtReverseFlipped.Text += "q";
                    }
                    if (letterCheck == 'c')
                    {
                        txtReverseFlipped.Text += "ɔ";
                    }
                    if (letterCheck == 'd')
                    {
                        txtReverseFlipped.Text += "p";
                    }
                    if (letterCheck == 'e')
                    {
                        txtReverseFlipped.Text += "ǝ";
                    }
                    if (letterCheck == 'f')
                    {
                        txtReverseFlipped.Text += "ɟ";
                    }
                    if (letterCheck == 'g')
                    {
                        txtReverseFlipped.Text += "ƃ";
                    }
                    if (letterCheck == 'h')
                    {
                        txtReverseFlipped.Text += "ɥ";
                    }
                    if (letterCheck == 'i')
                    {
                        txtReverseFlipped.Text += "ᴉ";
                    }
                    if (letterCheck == 'j')
                    {
                        txtReverseFlipped.Text += "ɾ";
                    }
                    if (letterCheck == 'k')
                    {
                        txtReverseFlipped.Text += "ʞ";
                    }
                    if (letterCheck == 'l')
                    {
                        txtReverseFlipped.Text += "ן";
                    }
                    if (letterCheck == 'm')
                    {
                        txtReverseFlipped.Text += "ɯ";
                    }
                    if (letterCheck == 'n')
                    {
                        txtReverseFlipped.Text += "u";
                    }
                    if (letterCheck == 'o')
                    {
                        txtReverseFlipped.Text += "o";
                    }
                    if (letterCheck == 'p')
                    {
                        txtReverseFlipped.Text += "d";
                    }
                    if (letterCheck == 'q')
                    {
                        txtReverseFlipped.Text += "b";
                    }
                    if (letterCheck == 'r')
                    {
                        txtReverseFlipped.Text += "ɹ";
                    }
                    if (letterCheck == 's')
                    {
                        txtReverseFlipped.Text += "s";
                    }
                    if (letterCheck == 't')
                    {
                        txtReverseFlipped.Text += "ʇ";
                    }
                    if (letterCheck == 'u')
                    {
                        txtReverseFlipped.Text += "n";
                    }
                    if (letterCheck == 'v')
                    {
                        txtReverseFlipped.Text += "ʌ";
                    }
                    if (letterCheck == 'w')
                    {
                        txtReverseFlipped.Text += "ʍ";
                    }
                    if (letterCheck == 'x')
                    {
                        txtReverseFlipped.Text += "x";
                    }
                    if (letterCheck == 'y')
                    {
                        txtReverseFlipped.Text += "ʎ";
                    }
                    if (letterCheck == 'z')
                    {
                        txtReverseFlipped.Text += "z";
                    }
                    if (letterCheck == ' ')
                    {
                        txtReverseFlipped.Text += " ";
                    }

                    //CAPITAL LETTERS
                    if (letterCheck == 'A')
                    {
                        txtReverseFlipped.Text += "∀";
                    }
                    if (letterCheck == 'B')
                    {
                        txtReverseFlipped.Text += "𐐒";
                    }
                    if (letterCheck == 'C')
                    {
                        txtReverseFlipped.Text += "Ɔ";
                    }
                    if (letterCheck == 'D')
                    {
                        txtReverseFlipped.Text += "p";
                    }
                    if (letterCheck == 'E')
                    {
                        txtReverseFlipped.Text += "Ǝ";
                    }
                    if (letterCheck == 'F')
                    {
                        txtReverseFlipped.Text += "Ⅎ";
                    }
                    if (letterCheck == 'G')
                    {
                        txtReverseFlipped.Text += "פ";
                    }
                    if (letterCheck == 'H')
                    {
                        txtReverseFlipped.Text += "H";
                    }
                    if (letterCheck == 'I')
                    {
                        txtReverseFlipped.Text += "I";
                    }
                    if (letterCheck == 'J')
                    {
                        txtReverseFlipped.Text += "ſ";
                    }
                    if (letterCheck == 'K')
                    {
                        txtReverseFlipped.Text += "ʞ";
                    }
                    if (letterCheck == 'L')
                    {
                        txtReverseFlipped.Text += "˥";
                    }
                    if (letterCheck == 'M')
                    {
                        txtReverseFlipped.Text += "W";
                    }
                    if (letterCheck == 'N')
                    {
                        txtReverseFlipped.Text += "N";
                    }
                    if (letterCheck == 'O')
                    {
                        txtReverseFlipped.Text += "o";
                    }
                    if (letterCheck == 'P')
                    {
                        txtReverseFlipped.Text += "d";
                    }
                    if (letterCheck == 'Q')
                    {
                        txtReverseFlipped.Text += "b";
                    }
                    if (letterCheck == 'R')
                    {
                        txtReverseFlipped.Text += "ɹ";
                    }
                    if (letterCheck == 'S')
                    {
                        txtReverseFlipped.Text += "s";
                    }
                    if (letterCheck == 'T')
                    {
                        txtReverseFlipped.Text += "┴";
                    }
                    if (letterCheck == 'U')
                    {
                        txtReverseFlipped.Text += "∩";
                    }
                    if (letterCheck == 'V')
                    {
                        txtReverseFlipped.Text += "Λ";
                    }
                    if (letterCheck == 'W')
                    {
                        txtReverseFlipped.Text += "M";
                    }
                    if (letterCheck == 'X')
                    {
                        txtReverseFlipped.Text += "X";
                    }
                    if (letterCheck == 'Y')
                    {
                        txtReverseFlipped.Text += "⅄";
                    }
                    if (letterCheck == 'Z')
                    {
                        txtReverseFlipped.Text += "Z";
                    }

                }
            }
        }
    }
}
