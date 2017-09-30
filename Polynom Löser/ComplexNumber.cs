using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polynom_Löser
{
    class ComplexNumber
    {
        private double mReal;
        private double mImag;

        public override string ToString()
        {
            return "z = " + mReal.ToString() + " + " + mImag.ToString() + "i";
        }

        public ComplexNumber(double Real, double Imag)
        {
            mReal = Real;
            mImag = Imag;
        }

        public static ComplexNumber Parse(string Number)
        {
            //'Number muss etwa so aussehen: "5,59+56i" oder "5,59+56*i"

            Number = Number.Replace(" ", "");
            Number = Number.Replace("*", "");
            Number = Number.Replace(".", ",");

            if (Number[Number.Length - 1] == 'i')
            {
                return new ComplexNumber(double.Parse(Number.Substring(0, Number.IndexOf("+"))), double.Parse(Number.Substring(Number.IndexOf("+") + 2)));
            }
            else
                return null;
        }

        public double RealPart
        {
            get { return mReal; }
            set { mReal = value; }
        }

        public double ImaginaerPart
        {
            get { return mImag; }
            set { mImag = value; }
        }

        public double GetBetrag()
        {
            return Math.Sqrt(mReal * mReal + mImag * mImag);
        }

        public double GetArgument()
        {
            double tan = Math.Atan(mImag / mReal) * 180 / Math.PI;

            if (mReal < 0) tan += 180;
            if (tan < 0) tan = 360 + tan;

            return tan;
        }

        #region operators
        public static ComplexNumber operator +(ComplexNumber z0, ComplexNumber z1)
        {
            return new ComplexNumber(z0.mReal + z1.mReal, z0.mImag + z1.mImag);
        }

        public static ComplexNumber operator -(ComplexNumber z0, ComplexNumber z1)
        {
            return new ComplexNumber(z0.mReal - z1.mReal, z0.mImag - z1.mImag);
        }

        public static ComplexNumber operator *(ComplexNumber z0, ComplexNumber z1)
        {
            return new ComplexNumber(z0.mReal * z1.mReal - z0.mImag * z1.mImag, z0.mReal * z1.mImag + z1.mReal * z0.mImag);
        }

        public static ComplexNumber operator ^(ComplexNumber z0, int ex)
        {
            ComplexNumber ret = z0;

            for (int i = 1; i < ex; i++)
                ret *= z0;

            return ret;
        }

        public static ComplexNumber operator /(ComplexNumber z0, ComplexNumber z1)
        {
            // z0     (z0.R + z0.I) * (z1.R - z1.I)     z0.R * z1.R + z0.I * z1.R - z0.R * z1.I - z0.I * z1.I     z0.R * z1.R - z0.I * z1.I * -1     z0.I * z1.R - z0.R * z1.I
            //---- = ------------------------------- = ------------------------------------------------------- = -------------------------------- + --------------------------- * i
            // z1             z1.R² + z1.I²                                 z1.R² + z1.I²                               z1.R² + z1.I²                      z1.R² + z1.I²  

            double real = (z0.mReal * z1.mReal + z0.mImag * z1.mImag) / (z1.mReal * z1.mReal + z1.mImag * z1.mImag);
            double imag = (z0.mImag * z1.mReal - z0.mReal * z1.mImag) / (z1.mReal * z1.mReal + z1.mImag * z1.mImag);

            return new ComplexNumber(real, imag);
        }
        #endregion
    }
}
