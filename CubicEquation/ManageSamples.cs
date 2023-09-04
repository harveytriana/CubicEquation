using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;

namespace CubicEquation
{
    public class ManageSamples
    {
        readonly List<CubicSample> samples = new List<CubicSample>();

        public List<CubicSample> Samples => samples;

        readonly string file = @"C:\VISIONARY\GARAGE\CubicEquation\CubicEquation\Data\CubicSamples.json";

        public ManageSamples()
        {
            samples = JsonConvert.DeserializeObject<List<CubicSample>>(File.ReadAllText(file));
        }

        public void SaveSample(double a, double b, double c, double d, Complex r1, Complex r2, Complex r3)
        {
            var s = new CubicSample {
                A = a,
                B = b,
                C = c,
                D = d,
                R1 = new BasicComplex { R = r1.Real, I = r1.Imaginary },
                R2 = new BasicComplex { R = r2.Real, I = r2.Imaginary },
                R3 = new BasicComplex { R = r3.Real, I = r3.Imaginary },
            };
            if(samples.FirstOrDefault(x => x.A == a && x.B == b && x.C == c && x.D == d) == null) {
                samples.Add(s);
                File.WriteAllText(file, JsonConvert.SerializeObject(samples, Formatting.Indented));
            }
        }
    }

    public class CubicSample
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double D { get; set; }
        public BasicComplex R1 { get; set; }
        public BasicComplex R2 { get; set; }
        public BasicComplex R3 { get; set; }
        public bool Solved { get; set; } = true;
        public string Comment { get; set; }
    }
    // Summary
    // Round for fix numbers as -0.49999999999999684, where is -0.5
    public class BasicComplex
    {
        double real;
        public double R {
            get => real;
            set => real = Math.Round(value, 6);
        }

        double imag;
        public double I {
            get => imag;
            set => imag = Math.Round(value, 6);
        }
    }
}


