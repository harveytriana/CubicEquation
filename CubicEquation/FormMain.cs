// ==============================
// Harvey Triana / Visionary-SAS
// Cardano´s method
// ==============================
using System;
using System.Numerics;
using System.Windows.Forms;

namespace CubicEquation
{
    public partial class FormMain : Form
    {
        readonly CubicSolver _cubicSolver = new CubicSolver();

        Complex[] _roots;

        public FormMain()
        {
            InitializeComponent();

            buttonExecute.Click += (s, e) => Execute();
            buttonValidate.Click += (s, e) => ValidateResult();

            // samples
            // SampleInput(-1, -6, 11, 72);  // All real
            // SampleInput(1, -2, -1, 2);    // All real
            // SampleInput(25, 15, -9, 1);   // some article
            // SampleInput(2, 5, 4, 1);      // case 1, t = 0
            // SampleInput(1, 2, -1, -2);    // case 3, t < 0
            // SampleInput(1, 2, 1, 2);      // case 2, t > 0
            SampleInput(1, 2, 3, 4);
        }

        private void Execute()
        {
            _roots = _cubicSolver.Solve(A, B, C, D);
            if (_roots != null) {
                X1 = ComplexString(_roots[0]);
                X2 = ComplexString(_roots[1]);
                X3 = ComplexString(_roots[2]);
            } else {
                X1 = "null";
                X2 = "null";
                X3 = "null";
            }
        }

        private void SampleInput(double a, double b, double c, double d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }

        private bool ContainsNumber(string text)
        {
            if (!string.IsNullOrEmpty(text)) {
                foreach (var n in new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "9" }) {
                    if (text.Contains(n)) {
                        return true;
                    }
                }
            }
            return false;
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
            if (z.Imaginary == 0) {
                return z.Real.ToString(s);
            }
            if (z.Real == 0) {
                return z.Imaginary.ToString(s) + "i";
            }
            return (z.Real == 0 ? "" : z.Real.ToString(s)) +
                   (z.Imaginary >= 0 ? " + " : " - ") + Math.Abs(z.Imaginary).ToString(s) + "i";
        }

        void ValidateResult()
        {
            var s = string.Empty;
            if (ContainsNumber(X1) && ContainsNumber(X2) && ContainsNumber(X3)) {
                var a = A;
                var b = B;
                var c = C;
                var d = D;
                s += "Validating ƒ(x) = 0";
                s += $"\nƒ({X1}) = {F(a, b, c, d, _roots[0])}";
                s += $"\nƒ({X2}) = {F(a, b, c, d, _roots[1])}";
                s += $"\nƒ({X3}) = {F(a, b, c, d, _roots[2])}";
            } else {
                s = "Missing result";
            }
            MessageBox.Show(s);
        }

        string F(double a, double b, double c, double d, Complex z)
        {
            if (z.Imaginary == 0) {// real, by sample
                return (a * Math.Pow(z.Real, 3) + b * Math.Pow(z.Real, 2) + c * z.Real + d).ToString("N6") + "...";
            }
            return (a * Complex.Pow(z, 3) + b * Complex.Pow(z, 2) + c * z + d).ToString("N6") + "...";
        }
    }
}
