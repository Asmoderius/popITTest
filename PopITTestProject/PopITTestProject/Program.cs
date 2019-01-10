using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine;
using gameEngine = Engine;

namespace PopITTestProject
{
    class Program
    {
        private static gameEngine.Engine e;
        private static Random random = new Random();
        static void Main(string[] args)
        {
            e = new gameEngine.Engine();
            e.InitializeEngine(120, 40);
            Run();
        }

        static void Run()
        {
            char alive = '\u2588'; 
            while (true)
            {
                e.Update();

                for (int i = 0; i < e.GetBufferHeight(); i++)
                {
                    for (int j = 0; j < e.GetBufferWidth(); j++)
                    {

                        if (i - 1 > 0 && j - 1 > 0 && i + 1 < e.GetBufferHeight() && j + 1 < e.GetBufferWidth())
                        {
                            int countNeighbours = 0;
                            if (e.Buffer[i - 1][j - 1] == alive || e.Buffer[i - 1][j - 1] == 'x') countNeighbours++;
                            if (e.Buffer[i - 1][j] == alive || e.Buffer[i - 1][j] == 'x') countNeighbours++;
                            if (e.Buffer[i - 1][j + 1] == alive || e.Buffer[i - 1][j + 1] == 'x') countNeighbours++;
                            if (e.Buffer[i][j - 1] == alive || e.Buffer[i][j - 1] == 'x') countNeighbours++;
                            if (e.Buffer[i][j + 1] == alive || e.Buffer[i][j + 1] == 'x') countNeighbours++;
                            if (e.Buffer[i + 1][j - 1] == alive || e.Buffer[i + 1][j - 1] == 'x') countNeighbours++;
                            if (e.Buffer[i + 1][j] == alive || e.Buffer[i + 1][j] == 'x') countNeighbours++;
                            if (e.Buffer[i + 1][j + 1] == alive || e.Buffer[i + 1][j + 1] == 'x') countNeighbours++;

                            if (e.Buffer[i][j] == alive)
                            {
                                if (countNeighbours > 3) e.Buffer[i][j] = 'x';
                                if (countNeighbours < 2) e.Buffer[i][j] = 'x';
                            }
                            else
                            {
                                if (countNeighbours == 3) e.Buffer[i][j] = 'y';
                            }
                        }

                    }
                }

                for (int i = 0; i < e.GetBufferHeight(); i++)
                {
                    for (int j = 0; j < e.GetBufferWidth(); j++)
                    {

                        if (e.Buffer[i][j] == 'x') e.Buffer[i][j] = ' ';
                        if (e.Buffer[i][j] == 'y') e.Buffer[i][j] = alive;

                    }
                }
            }
        }
    }
}
