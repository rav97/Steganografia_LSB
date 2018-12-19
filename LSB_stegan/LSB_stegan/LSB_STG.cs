using System;
using System.Drawing;

namespace LSB_stegan
{
    public class LSB_STG
    {
        public enum State
        {
            Hiding,
            Filling_With_Zeros
        };

        public Bitmap embedText(string text, Bitmap bmp, int bit)
        {

            State state = State.Hiding;

            int charIndex = 0;
            int charValue = 0;
            long pixelElementIndex = 0;
            int zeros = 0;
            int R = 0, G = 0, B = 0;
            for (int i = 0; i < bmp.Height; i++)
            {

                for (int j = 0; j < bmp.Width; j++)
                {

                    Color pixel = bmp.GetPixel(j, i);

                    R = clearBit(pixel.R, bit);
                    G = clearBit(pixel.G, bit);
                    B = clearBit(pixel.B, bit);

                    for (int n = 0; n < 3; n++)
                    {
                        if (pixelElementIndex % 8 == 0)
                        {
                            if (state == State.Filling_With_Zeros && zeros == 8)
                            {
                                if ((pixelElementIndex - 1) % 3 < 2)
                                {
                                    bmp.SetPixel(j, i, Color.FromArgb(R, G, B));
                                }
                                return bmp;
                            }

                            if (charIndex >= text.Length)
                            {
                                state = State.Filling_With_Zeros;
                            }
                            else
                            {
                                charValue = text[charIndex++];
                            }
                        }

                        switch (pixelElementIndex % 3)
                        {
                            case 0:
                                {
                                    if (state == State.Hiding)
                                    {

                                        if (charValue % 2 == 1)
                                            R = setBit(R, bit);

                                        charValue /= 2;
                                    }
                                }
                                break;
                            case 1:
                                {
                                    if (state == State.Hiding)
                                    {
                                        if (charValue % 2 == 1)
                                            G = setBit(G, bit);

                                        charValue /= 2;
                                    }
                                }
                                break;
                            case 2:
                                {
                                    if (state == State.Hiding)
                                    {
                                        if (charValue % 2 == 1)
                                            B = setBit(B, bit);

                                        charValue /= 2;
                                    }

                                    bmp.SetPixel(j, i, Color.FromArgb(R, G, B));
                                }
                                break;
                        }

                        pixelElementIndex++;

                        if (state == State.Filling_With_Zeros)
                        {
                            zeros++;
                        }
                    }
                }
            }

            return bmp;
        }

        public string extractText(Bitmap bmp, int bit)
        {
            int colorUnitIndex = 0;
            int charValue = 0;

            string extractedText = String.Empty;


            for (int i = 0; i < bmp.Height; i++)
            {

                for (int j = 0; j < bmp.Width; j++)
                {
                    Color pixel = bmp.GetPixel(j, i);


                    for (int n = 0; n < 3; n++)
                    {
                        switch (colorUnitIndex % 3)
                        {
                            case 0:
                                {

                                    if (getBit(pixel.R, bit))
                                        charValue = charValue * 2 + 1;
                                    else
                                        charValue = charValue * 2 + 0;
                                }
                                break;
                            case 1:
                                {
                                    if (getBit(pixel.G, bit))
                                        charValue = charValue * 2 + 1;
                                    else
                                        charValue = charValue * 2 + 0;
                                }
                                break;
                            case 2:
                                {
                                    if (getBit(pixel.B, bit))
                                        charValue = charValue * 2 + 1;
                                    else
                                        charValue = charValue * 2 + 0;
                                }
                                break;
                        }

                        colorUnitIndex++;

                        if (colorUnitIndex % 8 == 0)
                        {

                            charValue = reverseBits(charValue);


                            if (charValue == 0)
                            {
                                return extractedText;
                            }


                            char c = (char)charValue;

                            extractedText += c.ToString();
                        }
                    }
                }
            }

            return extractedText;
        }
        public int reverseBits(int n)
        {
            int result = 0;
            for (int i = 0; i < 8; i++)
            {
                result = result * 2 + n % 2;
                n /= 2;
            }
            return result;
        }
        public int clearBit(int channel, int which)
        {
            channel &= ~(1 << (8 - which));
            return channel;
        }
        public int setBit(int val, int which)
        {
            val |= 1 << (8 - which);
            return val;
        }
        public bool getBit(int b, int bitNumber)
        {
            return (b & (1 << (8 - bitNumber))) != 0;
        }
    }
}
