// ==============================
// Harvey Triana / Visionary-SAS
// Cardano´s method
// ==============================

//! ¡falló un caso! -1, 3, -4, 2 => R[]: 1, 1 + i, 1 - i
//
//! https://www.calculatorsoup.com/calculators/algebra/cubicequation.php

using System;
using System.Linq;
using System.Numerics;
using System.Windows.Forms;

namespace CubicEquation
{
    public partial class FormMain : Form
    {
        readonly CubicSolver _cubicSolver = new CubicSolver();

        Complex[] _roots;

        readonly ManageSamples manageSamples;

        public FormMain()
        {
            InitializeComponent();

            buttonExecute.Click += (s, e) => Execute();
            buttonValidate.Click += (s, e) => ValidateResult();

            // samples
            // SampleData(-1, -6, 11, 72);  // All real
            // SampleData(1, -2, -1, 2);    // All real
            // SampleData(25, 15, -9, 1);   // some article
            // SampleData(2, 5, 4, 1);      // case 1, t = 0
            // SampleData(1, 2, -1, -2);    // case 3, t < 0
            // SampleData(1, 2, 1, 2);      // case 2, t > 0
            // SampleData(1, 2, 3, 4);

            manageSamples = new ManageSamples();

            if(manageSamples.Samples.Any()) {
                var s = manageSamples.Samples.Last();
                SampleData(s.A, s.B, s.C, s.D);
            }
            else {
                SampleData(1, 2, 3, 4);
            }
        }

        private void Execute()
        {
            X1 = "";
            X2 = "";
            X3 = "";
            // 
            _roots = _cubicSolver.Solve(A, B, C, D);
            if(_roots != null) {
                X1 = ComplexString(_roots[0]);
                X2 = ComplexString(_roots[1]);
                X3 = ComplexString(_roots[2]);
                //
                manageSamples.SaveSample(A, B, C, D, _roots[0], _roots[1], _roots[2]);
            }
            else {
                X1 = "null";
                X2 = "null";
                X3 = "null";
            }
            buttonValidate.Enabled = string.IsNullOrEmpty(X1) == false;
        }

        private void SampleData(double a, double b, double c, double d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }

        double A {
            get => double.Parse(textBoxA.Text);
            set => textBoxA.Text = value.ToString();
        }

        double B {
            get => double.Parse(textBoxB.Text);
            set => textBoxB.Text = value.ToString();
        }

        double C {
            get => double.Parse(textBoxC.Text);
            set => textBoxC.Text = value.ToString();
        }

        double D {
            get => double.Parse(textBoxD.Text);
            set => textBoxD.Text = value.ToString();
        }

        string X1 {
            get => textBoxX1.Text;
            set => textBoxX1.Text = value;
        }
        string X2 {
            get => textBoxX2.Text;
            set => textBoxX2.Text = value;
        }
        string X3 {
            get => textBoxX3.Text;
            set => textBoxX3.Text = value;
        }

        string ComplexString(Complex z, int decimals = 4)
        {
            string s = $"N{decimals}";
            if(z.Imaginary == 0) {
                return z.Real.ToString(s);
            }
            if(z.Real == 0) {
                return z.Imaginary.ToString(s) + " i";
            }
            return (z.Real == 0 ? "" : z.Real.ToString(s)) +
                   (z.Imaginary >= 0 ? " + " : " - ") + Math.Abs(z.Imaginary).ToString(s) + " i";
        }

        void ValidateResult()
        {
            var s = string.Empty;
            var a = A;
            var b = B;
            var c = C;
            var d = D;
            s += "Is ƒ(x) equals to zero?";
            s += $"\nƒ({X1}) = {Test(a, b, c, d, _roots[0])}";
            s += $"\nƒ({X2}) = {Test(a, b, c, d, _roots[1])}";
            s += $"\nƒ({X3}) = {Test(a, b, c, d, _roots[2])}";
            MessageBox.Show(s);
        }

        /// <summary>
        /// Returs cubic funtion evaluate for number
        /// </summary>
        /// <returns></returns>
        string Test(double a, double b, double c, double d, Complex root)
        {
            if(root.Imaginary == 0) {// real, by sample
                var r = a * Math.Pow(root.Real, 3) + b * Math.Pow(root.Real, 2) + c * root.Real + d;
                if(NearToZero(r)) {
                    return "0";
                }
                return (a * Math.Pow(root.Real, 3) + b * Math.Pow(root.Real, 2) + c * root.Real + d).ToString("N6");
            }
            var comlexResult = a * Complex.Pow(root, 3) + b * Complex.Pow(root, 2) + c * root + d;
            var real = comlexResult.Real;
            if(NearToZero(comlexResult.Real)) {
                real = 0;
            }
            var imag = comlexResult.Imaginary;
            if(NearToZero(imag)) {
                imag = 0;
            }
            if(real == 0 && imag == 0) {
                return "0"; // 0 + 0i
            }
            return comlexResult.ToString("N6").Replace("(", "").Replace(")", "");
        }

        bool NearToZero(double number)
        {
            if(number == 0) {
                return true;
            }
            if(Math.Truncate(number) == number) {
                return false;
            }
            return number.ToString("0.00000000").EndsWith("00000000");
        }
    }
}
