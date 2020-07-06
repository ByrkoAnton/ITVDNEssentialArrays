using System;
using System.Collections.Generic;
using System.Text;

namespace arrays03
{
    class Matrix
    {
        public int[,] _Matr;
        private int _lines;
        private int _col;

        public Matrix(int lines, int col, bool feelMatrRnd)
        {
            _lines = lines;
            _col = col;
            _Matr = new int[lines, col];

            if (feelMatrRnd)
                this.FeelMatrRnd();

        }

        private void FeelMatrRnd()
        {
            Random random = new Random();
            for (int i = 0; i < _lines; i++)
            {
                for (int j = 0; j < _col; j++)
                {
                    _Matr[i, j] = random.Next(-110, 200);
                }
            }
        }

        public void ShowMatr()
        {
            for (int i = 0; i < _lines; i++)
            {
                for (int j = 0; j < _col; j++)
                {
                    Console.Write(_Matr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public Matrix ChangeSise(int lines, int col)
        {
            Matrix matrix = new Matrix(lines, col, false);

            int [] arr =new int[lines*col];
            int idx = 0;

            for (int i = 0; i < Math.Min(lines,_lines); i++)
            {
                for (int j = 0; j < Math.Min(col, _col); j++)
                {
                    arr[idx++] = _Matr[i, j];
                }
            }

            idx = 0;

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix._Matr[i, j]= arr[idx++];
                }
            }

            

            return matrix;
        }

    }
}
