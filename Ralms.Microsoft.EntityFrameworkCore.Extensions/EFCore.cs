using Microsoft.EntityFrameworkCore.Query.Expressions;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Microsoft.EntityFrameworkCore
{
    public static class EFCore
    {
        public static void CreateFunctionDateDiff(this ModelBuilder builder)
        {
            builder.HasDbFunction(typeof(EFCore)
              .GetMethod(nameof(EFCore.DateDiff)))
              .HasTranslation(args =>
              {
                  var arguments = args.ToList();
                  arguments[0] = new SqlFragmentExpression(((ConstantExpression)arguments.First()).Value.ToString());
                  return new SqlFunctionExpression(
                      "DATEDIFF",
                      typeof(int),
                      arguments);
              });
        }

        public static int? DateDiff(DatePart datePart, object start, object end)
        {
            var startDate = start.GetType() == typeof(DateTime)
                ? (DateTime)start
                : (DateTimeOffset)start;

            var endDate = end.GetType() == typeof(DateTime)
                ? (DateTime)end
                : (DateTimeOffset)end;

            switch (datePart)
            {
                case DatePart.day:
                    return EFFunctions.DateDiffDay(startDate, endDate);
                case DatePart.month:
                    return EFFunctions.DateDiffMonth(startDate, endDate);
                case DatePart.year:
                    return EFFunctions.DateDiffYear(startDate, endDate);
                case DatePart.hour:
                    return EFFunctions.DateDiffHour(startDate, endDate);
                case DatePart.minute:
                    return EFFunctions.DateDiffMinute(startDate, endDate);
                case DatePart.second:
                    return EFFunctions.DateDiffSecond(startDate, endDate);
                case DatePart.millisecond:
                    return EFFunctions.DateDiffMillisecond(startDate, endDate);
                case DatePart.microsecond:
                    return EFFunctions.DateDiffMicrosecond(startDate, endDate);
                case DatePart.nanosecond:
                    return EFFunctions.DateDiffNanosecond(startDate, endDate);
                default:
                    throw new Exception("Please enter a valid DATEPART!");
            }
        }
    }
}
