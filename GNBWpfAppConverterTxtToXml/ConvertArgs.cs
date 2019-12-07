using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GNBWpfAppConverterTxtToXml
{
    public class ConvertArgs
    {
        public string Input { get; }
        public string SaveTo { get; set; }
        public string OutputFileName { get; set; }
        public string Encoding { get; set; }
        public bool IsDefaultEncoding { get; set; }
        public bool IsDefaultSaveTo { get; set; }
        public bool IsDefaultOutputFileName { get; set; }

        public ConvertArgs(string input)
        {
            Input = input;
            ResetDefault();
        }

        public void DefaultSaveTo()
        {
            IsDefaultSaveTo = true;
            SaveTo = Input.Replace(System.IO.Path.GetFileName(Input), String.Empty);
        }

        public void DefaultOutputFileName()
        {
            IsDefaultOutputFileName = true;
            OutputFileName = System.IO.Path.GetFileNameWithoutExtension(Input);
        }

        public void DefaultEncoding()
        {
            IsDefaultEncoding = true;
            Encoding = "Windows-1257";
        }

        public void ResetDefault()
        {
            DefaultSaveTo();
            DefaultOutputFileName();
            DefaultEncoding();
        }

        public override string ToString()
        {
            return System.IO.Path.GetFileName(Input);
        }

        public override bool Equals(object obj)
        {
            if (obj is ConvertArgs)
            {
                var arg = obj as ConvertArgs;
                return arg.Input == this.Input && arg.OutputFileName == this.OutputFileName && arg.Encoding == this.Encoding && arg.SaveTo == this.SaveTo;
            }
            else
            {
                return false;
            }
        }
    }
}
