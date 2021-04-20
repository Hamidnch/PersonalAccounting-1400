using System;
using System.Collections;
using System.Linq;
using System.Reflection;
using System.Text;

namespace PersonalAccounting.CommonLibrary.Helper
{
    public static class ExceptionExtensions
    {
        public static string ToDetailedString(this Exception exception) =>
            ToDetailedString(exception, ExceptionOptions.Default);

        public static string ToDetailedString(this Exception exception, ExceptionOptions options)
        {
            if (exception == null)
            {
                throw new ArgumentNullException(nameof(exception));
            }

            var stringBuilder = new StringBuilder();

            AppendValue(stringBuilder, "Type", exception.GetType().FullName, options);

            foreach (PropertyInfo property in exception
                .GetType()
                .GetProperties()
                .OrderByDescending(x => string.Equals(x.Name, nameof(exception.Message), StringComparison.Ordinal))
                .ThenByDescending(x => string.Equals(x.Name, nameof(exception.Source), StringComparison.Ordinal))
                .ThenBy(x => string.Equals(x.Name, nameof(exception.InnerException), StringComparison.Ordinal))
                .ThenBy(x => string.Equals(x.Name, nameof(AggregateException.InnerExceptions), StringComparison.Ordinal)))
            {
                var value = property.GetValue(exception, null);
                if (value == null && options.OmitNullProperties)
                {
                    if (options.OmitNullProperties)
                    {
                        continue;
                    }
                    else
                    {
                        value = string.Empty;
                    }
                }

                AppendValue(stringBuilder, property.Name, value, options);
            }

            return stringBuilder.ToString().TrimEnd('\r', '\n');
        }

        private static void AppendCollection(
            StringBuilder stringBuilder,
            string propertyName,
            IEnumerable collection,
            ExceptionOptions options)
        {
            stringBuilder.AppendLine($"{options.Indent}{propertyName} =");

            var innerOptions = new ExceptionOptions(options, options.CurrentIndentLevel + 1);

            var i = 0;
            foreach (var item in collection)
            {
                var innerPropertyName = $"[{i}]";

                if (item is Exception innerException)
                {
                    AppendException(
                        stringBuilder,
                        innerPropertyName,
                        innerException,
                        innerOptions);
                }
                else
                {
                    AppendValue(
                        stringBuilder,
                        innerPropertyName,
                        item,
                        innerOptions);
                }

                ++i;
            }
        }

        private static void AppendException(
            StringBuilder stringBuilder,
            string propertyName,
            Exception exception,
            ExceptionOptions options)
        {
            var innerExceptionString = ToDetailedString(
                exception,
                new ExceptionOptions(options, options.CurrentIndentLevel + 1));

            stringBuilder.AppendLine($"{options.Indent}{propertyName} =");
            stringBuilder.AppendLine(innerExceptionString);
        }

        private static string IndentString(string value, ExceptionOptions options)
        {
            return value.Replace(Environment.NewLine, Environment.NewLine + options.Indent);
        }

        private static void AppendValue(StringBuilder stringBuilder, string propertyName, object value,
            ExceptionOptions options)
        {
            switch (value)
            {
                case DictionaryEntry dictionaryEntry:
                    stringBuilder.AppendLine($"{options.Indent}{propertyName} = {dictionaryEntry.Key} : {dictionaryEntry.Value}");
                    break;
                case Exception innerException:
                    AppendException(
                        stringBuilder,
                        propertyName,
                        innerException,
                        options);
                    break;
                case IEnumerable collection when !(collection is string):
                {
                    var enumerable = collection as object[] ?? collection.Cast<object>().ToArray();
                    if (enumerable.GetEnumerator().MoveNext())
                    {
                        AppendCollection(
                            stringBuilder,
                            propertyName,
                            enumerable,
                            options);
                    }

                    break;
                }
                default:
                    stringBuilder.AppendLine($"{options.Indent}{propertyName} = {value}");
                    break;
            }
        }
    }

    public struct ExceptionOptions
    {
        public static readonly ExceptionOptions Default = new ExceptionOptions()
        {
            CurrentIndentLevel = 0,
            IndentSpaces = 4,
            OmitNullProperties = true
        };

        internal ExceptionOptions(ExceptionOptions options, int currentIndent)
        {
            this.CurrentIndentLevel = currentIndent;
            this.IndentSpaces = options.IndentSpaces;
            this.OmitNullProperties = options.OmitNullProperties;
        }

        internal string Indent => new string(' ', this.IndentSpaces * this.CurrentIndentLevel);

        internal int CurrentIndentLevel { get; set; }

        public int IndentSpaces { get; set; }

        public bool OmitNullProperties { get; set; }
    }
}
