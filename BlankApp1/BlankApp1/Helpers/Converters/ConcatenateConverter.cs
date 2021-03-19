namespace Blank1.Helpers.Converters
{
   using System;
   using System.Globalization;
   using System.Linq;

   using Xamarin.Forms;


   public class ConcatenateConverter
      : IMultiValueConverter
   {
   #region Public
      public object Convert( object[] values, Type target_type, object parameter, CultureInfo culture )
      {
         return values is null
                   ? ""
                   : values.Aggregate( seed: "", func: ConcatenateConverter.Append )?.Trim();
      }

      public object[] ConvertBack( object value, Type[] target_types, object parameter, CultureInfo culture )
      {
         return value is string myString
                   ? myString.Split( separator: ' ' ).ToArray< object >()
                   : new object[]
                     {};
      }
   #endregion


   #region Private
      private static string Append( string previous, object current )
      {
         return current is not null
                   ? previous + " " + current
                   : previous;
      }
   #endregion
   }
}
