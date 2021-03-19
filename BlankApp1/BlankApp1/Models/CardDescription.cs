namespace Blank1.Models
{
   using System;
   using System.Diagnostics;

   using Xamarin.Forms;


   public class CardDescription
      : BindableObject
   {
   #region Public
      public static readonly BindableProperty IconProperty = BindableProperty.Create( propertyName: nameof( CardDescription.Icon ),
                                                                                      returnType: typeof( string ),
                                                                                      declaringType: typeof( CardDescription ),
                                                                                      defaultBindingMode: BindingMode.TwoWay,
                                                                                      propertyChanged: CardDescription.OnIconChanged );

      public static readonly BindableProperty TextProperty = BindableProperty.Create( propertyName: nameof( CardDescription.Text ),
                                                                                      returnType: typeof( string ),
                                                                                      declaringType: typeof( CardDescription ),
                                                                                      defaultBindingMode: BindingMode.TwoWay,
                                                                                      propertyChanged: CardDescription.OnDescriptionChanged );

      public string Icon
      {
         get => (string)GetValue( IconProperty );
         set => SetValue( property: IconProperty, value: value );
      }

      public string Text
      {
         get => (string)GetValue( TextProperty );
         set => SetValue( property: TextProperty, value: value );
      }
   #endregion


   #region Private
      private static void OnIconChanged( BindableObject bindable, object old_value, object new_value )
      {
         try
         {
            ( (CardDescription)bindable ).Icon = new_value as string;
         }
         catch( Exception )
         {
            // ignored
         }
      }

      private static void OnDescriptionChanged( BindableObject bindable, object old_value, object new_value )
      {
         if( new_value == null )
         {
            return;
         }

         if( bindable is not CardDescription item )
         {
            return;
         }

         item.Text = new_value as string;
      }
   #endregion
   }
}
