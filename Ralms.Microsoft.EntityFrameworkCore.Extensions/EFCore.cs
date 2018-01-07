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
                  var newArgs = args.ToList();
                  newArgs[0] = new SqlFragmentExpression(((ConstantExpression)newArgs.First()).Value.ToString());
                  return new SqlFunctionExpression(
                      "DATEDIFF",
                      typeof(int),
                      newArgs);
              });
        }

        public static int? DateDiff(DatePart datePart, DateTime? start, DateTime? end)
        {
            switch (datePart)
            {
                case DatePart.day:
                    return EFFunctions.DateDiffDay(start, end);
                case DatePart.month:
                    return EFFunctions.DateDiffMonth(start, end);
                case DatePart.year:
                    return EFFunctions.DateDiffYear(start, end);
                case DatePart.hour:
                    return EFFunctions.DateDiffHour(start, end);
                case DatePart.minute:
                    return EFFunctions.DateDiffMinute(start, end);
                case DatePart.second:
                    return EFFunctions.DateDiffSecond(start, end);
                case DatePart.millisecond:
                    return EFFunctions.DateDiffMillisecond(start, end);
                case DatePart.microsecond:
                    return EFFunctions.DateDiffMicrosecond(start, end);
                case DatePart.nanosecond:
                    return EFFunctions.DateDiffNanosecond(start, end);
                default:
                    throw new Exception("Please enter a valid DATEPART!");
            }
        }
    }
}
