using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BlankApp1.ViewModels
{
   using Blank1.Models;


   public class MainPageViewModel : ViewModelBase
   {
   #region Public
      public MainPageViewModel( INavigationService navigationService )
         : base( navigationService )
      {
         Title = "Main Page";

         GroupsItems = new[]
                       {
                          new Group
                          {
                             Items = new[]
                                     {
                                        new Item(),
                                        new Item(),
                                        new Item(),
                                     },
                          },
                          new Group
                          {
                             Items = new[]
                                     {
                                        new Item(),
                                        new Item(),
                                        new Item(),
                                     },
                          },
                       }
            ;
      }

      public Group[] GroupsItems
      {
         get => m_groupsItems;
         set => SetProperty( storage: ref m_groupsItems, value: value );
      }
   #endregion


   #region Private
      private Group[] m_groupsItems;
   #endregion
   }
}
