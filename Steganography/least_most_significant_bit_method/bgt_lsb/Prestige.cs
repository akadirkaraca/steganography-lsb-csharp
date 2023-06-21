using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace bgt_lsb
{

    class Prestige
    {

        public enum State
        {
            Hiding,
            Solving,
            End_of_Text
        };

        public static Bitmap Encode(string secretText, Bitmap coverImage, int changeBitValue)
        {
            // Başlangıç olarak karakterleri resmin içine saklayacağız.
            State state = State.Hiding;

            // Gizlenen karakterlerin indexini tutar.
            int charIndex = 0;
            // Integer 'e dönüştürülen karakterin değerini tutar.
            int charValue = 0;
            // Şu an işlenen renk elementlerinin (R, G, B) indexini tutar.
            int newCharControl = 0;
            // Pixel elementlerinin değerini tutar
            int R = 0, G = 0, B = 0;
            //Pixellerin elementlerindeki (RGB) sondan kaç bitine gizleme yapılacağının değerini tutar
            int changeBit = changeBitValue;

            secretText += '\0';

            for (int i = 0; i < coverImage.Height && state != State.End_of_Text; i++)
            {
                for (int j = 0; j < coverImage.Width && state != State.End_of_Text; j++)
                {
                    Color pixel = coverImage.GetPixel(j, i);

                    //Her pixel elementinin en düşük değerli(LSB) belirli bitini temizler
                    R = pixel.R - pixel.R % Convert.ToInt32(Math.Pow((double)2, changeBit));
                    G = pixel.G - pixel.G % Convert.ToInt32(Math.Pow((double)2, changeBit));
                    B = pixel.B - pixel.B % Convert.ToInt32(Math.Pow((double)2, changeBit));

                    // Pixellerin kendi içindeki elementlerin (RGB) geçişini sağlar
                    for (int n = 0; n < 3; n++)
                    {
                        // Eğer yeni 8 bit(karakter) işleme girdiyse diğer pixele geçişini sağlar.
                        if (newCharControl == 0 || newCharControl > 8) //7
                        {
                            // Bütün karakterler gizlendi mi? kontrol et.
                            if (charIndex >= secretText.Length)
                            {
                                // Gizlenecek verinin sonuna gelindiyse ana döngüden(resim pixellerinin baştan başlayarak, satır ve sutun geçişi için olan döngü) çık.
                                state = State.End_of_Text;
                            }
                            else
                            {
                                // Sonra ki karaktere geç ve işlemleri tekrarla
                                charValue = secretText[charIndex++];
                                newCharControl = 0;
                            }
                        }

                        //İşlem sırası pixelin hangi elementi üzerinde yapılacak
                        switch (n)
                        {
                            case 0:
                                {
                                    if (state == State.Hiding)
                                    {
                                        R += charValue % Convert.ToInt32(Math.Pow((double)2, changeBit));
                                        charValue /= Convert.ToInt32(Math.Pow((double)2, changeBit));
                                    }
                                }
                                break;
                            case 1:
                                {
                                    if (state == State.Hiding)
                                    {
                                        G += charValue % Convert.ToInt32(Math.Pow((double)2, changeBit));
                                        charValue /= Convert.ToInt32(Math.Pow((double)2, changeBit));
                                    }

                                }
                                break;
                            case 2:
                                {
                                    if (state == State.Hiding)
                                    {
                                        B += charValue % Convert.ToInt32(Math.Pow((double)2, changeBit));
                                        charValue /= Convert.ToInt32(Math.Pow((double)2, changeBit));
                                    }

                                    coverImage.SetPixel(j, i, Color.FromArgb(R, G, B));
                                }
                                break;
                        }
                        // secretText teki sıradaki karaktere geçilip geçilmediğini kontrol etmek için
                        newCharControl += (int)changeBit;
                    }
                }
            }
            return coverImage;
        }

        public static String Decode(Bitmap stegoImage, int changedBit)
        {

            State state = State.Solving;
            // Pixel elementlerinin değerini tutar
            int R = 0, G = 0, B = 0;

            string hiddenText = "";
            char hiddenChar;
            int hiddenCharValue = 0;

            //Gizli metnin, her bir karakter için pixelin elementlerinin sondan kaç bitinde işlem yapılarak elde edildiğine göre kaç defa döngüye girilecek
            int[] iterationCountPerChar = new int[] { 0, 8, 4, 2, 2, 1, 1, 1, 1 };
            //İşlem yapılan pixel elementlerinin, metin gizlenirken kaç bit olarak gizlendiyse RGB renk kanallarında karakterlerin ascii değerlerini elde ederken, sadece sondan belirli bitlerin decimal karşılığını elde etmek için
            int[] maskForGetLsbValue = new[] { 0, 1, 3, 7, 15, 31, 63, 127, 255 };
            //iterationCountPerChar[] dizisindeki iterasyonu takip etmek
            int currentIterationCount = 0;
            //Karakter kaç bit değiştirilerek gizlenmişse, tekrar elde ederken(changedBit=5 kabul edelim, böyle olunca karakter başına iki renk kanalı kullanmış olacağız.) 2^5=32, hiddenChar = birinci iterasyondaki değer * (32^1) + ikinci iterasyondaki değer * (32^0) şeklinde hesaplanarak gizlenen karakterin ascii değeri hesaplanmış olacak. binaryChangedBitDecimalValue değişkeni 2^5=32 değerini kolay elde etmek için kullanıldı.
            int binaryChangedBitDecimalValue = Convert.ToInt16(Math.Pow((double)2, (double)changedBit));

            for (int i = 0; i < stegoImage.Height && state != State.End_of_Text; i++)
            {
                for (int j = 0; j < stegoImage.Width && state != State.End_of_Text; j++)
                {
                    Color pixel = stegoImage.GetPixel(j, i);
                    Color tempPixel = pixel;

                    R = tempPixel.R & maskForGetLsbValue[changedBit];
                    G = tempPixel.G & maskForGetLsbValue[changedBit];
                    B = tempPixel.B & maskForGetLsbValue[changedBit];
                    //RGB renk kanallarının iterasyon geçişini takip eder
                    for (int n = 0; n < 3; n++)
                    {
                        //Yeni karakteri çözümlemeye geçildi mi? Geçildiyse,
                        if (currentIterationCount > iterationCountPerChar[changedBit])
                        {
                            hiddenChar = (char)hiddenCharValue;
                            //Gizlenen metnin son karakteri mi? Değilse,
                            if (hiddenChar != '\0')
                            {
                                hiddenText += hiddenChar;
                            }
                            //Son karakterse
                            else
                            {
                                state = State.End_of_Text;
                            }
                            //Yeni karakeri çözümleme işlemine geçildiği için aşağıdaki değerlere başlangıç değerleri atandı.
                            hiddenCharValue = 0;
                            currentIterationCount = 0;
                        }
                        //İterasyon hangi renk kanalı üzerinde işlem yapacak
                        switch (n)
                        {
                            case 0:
                                {
                                    if (state == State.Solving)
                                    {
                                        hiddenCharValue += R * Convert.ToInt32(Math.Pow((double)binaryChangedBitDecimalValue, (double)currentIterationCount++));
                                    }
                                }
                                break;
                            case 1:
                                {
                                    if (state == State.Solving)
                                    {
                                        hiddenCharValue += G * Convert.ToInt32(Math.Pow((double)binaryChangedBitDecimalValue, (double)currentIterationCount++));
                                    }

                                }
                                break;
                            case 2:
                                {
                                    if (state == State.Solving)
                                    {
                                        hiddenCharValue += B * Convert.ToInt32(Math.Pow((double)binaryChangedBitDecimalValue, (double)currentIterationCount++));
                                    }
                                }
                                break;
                        }
                    }
                }
            }

            return hiddenText;
        }
    }
}
