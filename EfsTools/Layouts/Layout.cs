using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfsTools.Layouts
{
    internal class Layout
    {
        public Layout(IEnumerable<ILayoutRule> layoutRules)
        {
            _layoutRules = layoutRules;
        }
        
        private readonly IEnumerable<ILayoutRule> _layoutRules;

        public string Render()
        {
            var sb = new StringBuilder();
            foreach (var layoutRule in _layoutRules)
            {
                sb.Append(layoutRule.Render());
            }
            return sb.ToString();
        }

        public static Layout Parse(string text)
        {
            var rules = ParseRules(text);
            var result = new Layout(rules);
            return result;
        }

        private static IEnumerable<ILayoutRule> ParseRules(string text)
        {
            var result = new List<ILayoutRule>();
            int startIndex = 0;
            int endIndex = 0;
            var length = text.Length;
            while (startIndex < length)
            {
                startIndex = text.IndexOf(RuleStartMarker1, endIndex);
                if (startIndex < 0)
                {
                    startIndex = endIndex;
                    endIndex = length;
                }
                else
                {
                    if (startIndex < (text.Length - 1) && text[startIndex + 1] == RuleStartMarker2)
                    {
                        if (startIndex > endIndex)
                        {
                            var subText = text.Substring(endIndex, startIndex - endIndex);
                            var rule = CreateTextRule(subText);
                            result.Add(rule);
                        }

                        endIndex = text.IndexOf(RuleEndMarker, startIndex);
                        if (endIndex < 0)
                        {
                            endIndex = length;
                        }
                        else
                        {
                            ++endIndex;
                            var subText = text.Substring(startIndex, endIndex - startIndex);
                            startIndex = endIndex;
                            var rule = CreateRule(subText);
                            result.Add(rule);
                        }
                    }
                    else
                    {
                        if (startIndex > endIndex)
                        {
                            var subText = text.Substring(endIndex, startIndex - endIndex);
                            var rule = CreateTextRule(subText);
                            result.Add(rule);
                        }
                        if (endIndex > startIndex)
                        {
                            var subText = text.Substring(startIndex, endIndex - startIndex);
                            var rule = CreateTextRule(subText);
                            result.Add(rule);
                        }
                        endIndex = startIndex + 1;
                        continue;
                    }
                }
                if (startIndex < endIndex)
                {
                    var subText = text.Substring(startIndex, endIndex - startIndex);
                    var rule = CreateTextRule(subText);
                    result.Add(rule);
                }
                else if (startIndex > endIndex)
                {
                    var subText = text.Substring(endIndex, startIndex - endIndex);
                    var rule = CreateTextRule(subText);
                    result.Add(rule);
                }
            }
            return result;
        }

        private static ILayoutRule CreateTextRule(string text)
        {
            var rule = new TextLayoutRule(text);
            return rule;
        }

        private static ILayoutRule CreateRule(string text)
        {
            if (text.Length > 2 && text[0] == RuleStartMarker1 && text[1] == RuleStartMarker2)
            {
                var index = text.IndexOf(RuleParameterSeparator);
                var rule = string.Empty;
                var parameters = string.Empty; 
                if (index < 0)
                {
                    rule = text.Substring(2, text.Length - 3);
                }
                else
                {
                    rule = text.Substring(2, index - 2);
                    parameters = text.Substring(index + 1, text.Length - index - 2);
                }
                var result =  CreateRule(rule, parameters);
                if (result != null)
                {
                    return result;
                }
            }
            return CreateTextRule(text);
        }

        private static Dictionary<string, string> ParseParameters(string text)
        {
            var result = new Dictionary<string, string>();
            var parts = text.Split(RuleParameterSeparator);
            foreach (var part in parts)
            {
                var keyVal = part.Split('=');
                if (keyVal.Length > 0)
                {
                    var key = keyVal[0];
                    var val = (keyVal.Length > 1) ? keyVal[1] : String.Empty;
                    result.Add(key, val);
                }
            }
            return result;
        }

        private static ILayoutRule CreateRule(string stringRule, string stringParameters)
        {
            ILayoutRule rule = null;
            Dictionary<string, string> parameters = null;
            switch (stringRule)
            {
            case "date":
                parameters = ParseParameters(stringParameters);
                rule = new DateTimeLayoutRule(parameters);
                break;
            case "time":
                parameters = ParseParameters(stringParameters);
                parameters["format"] = "HH:mm:ss.mmmm";
                rule = new DateTimeLayoutRule(parameters);
                break;
            case "longdate":
                parameters = ParseParameters(stringParameters);
                parameters["format"] = "yyyy-MM-dd HH:mm:ss.ffff";
                rule = new DateTimeLayoutRule(parameters);
                break;
            case "shortdate":
                parameters = ParseParameters(stringParameters);
                parameters["format"] = "yyyy-MM-dd";
                rule = new DateTimeLayoutRule(parameters);
                break;
            }
            return rule;
        }

        private static readonly char RuleStartMarker1 = '$';
        private static readonly char RuleStartMarker2 = '{';
        private static readonly char RuleEndMarker = '}';
        private static readonly char RuleParameterSeparator = ':';
    }
}
