using System;
using System.Collections.Generic;
using CommandLine;
using CommandLine.Text;
using EfsTools.Resourses;

namespace EfsTools
{
    internal class CommandLineOptionsLocalization : SentenceBuilder
    {
        public override Func<string> RequiredWord
        {
            get { return () => $"{Strings.Required}."; }
        }

        public override Func<string> ErrorsHeadingText
        {
            get { return () => $"{Strings.Errors}:"; }
        }

        public override Func<string> UsageHeadingText
        {
            get { return () => $"{Strings.Usage}:"; }
        }

        public override Func<bool, string> HelpCommandText
        {
            get
            {
                return isOption => isOption
                    ? Strings.DisplayThisHelpScreen
                    : Strings.DisplayMoreInformationOnASpecificCommand;
            }
        }

        public override Func<bool, string> VersionCommandText
        {
            get { return _ => Strings.DisplayVersionInformation; }
        }

        public override Func<Error, string> FormatError
        {
            get
            {
                return error =>
                {
                    switch (error.Tag)
                    {
                        case ErrorType.BadFormatTokenError:
                            return string.Format(Strings.BadFormatTokenErrorFormat,
                                ((BadFormatTokenError) error).Token);
                        case ErrorType.MissingValueOptionError:
                            return string.Format(Strings.MissingValueOptionErrorFormat,
                                ((MissingValueOptionError) error).NameInfo.NameText);
                        case ErrorType.UnknownOptionError:
                            return string.Format(Strings.UnknownOptionErrorFormat,
                                ((UnknownOptionError) error).Token);
                        case ErrorType.MissingRequiredOptionError:
                            var errMisssing = (MissingRequiredOptionError) error;
                            return errMisssing.NameInfo.Equals(NameInfo.EmptyName)
                                ? Strings.MissingRequiredOptionErrorFormat1
                                : string.Format(Strings.MissingRequiredOptionErrorFormat2,
                                    errMisssing.NameInfo.NameText);
                        case ErrorType.BadFormatConversionError:
                            var badFormat = (BadFormatConversionError) error;
                            return badFormat.NameInfo.Equals(NameInfo.EmptyName)
                                ? Strings.BadFormatConversionErrorFormat1
                                : string.Format(Strings.BadFormatConversionErrorFormat2, badFormat.NameInfo.NameText);
                        case ErrorType.SequenceOutOfRangeError:
                            var seqOutRange = (SequenceOutOfRangeError) error;
                            return seqOutRange.NameInfo.Equals(NameInfo.EmptyName)
                                ? Strings.SequenceOutOfRangeErrorFormat1
                                : string.Format(Strings.SequenceOutOfRangeErrorFormat2, seqOutRange.NameInfo.NameText);
                        case ErrorType.BadVerbSelectedError:
                            return string.Format(Strings.BadVerbSelectedErrorFormat,
                                ((BadVerbSelectedError) error).Token);
                        case ErrorType.NoVerbSelectedError:
                            return Strings.NoVerbSelectedErrorFormat;
                        case ErrorType.RepeatedOptionError:
                            return string.Format(Strings.RepeatedOptionErrorFormat,
                                ((RepeatedOptionError) error).NameInfo.NameText);
                    }

                    throw new InvalidOperationException();
                };
            }
        }

        public override Func<IEnumerable<MutuallyExclusiveSetError>, string> FormatMutuallyExclusiveSetErrors
        {
            get
            {
                return errors =>
                {
                    /*var bySet = from e in errors
                                group e by e.SetName into g
                                select new { SetName = g.Key, Errors = g.ToList() };
                    var msgs = bySet.Select(
                        set =>
                        {
                            var names = string.Join(
                                string.Empty,
                                (from e in set.Errors select "'".JoinTo(e.NameInfo.NameText, "', ")).ToArray());
                            var namesCount = set.Errors.Count();

                            var incompat = string.Join(
                                string.Empty,
                                (from x in
                                     (from s in bySet where !s.SetName.Equals(set.SetName) from e in s.Errors select e)
                                    .Distinct()
                                 select "'".JoinTo(x.NameInfo.NameText, "', ")).ToArray());

                            return
                                new StringBuilder("Option")
                                        .AppendWhen(namesCount > 1, "s")
                                        .Append(": ")
                                        .Append(names.Substring(0, names.Length - 2))
                                        .Append(' ')
                                        .AppendIf(namesCount > 1, "are", "is")
                                        .Append(" not compatible with: ")
                                        .Append(incompat.Substring(0, incompat.Length - 2))
                                        .Append('.')
                                    .ToString();
                        }).ToArray();
                    return string.Join(Environment.NewLine, msgs);*/
                    return string.Empty;
                };
            }
        }
    }
}