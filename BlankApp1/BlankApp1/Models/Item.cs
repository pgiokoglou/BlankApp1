namespace Blank1.Models
{
   using System;


   public class Item : DashboardItem
   {
      #region Public
      public DateTime Date
      {
         get;
         set;
      }

      public bool Live
      {
         get;
         set;
      }

      public string Name
      {
         get;
         set;
      }

      public string Place
      {
         get;
         set;
      }

      public int RecordingsQuantity
      {
         get;
         set;
      }

      public int SensorsQuantity
      {
         get;
         set;
      }

      public DateTime Time
      {
         get;
         set;
      }
      #endregion
   }
}
