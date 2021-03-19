namespace Blank1.Models
{
   public class Group : DashboardItem
   {
   #region Public
      public Item[] Items{ get; set; }

      public int ItemsQuantity
      {
         get
         {
            var items = Items;

            return items?.Length ?? -1;
         }
      }
   #endregion
   }
}
