using System;

namespace EfsTools.Attributes
{
    public enum LineEnding
    {
        Windows,
        Linux,
        MacOs
    }

    public class LineEndingAttribute : Attribute
    {
        public LineEndingAttribute(LineEnding lineEnding, bool needLastEndLine)
        {
            LineEnding = lineEnding;
            NeedLastEndLine = needLastEndLine;
        }

        public LineEnding LineEnding
        {
            get;
        }

        public bool NeedLastEndLine
        {
            get;
        }

        public string LineEndingString
        {
            get
            {
                string result;
                switch (LineEnding)
                {
                    case LineEnding.Windows:
                        result = "\r\n";
                        break;
                    case LineEnding.Linux:
                        result = "\n";
                        break;
                    case LineEnding.MacOs:
                        result = "\r";
                        break;
                    default:
                        result = string.Empty;
                        break;
                }

                return result;
            }
        }
    }
}