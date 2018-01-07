// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Microsoft.EntityFrameworkCore
{
    public static class EFFunctions
    {
        /// <summary>
        ///    Counts the number of year boundaries crossed between the startDate and endDate.
        ///    Corresponds to SQL Server's DATEDIFF(YEAR,startDate,endDate).
        /// </summary>
        /// <param name="_">The DbFunctions instance.</param>
        /// <param name="startDate">Starting date for the calculation.</param>
        /// <param name="endDate">Ending date for the calculation.</param>
        /// <returns>Number of year boundaries crossed between the dates.</returns>
        public static int DateDiffYear(
            DateTime startDate,
            DateTime endDate)
            => endDate.Year - startDate.Year;


        /// <summary>
        ///    Counts the number of year boundaries crossed between the startDate and endDate.
        ///    Corresponds to SQL Server's DATEDIFF(YEAR,startDate,endDate).
        /// </summary>
        /// <param name="_">The DbFunctions instance.</param>
        /// <param name="startDate">Starting date for the calculation.</param>
        /// <param name="endDate">Ending date for the calculation.</param>
        /// <returns>Number of year boundaries crossed between the dates.</returns>
        public static int? DateDiffYear(
            DateTime? startDate,
            DateTime? endDate)
            => (startDate.HasValue && endDate.HasValue)
                ? (int?)DateDiffYear(startDate.Value, endDate.Value)
                : null;

        /// <summary>
        ///    Counts the number of year boundaries crossed between the startDate and endDate.
        ///    Corresponds to SQL Server's DATEDIFF(YEAR,startDate,endDate).
        /// </summary>
        /// <param name="_">The DbFunctions instance.</param>
        /// <param name="startDate">Starting date for the calculation.</param>
        /// <param name="endDate">Ending date for the calculation.</param>
        /// <returns>Number of year boundaries crossed between the dates.</returns>
        public static int DateDiffYear(
            DateTimeOffset startDate,
            DateTimeOffset endDate)
            => DateDiffYear(startDate.UtcDateTime, endDate.UtcDateTime);

        /// <summary>
        ///    Counts the number of year boundaries crossed between the startDate and endDate.
        ///    Corresponds to SQL Server's DATEDIFF(YEAR,startDate,endDate).
        /// </summary>
        /// <param name="_">The DbFunctions instance.</param>
        /// <param name="startDate">Starting date for the calculation.</param>
        /// <param name="endDate">Ending date for the calculation.</param>
        /// <returns>Number of year boundaries crossed between the dates.</returns>
        public static int? DateDiffYear(
            DateTimeOffset? startDate,
            DateTimeOffset? endDate)
            => (startDate.HasValue && endDate.HasValue)
                ? (int?)DateDiffYear(startDate.Value, endDate.Value)
                : null;

        /// <summary>
        ///    Counts the number of month boundaries crossed between the startDate and endDate.
        ///    Corresponds to SQL Server's DATEDIFF(MONTH,startDate,endDate).
        /// </summary>
        /// <param name="_">The DbFunctions instance.</param>
        /// <param name="startDate">Starting date for the calculation.</param>
        /// <param name="endDate">Ending date for the calculation.</param>
        /// <returns>Number of month boundaries crossed between the dates.</returns>
        public static int DateDiffMonth(
            DateTime startDate,
            DateTime endDate)
            => 12 * (endDate.Year - startDate.Year) + endDate.Month - startDate.Month;

        /// <summary>
        ///    Counts the number of month boundaries crossed between the startDate and endDate.
        ///    Corresponds to SQL Server's DATEDIFF(MONTH,startDate,endDate).
        /// </summary>
        /// <param name="_">The DbFunctions instance.</param>
        /// <param name="startDate">Starting date for the calculation.</param>
        /// <param name="endDate">Ending date for the calculation.</param>
        /// <returns>Number of month boundaries crossed between the dates.</returns>
        public static int? DateDiffMonth(
            DateTime? startDate,
            DateTime? endDate)
            => (startDate.HasValue && endDate.HasValue)
                ? (int?)DateDiffMonth(startDate.Value, endDate.Value)
                : null;

        /// <summary>
        ///    Counts the number of month boundaries crossed between the startDate and endDate.
        ///    Corresponds to SQL Server's DATEDIFF(MONTH,startDate,endDate).
        /// </summary>
        /// <param name="_">The DbFunctions instance.</param>
        /// <param name="startDate">Starting date for the calculation.</param>
        /// <param name="endDate">Ending date for the calculation.</param>
        /// <returns>Number of month boundaries crossed between the dates.</returns>
        public static int DateDiffMonth(
            DateTimeOffset startDate,
            DateTimeOffset endDate)
            => DateDiffMonth(startDate.UtcDateTime, endDate.UtcDateTime);

        /// <summary>
        ///    Counts the number of month boundaries crossed between the startDate and endDate.
        ///    Corresponds to SQL Server's DATEDIFF(MONTH,startDate,endDate).
        /// </summary>
        /// <param name="_">The DbFunctions instance.</param>
        /// <param name="startDate">Starting date for the calculation.</param>
        /// <param name="endDate">Ending date for the calculation.</param>
        /// <returns>Number of month boundaries crossed between the dates.</returns>
        public static int? DateDiffMonth(
            DateTimeOffset? startDate,
            DateTimeOffset? endDate)
            => (startDate.HasValue && endDate.HasValue)
                ? (int?)DateDiffMonth(startDate.Value, endDate.Value)
                : null;

        /// <summary>
        ///    Counts the number of day boundaries crossed between the startDate and endDate.
        ///    Corresponds to SQL Server's DATEDIFF(DAY,startDate,endDate).
        /// </summary>
        /// <param name="_">The DbFunctions instance.</param>
        /// <param name="startDate">Starting date for the calculation.</param>
        /// <param name="endDate">Ending date for the calculation.</param>
        /// <returns>Number of day boundaries crossed between the dates.</returns>
        public static int DateDiffDay(

            DateTime startDate,
            DateTime endDate)
            => (endDate.Date - startDate.Date).Days;

        /// <summary>
        ///    Counts the number of day boundaries crossed between the startDate and endDate.
        ///    Corresponds to SQL Server's DATEDIFF(DAY,startDate,endDate).
        /// </summary>
        /// <param name="_">The DbFunctions instance.</param>
        /// <param name="startDate">Starting date for the calculation.</param>
        /// <param name="endDate">Ending date for the calculation.</param>
        /// <returns>Number of day boundaries crossed between the dates.</returns>
        public static int? DateDiffDay(
            DateTime? startDate,
            DateTime? endDate)
            => (startDate.HasValue && endDate.HasValue)
                ? (int?)DateDiffDay(startDate.Value, endDate.Value)
                : null;

        /// <summary>
        ///    Counts the number of day boundaries crossed between the startDate and endDate.
        ///    Corresponds to SQL Server's DATEDIFF(DAY,startDate,endDate).
        /// </summary>
        /// <param name="_">The DbFunctions instance.</param>
        /// <param name="startDate">Starting date for the calculation.</param>
        /// <param name="endDate">Ending date for the calculation.</param>
        /// <returns>Number of day boundaries crossed between the dates.</returns>
        public static int DateDiffDay(
            DateTimeOffset startDate,
            DateTimeOffset endDate)
            => DateDiffDay(startDate.UtcDateTime, endDate.UtcDateTime);

        /// <summary>
        ///    Counts the number of day boundaries crossed between the startDate and endDate.
        ///    Corresponds to SQL Server's DATEDIFF(DAY,startDate,endDate).
        /// </summary>
        /// <param name="_">The DbFunctions instance.</param>
        /// <param name="startDate">Starting date for the calculation.</param>
        /// <param name="endDate">Ending date for the calculation.</param>
        /// <returns>Number of day boundaries crossed between the dates.</returns>
        public static int? DateDiffDay(
            DateTimeOffset? startDate,
            DateTimeOffset? endDate)
            => (startDate.HasValue && endDate.HasValue)
                ? (int?)DateDiffDay(startDate.Value, endDate.Value)
                : null;

        /// <summary>
        ///    Counts the number of hour boundaries crossed between the startDate and endDate.
        ///    Corresponds to SQL Server's DATEDIFF(HOUR,startDate,endDate).
        /// </summary>
        /// <param name="_">The DbFunctions instance.</param>
        /// <param name="startDate">Starting date for the calculation.</param>
        /// <param name="endDate">Ending date for the calculation.</param>
        /// <returns>Number of hour boundaries crossed between the dates.</returns>
        public static int DateDiffHour(
            DateTime startDate,
            DateTime endDate)
        {
            checked
            {
                return DateDiffDay(startDate, endDate) * 24 + endDate.Hour - startDate.Hour;
            }
        }

        /// <summary>
        ///    Counts the number of hour boundaries crossed between the startDate and endDate.
        ///    Corresponds to SQL Server's DATEDIFF(HOUR,startDate,endDate).
        /// </summary>
        /// <param name="_">The DbFunctions instance.</param>
        /// <param name="startDate">Starting date for the calculation.</param>
        /// <param name="endDate">Ending date for the calculation.</param>
        /// <returns>Number of hour boundaries crossed between the dates.</returns>
        public static int? DateDiffHour(
            DateTime? startDate,
            DateTime? endDate)
            => (startDate.HasValue && endDate.HasValue)
                ? (int?)DateDiffHour(startDate.Value, endDate.Value)
                : null;

        /// <summary>
        ///    Counts the number of hour boundaries crossed between the startDate and endDate.
        ///    Corresponds to SQL Server's DATEDIFF(HOUR,startDate,endDate).
        /// </summary>
        /// <param name="_">The DbFunctions instance.</param>
        /// <param name="startDate">Starting date for the calculation.</param>
        /// <param name="endDate">Ending date for the calculation.</param>
        /// <returns>Number of hour boundaries crossed between the dates.</returns>
        public static int DateDiffHour(
            DateTimeOffset startDate,
            DateTimeOffset endDate)
            => DateDiffHour(startDate.UtcDateTime, endDate.UtcDateTime);

        /// <summary>
        ///    Counts the number of hour boundaries crossed between the startDate and endDate.
        ///    Corresponds to SQL Server's DATEDIFF(HOUR,startDate,endDate).
        /// </summary>
        /// <param name="_">The DbFunctions instance.</param>
        /// <param name="startDate">Starting date for the calculation.</param>
        /// <param name="endDate">Ending date for the calculation.</param>
        /// <returns>Number of hour boundaries crossed between the dates.</returns>
        public static int? DateDiffHour(
            DateTimeOffset? startDate,
            DateTimeOffset? endDate)
            => (startDate.HasValue && endDate.HasValue)
                ? (int?)DateDiffHour(startDate.Value, endDate.Value)
                : null;

        /// <summary>
        ///    Counts the number of minute boundaries crossed between the startDate and endDate.
        ///    Corresponds to SQL Server's DATEDIFF(MINUTE,startDate,endDate).
        /// </summary>
        /// <param name="_">The DbFunctions instance.</param>
        /// <param name="startDate">Starting date for the calculation.</param>
        /// <param name="endDate">Ending date for the calculation.</param>
        /// <returns>Number of minute boundaries crossed between the dates.</returns>
        public static int DateDiffMinute(
            DateTime startDate,
            DateTime endDate)
        {
            checked
            {
                return DateDiffHour(startDate, endDate) * 60 + endDate.Minute - startDate.Minute;
            }
        }

        /// <summary>
        ///    Counts the number of minute boundaries crossed between the startDate and endDate.
        ///    Corresponds to SQL Server's DATEDIFF(MINUTE,startDate,endDate).
        /// </summary>
        /// <param name="_">The DbFunctions instance.</param>
        /// <param name="startDate">Starting date for the calculation.</param>
        /// <param name="endDate">Ending date for the calculation.</param>
        /// <returns>Number of minute boundaries crossed between the dates.</returns>
        public static int? DateDiffMinute(
            DateTime? startDate,
            DateTime? endDate)
            => (startDate.HasValue && endDate.HasValue)
                ? (int?)DateDiffMinute(startDate.Value, endDate.Value)
                : null;

        /// <summary>
        ///    Counts the number of minute boundaries crossed between the startDate and endDate.
        ///    Corresponds to SQL Server's DATEDIFF(MINUTE,startDate,endDate).
        /// </summary>
        /// <param name="_">The DbFunctions instance.</param>
        /// <param name="startDate">Starting date for the calculation.</param>
        /// <param name="endDate">Ending date for the calculation.</param>
        /// <returns>Number of minute boundaries crossed between the dates.</returns>
        public static int DateDiffMinute(
            DateTimeOffset startDate,
            DateTimeOffset endDate)
            => DateDiffMinute(startDate.UtcDateTime, endDate.UtcDateTime);

        /// <summary>
        ///    Counts the number of minute boundaries crossed between the startDate and endDate.
        ///    Corresponds to SQL Server's DATEDIFF(MINUTE,startDate,endDate).
        /// </summary>
        /// <param name="_">The DbFunctions instance.</param>
        /// <param name="startDate">Starting date for the calculation.</param>
        /// <param name="endDate">Ending date for the calculation.</param>
        /// <returns>Number of minute boundaries crossed between the dates.</returns>
        public static int? DateDiffMinute(
            DateTimeOffset? startDate,
            DateTimeOffset? endDate)
            => (startDate.HasValue && endDate.HasValue)
                ? (int?)DateDiffMinute(startDate.Value, endDate.Value)
                : null;

        /// <summary>
        ///    Counts the number of second boundaries crossed between the startDate and endDate.
        ///    Corresponds to SQL Server's DATEDIFF(SECOND,startDate,endDate).
        /// </summary>
        /// <param name="_">The DbFunctions instance.</param>
        /// <param name="startDate">Starting date for the calculation.</param>
        /// <param name="endDate">Ending date for the calculation.</param>
        /// <returns>Number of second boundaries crossed between the dates.</returns>
        public static int DateDiffSecond(
            DateTime startDate,
            DateTime endDate)
        {
            checked
            {
                return DateDiffMinute(startDate, endDate) * 60 + endDate.Second - startDate.Second;
            }
        }

        /// <summary>
        ///    Counts the number of second boundaries crossed between the startDate and endDate.
        ///    Corresponds to SQL Server's DATEDIFF(SECOND,startDate,endDate).
        /// </summary>
        /// <param name="_">The DbFunctions instance.</param>
        /// <param name="startDate">Starting date for the calculation.</param>
        /// <param name="endDate">Ending date for the calculation.</param>
        /// <returns>Number of second boundaries crossed between the dates.</returns>
        public static int? DateDiffSecond(
            DateTime? startDate,
            DateTime? endDate)
            => (startDate.HasValue && endDate.HasValue)
                ? (int?)DateDiffSecond(startDate.Value, endDate.Value)
                : null;

        /// <summary>
        ///    Counts the number of second boundaries crossed between the startDate and endDate.
        ///    Corresponds to SQL Server's DATEDIFF(SECOND,startDate,endDate).
        /// </summary>
        /// <param name="_">The DbFunctions instance.</param>
        /// <param name="startDate">Starting date for the calculation.</param>
        /// <param name="endDate">Ending date for the calculation.</param>
        /// <returns>Number of second boundaries crossed between the dates.</returns>
        public static int DateDiffSecond(
            DateTimeOffset startDate,
            DateTimeOffset endDate)
            => DateDiffSecond(startDate.UtcDateTime, endDate.UtcDateTime);

        /// <summary>
        ///    Counts the number of second boundaries crossed between the startDate and endDate.
        ///    Corresponds to SQL Server's DATEDIFF(SECOND,startDate,endDate).
        /// </summary>
        /// <param name="_">The DbFunctions instance.</param>
        /// <param name="startDate">Starting date for the calculation.</param>
        /// <param name="endDate">Ending date for the calculation.</param>
        /// <returns>Number of second boundaries crossed between the dates.</returns>
        public static int? DateDiffSecond(
            DateTimeOffset? startDate,
            DateTimeOffset? endDate)
            => (startDate.HasValue && endDate.HasValue)
                ? (int?)DateDiffSecond(startDate.Value, endDate.Value)
                : null;

        /// <summary>
        ///    Counts the number of millisecond boundaries crossed between the startDate and endDate.
        ///    Corresponds to SQL Server's DATEDIFF(MILLISECOND,startDate,endDate).
        /// </summary>
        /// <param name="_">The DbFunctions instance.</param>
        /// <param name="startDate">Starting date for the calculation.</param>
        /// <param name="endDate">Ending date for the calculation.</param>
        /// <returns>Number of millisecond boundaries crossed between the dates.</returns>
        public static int DateDiffMillisecond(
            DateTime startDate,
            DateTime endDate)
        {
            checked
            {
                return DateDiffSecond(startDate, endDate) * 1000 + endDate.Millisecond - startDate.Millisecond;
            }
        }

        /// <summary>
        ///    Counts the number of millisecond boundaries crossed between the startDate and endDate.
        ///    Corresponds to SQL Server's DATEDIFF(MILLISECOND,startDate,endDate).
        /// </summary>
        /// <param name="_">The DbFunctions instance.</param>
        /// <param name="startDate">Starting date for the calculation.</param>
        /// <param name="endDate">Ending date for the calculation.</param>
        /// <returns>Number of millisecond boundaries crossed between the dates.</returns>
        public static int? DateDiffMillisecond(
            DateTime? startDate,
            DateTime? endDate)
            => (startDate.HasValue && endDate.HasValue)
                ? (int?)DateDiffMillisecond(startDate.Value, endDate.Value)
                : null;

        /// <summary>
        ///    Counts the number of millisecond boundaries crossed between the startDate and endDate.
        ///    Corresponds to SQL Server's DATEDIFF(MILLISECOND,startDate,endDate).
        /// </summary>
        /// <param name="_">The DbFunctions instance.</param>
        /// <param name="startDate">Starting date for the calculation.</param>
        /// <param name="endDate">Ending date for the calculation.</param>
        /// <returns>Number of millisecond boundaries crossed between the dates.</returns>
        public static int DateDiffMillisecond(
            DateTimeOffset startDate,
            DateTimeOffset endDate)
            => DateDiffMillisecond(startDate.UtcDateTime, endDate.UtcDateTime);

        /// <summary>
        ///    Counts the number of millisecond boundaries crossed between the startDate and endDate.
        ///    Corresponds to SQL Server's DATEDIFF(MILLISECOND,startDate,endDate).
        /// </summary>
        /// <param name="_">The DbFunctions instance.</param>
        /// <param name="startDate">Starting date for the calculation.</param>
        /// <param name="endDate">Ending date for the calculation.</param>
        /// <returns>Number of millisecond boundaries crossed between the dates.</returns>
        public static int? DateDiffMillisecond(
            DateTimeOffset? startDate,
            DateTimeOffset? endDate)
            => (startDate.HasValue && endDate.HasValue)
                ? (int?)DateDiffMillisecond(startDate.Value, endDate.Value)
                : null;

        /// <summary>
        ///    Counts the number of microsecond boundaries crossed between the startDate and endDate.
        ///    Corresponds to SQL Server's DATEDIFF(MICROSECOND,startDate,endDate).
        /// </summary>
        /// <param name="_">The DbFunctions instance.</param>
        /// <param name="startDate">Starting date for the calculation.</param>
        /// <param name="endDate">Ending date for the calculation.</param>
        /// <returns>Number of microsecond boundaries crossed between the dates.</returns>
        public static int DateDiffMicrosecond(
            DateTime startDate,
            DateTime endDate)
        {
            checked
            {
                return (int)((endDate.Ticks - startDate.Ticks) / 10);
            }
        }

        /// <summary>
        ///    Counts the number of microsecond boundaries crossed between the startDate and endDate.
        ///    Corresponds to SQL Server's DATEDIFF(MICROSECOND,startDate,endDate).
        /// </summary>
        /// <param name="_">The DbFunctions instance.</param>
        /// <param name="startDate">Starting date for the calculation.</param>
        /// <param name="endDate">Ending date for the calculation.</param>
        /// <returns>Number of microsecond boundaries crossed between the dates.</returns>
        public static int? DateDiffMicrosecond(
            DateTime? startDate,
            DateTime? endDate)
            => (startDate.HasValue && endDate.HasValue)
                ? (int?)DateDiffMicrosecond(startDate.Value, endDate.Value)
                : null;

        /// <summary>
        ///    Counts the number of microsecond boundaries crossed between the startDate and endDate.
        ///    Corresponds to SQL Server's DATEDIFF(MICROSECOND,startDate,endDate).
        /// </summary>
        /// <param name="_">The DbFunctions instance.</param>
        /// <param name="startDate">Starting date for the calculation.</param>
        /// <param name="endDate">Ending date for the calculation.</param>
        /// <returns>Number of microsecond boundaries crossed between the dates.</returns>
        public static int DateDiffMicrosecond(
            DateTimeOffset startDate,
            DateTimeOffset endDate)
            => DateDiffMicrosecond(startDate.UtcDateTime, endDate.UtcDateTime);

        /// <summary>
        ///    Counts the number of microsecond boundaries crossed between the startDate and endDate.
        ///    Corresponds to SQL Server's DATEDIFF(MICROSECOND,startDate,endDate).
        /// </summary>
        /// <param name="_">The DbFunctions instance.</param>
        /// <param name="startDate">Starting date for the calculation.</param>
        /// <param name="endDate">Ending date for the calculation.</param>
        /// <returns>Number of microsecond boundaries crossed between the dates.</returns>
        public static int? DateDiffMicrosecond(
            DateTimeOffset? startDate,
            DateTimeOffset? endDate)
            => (startDate.HasValue && endDate.HasValue)
                ? (int?)DateDiffMicrosecond(startDate.Value, endDate.Value)
                : null;

        /// <summary>
        ///    Counts the number of nanosecond boundaries crossed between the startDate and endDate.
        ///    Corresponds to SQL Server's DATEDIFF(NANOSECOND,startDate,endDate).
        /// </summary>
        /// <param name="_">The DbFunctions instance.</param>
        /// <param name="startDate">Starting date for the calculation.</param>
        /// <param name="endDate">Ending date for the calculation.</param>
        /// <returns>Number of nanosecond boundaries crossed between the dates.</returns>
        public static int DateDiffNanosecond(
            DateTime startDate,
            DateTime endDate)
        {
            checked
            {
                return (int)((endDate.Ticks - startDate.Ticks) * 100);
            }
        }

        /// <summary>
        ///    Counts the number of nanosecond boundaries crossed between the startDate and endDate.
        ///    Corresponds to SQL Server's DATEDIFF(NANOSECOND,startDate,endDate).
        /// </summary>
        /// <param name="_">The DbFunctions instance.</param>
        /// <param name="startDate">Starting date for the calculation.</param>
        /// <param name="endDate">Ending date for the calculation.</param>
        /// <returns>Number of nanosecond boundaries crossed between the dates.</returns>
        public static int? DateDiffNanosecond(
            DateTime? startDate,
            DateTime? endDate)
            => (startDate.HasValue && endDate.HasValue)
                ? (int?)DateDiffNanosecond(startDate.Value, endDate.Value)
                : null;

        /// <summary>
        ///    Counts the number of nanosecond boundaries crossed between the startDate and endDate.
        ///    Corresponds to SQL Server's DATEDIFF(NANOSECOND,startDate,endDate).
        /// </summary>
        /// <param name="_">The DbFunctions instance.</param>
        /// <param name="startDate">Starting date for the calculation.</param>
        /// <param name="endDate">Ending date for the calculation.</param>
        /// <returns>Number of nanosecond boundaries crossed between the dates.</returns>
        public static int DateDiffNanosecond(
            DateTimeOffset startDate,
            DateTimeOffset endDate)
            => DateDiffNanosecond(startDate.UtcDateTime, endDate.UtcDateTime);

        /// <summary>
        ///    Counts the number of nanosecond boundaries crossed between the startDate and endDate.
        ///    Corresponds to SQL Server's DATEDIFF(NANOSECOND,startDate,endDate).
        /// </summary>
        /// <param name="_">The DbFunctions instance.</param>
        /// <param name="startDate">Starting date for the calculation.</param>
        /// <param name="endDate">Ending date for the calculation.</param>
        /// <returns>Number of nanosecond boundaries crossed between the dates.</returns>
        public static int? DateDiffNanosecond(
            DateTimeOffset? startDate,
            DateTimeOffset? endDate)
            => (startDate.HasValue && endDate.HasValue)
                ? (int?)DateDiffNanosecond(startDate.Value, endDate.Value)
                : null;
    }
}
