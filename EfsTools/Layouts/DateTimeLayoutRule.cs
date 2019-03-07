using System;
using System.Collections.Generic;

namespace EfsTools.Layouts
{
    internal class DateTimeLayoutRule : ILayoutRuleWithParameters
    {
        public DateTimeLayoutRule(Dictionary<string, string> parameters)
        {
            Parameters = parameters;
            _useUtc = false;
            _format = "yyyy-MM-dd HH:mm:ss";
            if (parameters != null)
            {
                if (parameters.TryGetValue("universalTime", out string val))
                {
                    val = val.ToLowerInvariant();
                    _useUtc = (val == "true");
                }
                if (parameters.TryGetValue("format", out string val2))
                {
                    _format = val2;
                }
            }
        }

        public Dictionary<string, string> Parameters { get; private set; }

        private readonly bool _useUtc;
        private readonly string _format;
        
        public string Render()
        {
            var now = _useUtc ? DateTime.UtcNow : DateTime.Now;
            if (string.IsNullOrEmpty(_format))
            {
                return now.ToLongDateString();
            }

            var str = now.ToString(_format);
            return str;
        }
    }
}
