using MatrixSzenvedes.AbsClass;
using MatrixSzenvedes.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixSzenvedes.MyMatrix
{
    public class LakatosMatrix : AbsMatrix, IMatrixOperations
    {
        public void Add(AbsMatrix addMatrix)
        {
            if (this.ColumnCount != addMatrix.ColumnCount || this.RowCount != addMatrix.RowCount)
            {
                Console.WriteLine("Matrices must have the same dimensions!");
                return;
            }

            for (int rowIndex = 0; rowIndex < RowCount; rowIndex++)
            {
                for (int colIndex = 0; colIndex < ColumnCount; colIndex++)
                {
                    this[rowIndex, colIndex] += addMatrix[rowIndex, colIndex];
                }
            }
        }

        public bool Equals(AbsMatrix other)
        {
            if (this.ColumnCount != other.ColumnCount || this.RowCount != other.RowCount)
            {
                return false;
            }

            for (int rowIndex = 0; rowIndex < RowCount; rowIndex++)
            {
                for (int colIndex = 0; colIndex < ColumnCount; colIndex++)
                {
                    if (this[rowIndex, colIndex] != other[rowIndex, colIndex]) 
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public void Fill(double value)
        {
            for (int rowIndex = 0; rowIndex < RowCount; rowIndex++)
            {
                for (int colIndex = 0; colIndex < ColumnCount; colIndex++)
                {
                    this[rowIndex, colIndex] = value;
                }
            }
        }

        public void FillRandomFloat(double start, double end)
        {
            Random rnd = new Random();

            for (int rowIndex = 0; rowIndex < RowCount; rowIndex++)
            {
                for (int colIndex = 0; colIndex < ColumnCount; colIndex++)
                {
                    this[rowIndex, colIndex] = (float)(start + (rnd.NextDouble() * (end - start)));
                }
            }
        }

        public void FillRandomInt(int start, int end)
        {
            Random rnd = new Random();

            for (int rowIndex = 0; rowIndex < RowCount; rowIndex++)
            {
                for (int colIndex = 0; colIndex < ColumnCount; colIndex++)
                {
                    this[rowIndex, colIndex] = rnd.NextInt64(start, end);
                }
            }
        }

        public void RotateToDown()
        {
            throw new NotImplementedException();
        }

        public void RotateToLeft()
        {
            for (int rowIndex = 0; rowIndex < RowCount; rowIndex++)
            {
                double temp = this[rowIndex, 0];
                for (int colIndex = 0; colIndex < ColumnCount; colIndex++)
                {
                    this[rowIndex, colIndex - 1] = this[rowIndex, colIndex];
                }
                this[rowIndex, RowCount - 1] = temp;
            }
        }

        public void RotateToTop()
        {
            throw new NotImplementedException();
        }

        public void RotatetToRight()
        {
            throw new NotImplementedException();
        }

        public void Sub(AbsMatrix subMatrix)
        {
            throw new NotImplementedException();
        }
    }
}
