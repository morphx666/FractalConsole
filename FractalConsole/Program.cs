using System;

namespace Fractal {
    public class Program {
        static void Main(string[] args) => Render();

        static void Render() {
            Console.Clear();
            int cw = Console.WindowWidth;
            int ch = Console.WindowHeight;
            for(int yPixel = -ch / 2; yPixel <= 1.5 * ch; yPixel++) {
                double y = yPixel / (ch / 2.0) - 1;
                for(int xPixel = 0; xPixel < cw; xPixel++) {
                    double x = xPixel / (cw / 4.0) - 2;
                    double x0 = x;
                    double y0 = y;
                    int iter = 0;
                    while(iter < 11 && x0 * x0 + y0 * y0 <= 4) {
                        double x1 = (x0 * x0) - (y0 * y0) + x;
                        double y1 = 2.0 * x0 * y0 + y;
                        x0 = x1;
                        y0 = y1;
                        iter++;
                    }
                    Console.Write(" .-:;+=xX$& "[iter]);
                }
                Console.WriteLine();
            }
        }
    }
}