using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Engine
{
    public class Engine
    {
        private char[][] buffer;
        private StringBuilder sBuffer;

        private int bufferHeight;
        private int bufferWidth;
        Random random = new Random();

        public void InitializeEngine(int bWidth, int bHeight)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            this.bufferHeight = bHeight;
            this.bufferWidth = bWidth;
            this.buffer = new char[bHeight][];
            this.sBuffer = new StringBuilder();

            Console.SetBufferSize(bufferWidth, bufferHeight);
            Console.SetWindowSize(bufferWidth, bufferHeight);
            Console.ForegroundColor = ConsoleColor.Green;

            for (int i = 0; i < bHeight; i++)
            {
                buffer[i] = new char[bWidth];
            }

            GenerateRandomMap();
            Update();
        }

        public int GetBufferHeight()
        {
            return bufferHeight;
        }

        public int GetBufferWidth()
        {
            return bufferWidth;
        }

        public char[][] Buffer
        {
            get { return this.buffer; }
        }

        public void GenerateRandomMap()
        {
            char alive = '\u2588';
         
            for (int i = 0; i < bufferHeight; i++)
            {
                for (int j = 0; j < bufferWidth; j++)
                {
                    if (random.Next(0, 1000) > 900) buffer[i][j] = alive;
                }
            }

            /*
           
            buffer[18][99] = alive;
            buffer[19][100] = alive;
            buffer[20][100] = alive;
            buffer[20][99] = alive;
            buffer[20][98] = alive;
            */
        }

        public void Update()
        {

            Render();
            Thread.Sleep(250);
          
        }

        public void Render()
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            sBuffer.Clear();
            for (int i = 0; i < bufferHeight; i++)
            {
                sBuffer.Append(buffer[i]);
            }
            Console.Write(sBuffer);
        }

        public int ThisWillFail(int n)
        {
            return 1;
        }

        public string ThisWillSucceed()
        {
            return "Hello World!";
        }

        public int Calc(int a, int b)
        {
            return a * b;
        }

    }
}
