﻿// ================================================
// Ing. Harvey Triana / Visionary-SAS
// Cubic equation solver by Cardano´s method
// ================================================
using System;
using System.Numerics;

namespace CubicEquation
{
    public class CubicSolver
    {
        const double CLOSE_TO_ZERO = 1.0E-8, THIRD = 1.0 / 3.0;

        public Complex[] Solve(double a, double b, double c, double d)
        {
            if(a == 0) {
                return null;
            }
            // constants
            double j = b / a;
            double k = c / a;
            double l = d / a;
            double p = -(j * j / 3.0) + k;
            double q = (2.0 / 27.0 * j * j * j) - (j * k / 3.0) + l;
            double t = q * q / 4.0 + p * p * p / 27.0;

            // force to zero if it is very close to zero
            if(CloseToZero(t)) {
                t = 0;
            }
            if(CloseToZero(q)) {
                q = 0;
            }

            double r1 = 0, r2 = 0, r3 = 0, i1 = 0, i2 = 0, i3 = 0, i;

            // There are three cases according to the value of t
            if(t > 0) {// one real, two complexs
                var q1 = CubeRoot(-q / 2.0 + Math.Sqrt(t));
                var q2 = CubeRoot(-q / 2.0 - Math.Sqrt(t));
                // real root
                r1 = q1 + q2;
                // two complex roots
                r2 = -r1 / 2.0;
                r3 = r2; // conjugated
                // imaginary
                i = Math.Sqrt(3.0) / 2.0 * (q1 - q2);
                i1 = 0;
                i2 = i;
                i3 = -i;
            }
            if(t == 0) {// three real roots, at least two equal
                r1 = 2.0 * CubeRoot(-q / 2.0);
                r2 = -r1 / 2.0 + Math.Sqrt(Math.Pow(r1 / 2.0, 2.0) + q / r1);
                r3 = -r1 / 2.0 - Math.Sqrt(Math.Pow(r1 / 2.0, 2.0) + q / r1);
            }
            if(t < 0) {// all are real roots
                var x = -q / 2.0;
                var y = Math.Sqrt(-t); // make t positive
                var angle = Math.Atan(y / x);
                if(q > 0) {// if q > 0 the angle becomes 2 * PI - angle
                    angle = Math.PI - angle;
                }
                r1 = 2.0 * Math.Sqrt(-p / 3.0) * Math.Cos(angle / 3.0);
                r2 = 2.0 * Math.Sqrt(-p / 3.0) * Math.Cos((angle + 2.0 * Math.PI) / 3.0);
                r3 = 2.0 * Math.Sqrt(-p / 3.0) * Math.Cos((angle + 4.0 * Math.PI) / 3.0);
            }
            // output 
            var result = new Complex[3];
            result[0] = new Complex(r1 - j / 3.0, i1);
            result[1] = new Complex(r2 - j / 3.0, i2);
            result[2] = new Complex(r3 - j / 3.0, i3);
            return result;
        }

        // Summary:
        // n^(1/3) - work around a negative double raised to (1/3)
        public double CubeRoot(double n) => Math.Pow(Math.Abs(n), THIRD) * Math.Sign(n);
        // first approach
        //double CubeRoot(double number) => number < 0 ? -Math.Pow(-number, THIRD) : Math.Pow(number, THIRD);

        // Summary
        // In computational terms, it validates if a number is very close to zero.
        bool CloseToZero(double value) => Math.Abs(value) <= CLOSE_TO_ZERO;
    }
}
